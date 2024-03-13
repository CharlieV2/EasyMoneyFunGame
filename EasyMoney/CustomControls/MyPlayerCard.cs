using EasyMoney.CustomEventArgs;
using System;
using System.Windows.Forms;

namespace EasyMoney.CustomControls
{
    public partial class MyPlayerCard : Panel
    {
        public event EventHandler<PlayerSelectedEventArgs> PlayerSelected;
        public event EventHandler<PlayerSelectedEventArgs> PlayerDelete;

        protected virtual void OnPlayerSelected(string selectedPlayerName)
        {
            PlayerSelected?.Invoke(this, new PlayerSelectedEventArgs(selectedPlayerName));
        }

        protected virtual void OnPlayerDeleting(string deletePlayerName)
        {
            PlayerDelete?.Invoke(this, new PlayerSelectedEventArgs(deletePlayerName));
        }


        public MyPlayerCard(string playerName)
        {
            InitializeComponent();

            PlayerName.Click += PlayerName_Click;
            DeleteButton.Click += DeleteButton_Click;

            PlayerName.Text = playerName;
        }

        private void PlayerName_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
            OnPlayerSelected(PlayerName.Text);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
            OnPlayerDeleting(PlayerName.Text);

            this.Dispose();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            OnPlayerSelected(PlayerName.Text);
        }
    }
}
