using EasyMoney.CustomControls;
using EasyMoney.CustomEventArgs;
using EasyMoney.Storage;
using EasyMoney.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EasyMoney.Pages
{
    public partial class AuthPage : UserControl
    {
        public event EventHandler PlayerAuthed;

        protected virtual void OnPlayerAuthed(object sender, EventArgs e)
        {
            PlayerAuthed?.Invoke(sender, e);
            this.Dispose();
        }
        
        public AuthPage()
        {
            InitializeComponent();
            DisplaySaveNames();
        }

        private void DisplaySaveNames()
        {
            MyPlayerCard myPlayerCard;
            List<string> saveNames = PlayerLoader.GetSaveNamesList();

            SavesPanel.Controls.Clear();

            if (saveNames.Count == 0)
                return;

            StartMessage.Visible = false;

            foreach (string saveName in saveNames)
            {
                myPlayerCard = new MyPlayerCard(saveName);

                myPlayerCard.PlayerSelected += SaveSelected;
                myPlayerCard.PlayerDelete += SaveDelete;

                SavesPanel.Controls.Add(myPlayerCard);
            }
        }

        private void SaveSelected(object sender, PlayerSelectedEventArgs e)
        {
            PlayerLoader.Load(e.SelectedPlayerName);
            OnPlayerAuthed(this, EventArgs.Empty);
        }

        private void SaveDelete(object sender, PlayerSelectedEventArgs e)
        {
            PlayerSaveRemover.Remove(e.SelectedPlayerName);
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            PlayerGlobalData.Player = new Entities.Player(NewPlayerName.Text.Trim());
            OnPlayerAuthed(this, EventArgs.Empty);
        }
    }
}
