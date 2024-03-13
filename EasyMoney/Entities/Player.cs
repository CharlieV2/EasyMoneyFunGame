using System.Collections.Generic;

namespace EasyMoney.Entities
{
    public class Player
    {
        public string PlayerName { get; set; }
        public decimal Score { get; set; }
        public PlayerRank PlayerRank { get; set; } = new PlayerRank();
        public List<InvestmentAsset> Investments { get; set; } = new List<InvestmentAsset>();


        public Player() { }
        public Player(string name)
        {
            PlayerName = name;
        }

        public void AddScore(decimal amount)
        {
            Score += amount;
        }
    }
}