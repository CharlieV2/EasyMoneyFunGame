using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMoney.Entities
{
    public class PlayerRank
    {

        public event EventHandler RankUpdated;

        protected virtual void OnRankUpdated(EventArgs e)
        {
            RankUpdated?.Invoke(this, e);
        }


        private decimal _experience = 0;

        private Rank _currentRank = null;


        public PlayerRank() { }


        public void AddExperience(decimal amount)
        {
            _experience += amount;
            UpdateRank();
        }

        public decimal GetExperience()
        {
            return _experience;
        }


        public void UpdateRank()
        {
            Rank newRank = RankRepository.GetRank(_experience);

            if (_currentRank != null && newRank.Id == _currentRank.Id)
                return;

            _currentRank = newRank;
            OnRankUpdated(EventArgs.Empty);
        }

        public Image GetRankImage()
        {
            return _currentRank.RankImage;
        }
    }
}
