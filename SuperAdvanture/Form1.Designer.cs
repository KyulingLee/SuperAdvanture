namespace SuperAdvanture
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.ExperienceLabel = new System.Windows.Forms.Label();
            this.GoldLabel = new System.Windows.Forms.Label();
            this.HitPointsLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WeaponComboBox = new System.Windows.Forms.ComboBox();
            this.PotionComboBox = new System.Windows.Forms.ComboBox();
            this.UseWeaponButton = new System.Windows.Forms.Button();
            this.UsePotionButton = new System.Windows.Forms.Button();
            this.NorthButton = new System.Windows.Forms.Button();
            this.EastButton = new System.Windows.Forms.Button();
            this.SouthButton = new System.Windows.Forms.Button();
            this.WestButton = new System.Windows.Forms.Button();
            this.LocationRichTextBox = new System.Windows.Forms.RichTextBox();
            this.MessageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.InventoryDataGridView = new System.Windows.Forms.DataGridView();
            this.QuestsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hit Points:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gold:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Experience:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Level:";
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Location = new System.Drawing.Point(110, 100);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(15, 15);
            this.LevelLabel.TabIndex = 7;
            this.LevelLabel.Text = "0";
            // 
            // ExperienceLabel
            // 
            this.ExperienceLabel.AutoSize = true;
            this.ExperienceLabel.Location = new System.Drawing.Point(110, 74);
            this.ExperienceLabel.Name = "ExperienceLabel";
            this.ExperienceLabel.Size = new System.Drawing.Size(15, 15);
            this.ExperienceLabel.TabIndex = 6;
            this.ExperienceLabel.Text = "0";
            // 
            // GoldLabel
            // 
            this.GoldLabel.AutoSize = true;
            this.GoldLabel.Location = new System.Drawing.Point(110, 46);
            this.GoldLabel.Name = "GoldLabel";
            this.GoldLabel.Size = new System.Drawing.Size(15, 15);
            this.GoldLabel.TabIndex = 5;
            this.GoldLabel.Text = "0";
            // 
            // HitPointsLabel
            // 
            this.HitPointsLabel.AutoSize = true;
            this.HitPointsLabel.Location = new System.Drawing.Point(110, 20);
            this.HitPointsLabel.Name = "HitPointsLabel";
            this.HitPointsLabel.Size = new System.Drawing.Size(15, 15);
            this.HitPointsLabel.TabIndex = 4;
            this.HitPointsLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(617, 531);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Select Action";
            // 
            // WeaponComboBox
            // 
            this.WeaponComboBox.FormattingEnabled = true;
            this.WeaponComboBox.Location = new System.Drawing.Point(369, 559);
            this.WeaponComboBox.Name = "WeaponComboBox";
            this.WeaponComboBox.Size = new System.Drawing.Size(245, 23);
            this.WeaponComboBox.TabIndex = 9;
            // 
            // PotionComboBox
            // 
            this.PotionComboBox.FormattingEnabled = true;
            this.PotionComboBox.Location = new System.Drawing.Point(369, 593);
            this.PotionComboBox.Name = "PotionComboBox";
            this.PotionComboBox.Size = new System.Drawing.Size(245, 23);
            this.PotionComboBox.TabIndex = 10;
            // 
            // UseWeaponButton
            // 
            this.UseWeaponButton.Location = new System.Drawing.Point(620, 559);
            this.UseWeaponButton.Name = "UseWeaponButton";
            this.UseWeaponButton.Size = new System.Drawing.Size(75, 23);
            this.UseWeaponButton.TabIndex = 11;
            this.UseWeaponButton.Text = "Use";
            this.UseWeaponButton.UseVisualStyleBackColor = true;
            // 
            // UsePotionButton
            // 
            this.UsePotionButton.Location = new System.Drawing.Point(620, 593);
            this.UsePotionButton.Name = "UsePotionButton";
            this.UsePotionButton.Size = new System.Drawing.Size(75, 23);
            this.UsePotionButton.TabIndex = 12;
            this.UsePotionButton.Text = "Use";
            this.UsePotionButton.UseVisualStyleBackColor = true;
            // 
            // NorthButton
            // 
            this.NorthButton.Location = new System.Drawing.Point(493, 433);
            this.NorthButton.Name = "NorthButton";
            this.NorthButton.Size = new System.Drawing.Size(75, 23);
            this.NorthButton.TabIndex = 13;
            this.NorthButton.Text = "North";
            this.NorthButton.UseVisualStyleBackColor = true;
            // 
            // EastButton
            // 
            this.EastButton.Location = new System.Drawing.Point(573, 457);
            this.EastButton.Name = "EastButton";
            this.EastButton.Size = new System.Drawing.Size(75, 23);
            this.EastButton.TabIndex = 14;
            this.EastButton.Text = "East";
            this.EastButton.UseVisualStyleBackColor = true;
            // 
            // SouthButton
            // 
            this.SouthButton.Location = new System.Drawing.Point(493, 487);
            this.SouthButton.Name = "SouthButton";
            this.SouthButton.Size = new System.Drawing.Size(75, 23);
            this.SouthButton.TabIndex = 15;
            this.SouthButton.Text = "South";
            this.SouthButton.UseVisualStyleBackColor = true;
            // 
            // WestButton
            // 
            this.WestButton.Location = new System.Drawing.Point(412, 457);
            this.WestButton.Name = "WestButton";
            this.WestButton.Size = new System.Drawing.Size(75, 23);
            this.WestButton.TabIndex = 16;
            this.WestButton.Text = "West";
            this.WestButton.UseVisualStyleBackColor = true;
            // 
            // LocationRichTextBox
            // 
            this.LocationRichTextBox.Location = new System.Drawing.Point(347, 19);
            this.LocationRichTextBox.Name = "LocationRichTextBox";
            this.LocationRichTextBox.ReadOnly = true;
            this.LocationRichTextBox.Size = new System.Drawing.Size(360, 105);
            this.LocationRichTextBox.TabIndex = 17;
            this.LocationRichTextBox.Text = "";
            // 
            // MessageRichTextBox
            // 
            this.MessageRichTextBox.Location = new System.Drawing.Point(347, 130);
            this.MessageRichTextBox.Name = "MessageRichTextBox";
            this.MessageRichTextBox.ReadOnly = true;
            this.MessageRichTextBox.Size = new System.Drawing.Size(360, 286);
            this.MessageRichTextBox.TabIndex = 18;
            this.MessageRichTextBox.Text = "";
            // 
            // InventoryDataGridView
            // 
            this.InventoryDataGridView.AllowUserToAddRows = false;
            this.InventoryDataGridView.AllowUserToDeleteRows = false;
            this.InventoryDataGridView.AllowUserToResizeRows = false;
            this.InventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.InventoryDataGridView.Enabled = false;
            this.InventoryDataGridView.Location = new System.Drawing.Point(16, 130);
            this.InventoryDataGridView.MultiSelect = false;
            this.InventoryDataGridView.Name = "InventoryDataGridView";
            this.InventoryDataGridView.ReadOnly = true;
            this.InventoryDataGridView.RowHeadersVisible = false;
            this.InventoryDataGridView.RowTemplate.Height = 27;
            this.InventoryDataGridView.Size = new System.Drawing.Size(312, 309);
            this.InventoryDataGridView.TabIndex = 19;
            // 
            // QuestsDataGridView
            // 
            this.QuestsDataGridView.AllowUserToAddRows = false;
            this.QuestsDataGridView.AllowUserToDeleteRows = false;
            this.QuestsDataGridView.AllowUserToResizeRows = false;
            this.QuestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuestsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.QuestsDataGridView.Enabled = false;
            this.QuestsDataGridView.Location = new System.Drawing.Point(16, 446);
            this.QuestsDataGridView.MultiSelect = false;
            this.QuestsDataGridView.Name = "QuestsDataGridView";
            this.QuestsDataGridView.ReadOnly = true;
            this.QuestsDataGridView.RowHeadersVisible = false;
            this.QuestsDataGridView.RowTemplate.Height = 27;
            this.QuestsDataGridView.Size = new System.Drawing.Size(312, 189);
            this.QuestsDataGridView.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 643);
            this.Controls.Add(this.QuestsDataGridView);
            this.Controls.Add(this.InventoryDataGridView);
            this.Controls.Add(this.MessageRichTextBox);
            this.Controls.Add(this.LocationRichTextBox);
            this.Controls.Add(this.WestButton);
            this.Controls.Add(this.SouthButton);
            this.Controls.Add(this.EastButton);
            this.Controls.Add(this.NorthButton);
            this.Controls.Add(this.UsePotionButton);
            this.Controls.Add(this.UseWeaponButton);
            this.Controls.Add(this.PotionComboBox);
            this.Controls.Add(this.WeaponComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.ExperienceLabel);
            this.Controls.Add(this.GoldLabel);
            this.Controls.Add(this.HitPointsLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kyuling\'s RPG Game";
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label ExperienceLabel;
        private System.Windows.Forms.Label GoldLabel;
        private System.Windows.Forms.Label HitPointsLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox WeaponComboBox;
        private System.Windows.Forms.ComboBox PotionComboBox;
        private System.Windows.Forms.Button UseWeaponButton;
        private System.Windows.Forms.Button UsePotionButton;
        private System.Windows.Forms.Button NorthButton;
        private System.Windows.Forms.Button EastButton;
        private System.Windows.Forms.Button SouthButton;
        private System.Windows.Forms.Button WestButton;
        private System.Windows.Forms.RichTextBox LocationRichTextBox;
        private System.Windows.Forms.RichTextBox MessageRichTextBox;
        private System.Windows.Forms.DataGridView InventoryDataGridView;
        private System.Windows.Forms.DataGridView QuestsDataGridView;
    }
}

