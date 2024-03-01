using EasyMoney.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyMoney
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            player1.PlayerRank.RankUpdated += this.RankUpdated;
        }

        Player player1 = new Player();

        private void RankUpdated(object sender, EventArgs e)
        {
            RankButton.Image = player1.PlayerRank.GetRankImage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player1.PlayerRank.AddExperience(4);
            ScoreCounter.Text = player1.PlayerRank.GetExperience().ToString();
        }
    }
}
