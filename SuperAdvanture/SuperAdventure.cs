using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//게임 엔진 추가
using Engine;

namespace SuperAdvanture
{
    public partial class SuperAdventure : Form
    {
        //플레이어
        private Player player;
        //현재 조우한 몬스터
        private Monster currentMonster;
        
        public SuperAdventure()
        {
            InitializeComponent();

            //플레이어 생성 - 생성자를 이용한 방식으로 변경.
            //플레이어에 관한 모든 내용들을 초기화한다.
            player = new Player(10, 10, 20, 0, 1);
            MoveTo(World.LocationByID(World.LOCATION_ID_HOME));
            player.Inventory.Add(new InventoryItem(World.ItemByID(World.ITEM_ID_RUSTY_SWORD), 1));

            HitPointsLabel.Text = player.CurrentHitPoints.ToString();
            GoldLabel.Text = player.Gold.ToString();
            ExperienceLabel.Text = player.ExperiencePoints.ToString();
            LevelLabel.Text = player.Level.ToString();

        }

        private void UseWeaponButton_Click(object sender, EventArgs e)
        {

        }

        private void UsePotionButton_Click(object sender, EventArgs e)
        {

        }

        private void MoveTo(Location newLocation)
        {
            //위치에 필수 항목이 있는지 체크한다.
            if (newLocation.ItemRequiredToEnter != null)
            {
                //플레이어가 인벤토리에 필요한 항목을 가지고 있는지 확인하기 위해 이용
                bool playerHasRequiredItem = false;

                foreach (InventoryItem ii in player.Inventory)
                {
                    if (ii.Details.ID == newLocation.ItemRequiredToEnter.ID)
                    {
                        //해당 아이템 항목을 찾음.
                        playerHasRequiredItem = true;
                        break;
                    }
                }

                if (!playerHasRequiredItem)
                {
                    //필요한 항목을 찾지 못함.
                    //메시지 출력하고 이동을 중지시킨다.
                    MessageRichTextBox.Text += "You must have a " + newLocation.ItemRequiredToEnter.Name + " to enter this location." + Environment.NewLine;
                    return;
                }
            }

            // 플레이어의 현재 위치를 갱신
            player.CurrentLocation = newLocation;

            // 움직이는 데 필요한 버튼을 보이고 가려준다.
            NorthButton.Visible = (newLocation.LocationToNorth != null);
            EastButton.Visible = (newLocation.LocationToEast != null);
            SouthButton.Visible = (newLocation.LocationToSouth != null);
            WestButton.Visible = (newLocation.LocationToWest != null);

            // 현재 위치의 이름 및 설명 표시
            LocationRichTextBox.Text = newLocation.Name + Environment.NewLine;
            LocationRichTextBox.Text += newLocation.Description + Environment.NewLine;

            // 플레이어를 완전 치유한다.
            player.CurrentHitPoints = player.MaximumHitPoints;

            // 화면에서 히트 포인트 업데이트
            HitPointsLabel.Text = player.CurrentHitPoints.ToString();

            // 이 로케이션에 퀘스트가 존재하는지 확인
            if (newLocation.QuestAvailableHere != null)
            {
                // 플레이어가 이미 퀘스트를 가지고 있는지 확인한다.
                // 가지고 있다면 완료했는지도 확인한다.
                bool playerAlreadyHasQuest = false;
                bool playerAlreadyCompletedQuest = false;

                foreach (PlayerQuest playerQuest in player.Quests)
                {
                    if (playerQuest.Details.ID == newLocation.QuestAvailableHere.ID)
                    {
                        playerAlreadyHasQuest = true;

                        if (playerQuest.IsCompleted)
                        {
                            playerAlreadyCompletedQuest = true;
                        }
                    }
                }

                // 플레이어가 이미 퀘스트를 가지고 있는지 확인한다.
                if (playerAlreadyHasQuest)
                {
                    // 플레이어가 퀘스트를 전부 완료하지 않았을 경우
                    if (!playerAlreadyCompletedQuest)
                    {
                        // 플레이어가 퀘스트를 완료하는 데 필요한 모든 항목을 가지고 있는지 확인한다.
                        bool playerHasAllItemsToCompleteQuest = true;

                        foreach (QuestCompletionItem qci in newLocation.QuestAvailableHere.QuestCompletionItems)
                        {
                            bool foundItemInPlayersInventory = false;

                            // 플레이어의 인벤토리에있는 각 항목을 확인하여 보유하고 있는지 확인합니다.
                            foreach (InventoryItem ii in player.Inventory)
                            {
                                // 플레이어가 인벤토리에이 항목을 가지고 있다.
                                if (ii.Details.ID == qci.Details.ID)
                                {
                                    foundItemInPlayersInventory = true;

                                    if (ii.Quantity < qci.Quantity)
                                    {
                                        // 플레이어가 퀘스트를 완료하기에 충분하지 않다.
                                        // 다른 퀘스트 완료 항목을 계속 확인 안해도 되니 false로 변경 후 나간다.
                                        playerHasAllItemsToCompleteQuest = false;

                                        break;
                                    }

                                    // 항목을 찾았으므로 플레이어의 나머지 인벤토리를 확인하지 않고 넘긴다.
                                    break;
                                }
                            }

                            // 필요한 항목을 찾지 못하면 변수를 설정하고 다른 항목을 찾지 않는다.
                            if (!foundItemInPlayersInventory)
                            {
                                // 플레이어가 인벤토리에이 아이템을 가지고 있지 않다.
                                // 더 이상 확인할 필요가 없으므로 그대로 나간다.
                                playerHasAllItemsToCompleteQuest = false;

                                break;
                            }
                        }

                        // 플레이어는 퀘스트를 완료하는 데 필요한 모든 항목을 가지고 있다.
                        if (playerHasAllItemsToCompleteQuest)
                        {
                            // 메시지를 표시한다.
                            MessageRichTextBox.Text += Environment.NewLine;
                            MessageRichTextBox.Text += "You complete the '" + newLocation.QuestAvailableHere.Name + "' quest." + Environment.NewLine;

                            // 인벤토리에서 퀘스트 아이템을 제거합니다.
                            foreach (QuestCompletionItem qci in newLocation.QuestAvailableHere.QuestCompletionItems)
                            {
                                foreach (InventoryItem ii in player.Inventory)
                                {
                                    if (ii.Details.ID == qci.Details.ID)
                                    {
                                        // 퀘스트 완료에 필요한 아이템을 인벤토리에서 뺀다.
                                        ii.Quantity -= qci.Quantity;
                                        break;
                                    }
                                }
                            }

                            // 퀘스트 보상을 받는다.
                            MessageRichTextBox.Text += "You receive: " + Environment.NewLine;
                            MessageRichTextBox.Text += newLocation.QuestAvailableHere.RewardExperiencePoints.ToString() + " experience points" + Environment.NewLine;
                            MessageRichTextBox.Text += newLocation.QuestAvailableHere.RewardGold.ToString() + " gold" + Environment.NewLine;
                            MessageRichTextBox.Text += newLocation.QuestAvailableHere.RewardItem.Name + Environment.NewLine;
                            MessageRichTextBox.Text += Environment.NewLine;

                            player.ExperiencePoints += newLocation.QuestAvailableHere.RewardExperiencePoints;
                            player.Gold += newLocation.QuestAvailableHere.RewardGold;

                            // 플레이어의 인벤토리에 보상 항목을 추가한다.
                            bool addedItemToPlayerInventory = false;

                            foreach (InventoryItem ii in player.Inventory)
                            {
                                if (ii.Details.ID == newLocation.QuestAvailableHere.RewardItem.ID)
                                {
                                    // 재고가있는 품목이므로 수량을 하나 늘린다.
                                    ii.Quantity++;

                                    addedItemToPlayerInventory = true;

                                    break;
                                }
                            }

                            // 항목이 없으므로 수량을 1로하여 인벤토리에 추가한다.
                            if (!addedItemToPlayerInventory)
                            {
                                player.Inventory.Add(new InventoryItem(newLocation.QuestAvailableHere.RewardItem, 1));
                            }

                            // 완료된 퀘스트를 표시한다.
                            // 플레이어의 퀘스트 목록에서 퀘스트를 찾는다.
                            foreach (PlayerQuest pq in player.Quests)
                            {
                                if (pq.Details.ID == newLocation.QuestAvailableHere.ID)
                                {
                                    // 완료로 표시한다.
                                    pq.IsCompleted = true;

                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    // 플레이어는 이미 퀘스트를 가지고 있지 않다.

                    // 메시지를 표시한다.
                    MessageRichTextBox.Text += "You receive the " + newLocation.QuestAvailableHere.Name + " quest." + Environment.NewLine;
                    MessageRichTextBox.Text += newLocation.QuestAvailableHere.Description + Environment.NewLine;
                    MessageRichTextBox.Text += "To complete it, return with:" + Environment.NewLine;
                    foreach (QuestCompletionItem qci in newLocation.QuestAvailableHere.QuestCompletionItems)
                    {
                        if (qci.Quantity == 1)
                        {
                            MessageRichTextBox.Text += qci.Quantity.ToString() + " " + qci.Details.Name + Environment.NewLine;
                        }
                        else
                        {
                            MessageRichTextBox.Text += qci.Quantity.ToString() + " " + qci.Details.NamePlural + Environment.NewLine;
                        }
                    }
                    MessageRichTextBox.Text += Environment.NewLine;

                    // 플레이어의 퀘스트 리스트에 퀘스트를 추가한다.
                    player.Quests.Add(new PlayerQuest(newLocation.QuestAvailableHere));
                }
            }

            // 위치에 몬스터가 있는가?
            if (newLocation.MonsterLivingHere != null)
            {
                MessageRichTextBox.Text += "You see a " + newLocation.MonsterLivingHere.Name + Environment.NewLine;

                // World.Monster 목록에 있는 표준 몬스터들을 이용하여 새로운 몬스터를 만든다.
                Monster standardMonster = World.MonsterByID(newLocation.MonsterLivingHere.ID);

                currentMonster = new Monster(standardMonster.ID, standardMonster.Name, standardMonster.MaximumDamage,
                    standardMonster.RewardExperiencePoints, standardMonster.RewardGold, standardMonster.CurrentHitPoints, standardMonster.MaximumHitPoints);

                foreach (LootItem lootItem in standardMonster.LootTable)
                {
                    currentMonster.LootTable.Add(lootItem);
                }

                WeaponComboBox.Visible = true;
                PotionComboBox.Visible = true;
                UseWeaponButton.Visible = true;
                UsePotionButton.Visible = true;
            }
            else
            {
                currentMonster = null;

                WeaponComboBox.Visible = false;
                PotionComboBox.Visible = false;
                UseWeaponButton.Visible = false;
                UsePotionButton.Visible = false;
            }

            // 플레이어의 인벤토리 목록을 새로 고친다
            InventoryDataGridView.RowHeadersVisible = false;

            InventoryDataGridView.ColumnCount = 2;
            InventoryDataGridView.Columns[0].Name = "Name";
            InventoryDataGridView.Columns[0].Width = 197;
            InventoryDataGridView.Columns[1].Name = "Quantity";

            InventoryDataGridView.Rows.Clear();

            foreach (InventoryItem inventoryItem in player.Inventory)
            {
                if (inventoryItem.Quantity > 0)
                {
                    InventoryDataGridView.Rows.Add(new[] { inventoryItem.Details.Name, inventoryItem.Quantity.ToString() });
                }
            }

            // 플레이어의 퀘스트 리스트를 새로 고친다.
            QuestsDataGridView.RowHeadersVisible = false;

            QuestsDataGridView.ColumnCount = 2;
            QuestsDataGridView.Columns[0].Name = "Name";
            QuestsDataGridView.Columns[0].Width = 197;
            QuestsDataGridView.Columns[1].Name = "Done?";

            QuestsDataGridView.Rows.Clear();

            foreach (PlayerQuest playerQuest in player.Quests)
            {
                QuestsDataGridView.Rows.Add(new[] { playerQuest.Details.Name, playerQuest.IsCompleted.ToString() });
            }

            // 플레이어의 무기 콤보박스를 새로 고친다.
            List<Weapon> weapons = new List<Weapon>();

            foreach (InventoryItem inventoryItem in player.Inventory)
            {
                if (inventoryItem.Details is Weapon)
                {
                    if (inventoryItem.Quantity > 0)
                    {
                        weapons.Add((Weapon)inventoryItem.Details);
                    }
                }
            }

            if (weapons.Count == 0)
            {
                // 플레이어는 무기가 없으므로 무기 콤보 박스와 "사용"버튼을 숨 깁니다.
                WeaponComboBox.Visible = false;
                UseWeaponButton.Visible = false;
            }
            else
            {
                WeaponComboBox.DataSource = weapons;
                WeaponComboBox.DisplayMember = "Name";
                WeaponComboBox.ValueMember = "ID";

                WeaponComboBox.SelectedIndex = 0;
            }

            // 플레이어의 포션을 새로고침한다.
            List<HealingPotion> healingPotions = new List<HealingPotion>();

            foreach (InventoryItem inventoryItem in player.Inventory)
            {
                if (inventoryItem.Details is HealingPotion)
                {
                    if (inventoryItem.Quantity > 0)
                    {
                        healingPotions.Add((HealingPotion)inventoryItem.Details);
                    }
                }
            }

            if (healingPotions.Count == 0)
            {
                // 플레이어는 포션이 없으므로 포션 콤보 박스와 "사용"버튼을 숨 깁니다.
                PotionComboBox.Visible = false;
                UsePotionButton.Visible = false;
            }
            else
            {
                PotionComboBox.DataSource = healingPotions;
                PotionComboBox.DisplayMember = "Name";
                PotionComboBox.ValueMember = "ID";

                PotionComboBox.SelectedIndex = 0;
            }
        }

        private void NorthButton_Click(object sender, EventArgs e)
        {
            MoveTo(player.CurrentLocation.LocationToNorth);
        }

        private void SouthButton_Click(object sender, EventArgs e)
        {
            MoveTo(player.CurrentLocation.LocationToSouth);
        }

        private void EastButton_Click(object sender, EventArgs e)
        {
            MoveTo(player.CurrentLocation.LocationToEast);
        }

        private void WestButton_Click(object sender, EventArgs e)
        {
            MoveTo(player.CurrentLocation.LocationToWest);
        }
    }
}
