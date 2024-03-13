using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMoney.CustomEventArgs
{
    public class PlayerSelectedEventArgs : EventArgs
    {
        public string SelectedPlayerName { get; }

        public PlayerSelectedEventArgs(string selectedPlayerName) 
        {
            SelectedPlayerName = selectedPlayerName;
        }
    }
}
