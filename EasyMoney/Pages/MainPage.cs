using EasyMoney.CustomControls;
using EasyMoney.Storage;
using EasyMoney.Utilities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EasyMoney
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            ShowAuthPage();

            AuthPage.PlayerAuthed += InitializePlayer;
        }

        private void InitializePlayer(object sender, EventArgs e)
        {
            PlayerGlobalData.Player.PlayerRank.RankUpdated += RankUpdated;
            PlayerGlobalData.Player.PlayerRank.UpdateRank();

            ScoreCounter.Text = PlayerGlobalData.Player.Score.ToString();
            ScoreCounter.Location = new Point(this.Width / 2 - ScoreCounter.Width / 2, ScoreCounter.Location.Y);
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            PlayerGlobalData.Player.AddScore(0.0001m);
            ScoreCounter.Text = PlayerGlobalData.Player.Score.ToString();

            PlayerGlobalData.Player.PlayerRank.AddExperience(4);
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            PlayerSaver.Save();
        }

        private void RankUpdated(object sender, EventArgs e)
        {
            RankButton.Image = PlayerGlobalData.Player.PlayerRank.GetRankImage();
        }
    }
}
