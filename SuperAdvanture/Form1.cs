using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace SuperAdvanture
{
    public partial class Form1 : Form
    {
        //플레이어
        private Player player;

        //로케이션
        Location location;

        public Form1()
        {
            InitializeComponent();

            player = new Player();

            //플레이어의 기본 설정
            player.CurrentHitPoints = 10;
            player.MaximumHitPoints = 10;
            player.Gold = 20;
            player.ExperiencePoints = 0;
            player.Level = 1;

            //플레이어의 기본 설정을 화면에 표시
            HitPointsLabel.Text = player.CurrentHitPoints.ToString();
            GoldLabel.Text = player.Gold.ToString();
            ExperienceLabel.Text = player.ExperiencePoints.ToString();
            LevelLabel.Text = player.Level.ToString();

            //로케이션 설정
            
        }
        
    }
}
