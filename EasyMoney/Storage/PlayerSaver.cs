using EasyMoney.Entities;
using EasyMoney.Utilities;
using System;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace EasyMoney.Storage
{
    public static class PlayerSaver
    {
        public static void Save()
        {
            if (PlayerGlobalData.Player == null)
                return;

            try
            {
                File.WriteAllText(Path.Combine(PathConstants.SaveFolder, PlayerGlobalData.Player.PlayerName + PathConstants.Extension),
                    JsonConvert.SerializeObject(PlayerGlobalData.Player, Formatting.Indented));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
