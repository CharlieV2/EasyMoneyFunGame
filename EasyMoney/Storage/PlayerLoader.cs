using EasyMoney.Entities;
using EasyMoney.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EasyMoney.Storage
{
    public static class PlayerLoader
    {
        public static void Load(string playerName)
        {
            if (!File.Exists(Path.Combine(PathConstants.SaveFolder, playerName + PathConstants.Extension)))
                return;

            try
            {
                PlayerGlobalData.Player = JsonConvert.DeserializeObject<Player>(File.ReadAllText(Path.Combine(PathConstants.SaveFolder, playerName + PathConstants.Extension)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static List<string> GetSaveNamesList()
        {
            List<string> saves = new List<string>();

            if (Directory.Exists(PathConstants.SaveFolder))
            {
                saves = Directory.GetFiles(PathConstants.SaveFolder)
                    .Select(filePath => Path.GetFileNameWithoutExtension(filePath))
                    .ToList();
            }

            return saves;
        }
    }
}
