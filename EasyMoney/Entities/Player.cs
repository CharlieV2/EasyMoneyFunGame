using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMoney.Entities
{
    public class Player
    {
        public string Username { get; set; }
        public PlayerRank PlayerRank { get; set; } = new PlayerRank();
        public decimal Score { get; set; }
    }
}
