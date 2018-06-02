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

            //플레이어 생성 - 생성자를 이용한 방식으로 변경.
            player = new Player(10, 10, 20, 0, 1);
            
            //플레이어의 기본 설정을 화면에 표시
            HitPointsLabel.Text = player.CurrentHitPoints.ToString();
            GoldLabel.Text = player.Gold.ToString();
            ExperienceLabel.Text = player.ExperiencePoints.ToString();
            LevelLabel.Text = player.Level.ToString();

            //로케이션 설정
            
        }
        
    }
}
