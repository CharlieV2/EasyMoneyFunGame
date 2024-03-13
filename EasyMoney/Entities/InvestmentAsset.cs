using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMoney.Entities
{
    public class InvestmentAsset
    {
        public string Name { get; set; }
        public int MinimalRank { get; set; }
        public decimal PurchaseCost { get; set; }
        public decimal RepairCost { get; set; }
        public decimal ProfitPerSecond { get; set; }
        public int Durability { get; set; }


        public event EventHandler InvestmentAssetBroke;

        protected virtual void OnInvestmentAssetBroke(EventArgs e)
        {
            InvestmentAssetBroke?.Invoke(this, e);
        }

        public InvestmentAsset() { }

        public void DecreaseDurabilty()
        {
            if (Durability == 0)
                return;

            Durability--;
            if (Durability == 0)
                OnInvestmentAssetBroke(EventArgs.Empty);
        }
    }
}
