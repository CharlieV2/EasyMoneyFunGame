using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using EasyMoney.Utilities;
using System.Windows.Forms;

namespace EasyMoney.Storage
{
    public static class PlayerSaveRemover
    {
        public static void Remove(string playerName)
        {
            if (!File.Exists(Path.Combine(PathConstants.SaveFolder, playerName + PathConstants.Extension)))
                return;

            try
            {
                File.Delete(Path.Combine(PathConstants.SaveFolder, playerName + PathConstants.Extension));
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
