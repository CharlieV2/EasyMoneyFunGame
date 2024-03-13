using EasyMoney.Utilities;
using System;
using System.Drawing;

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

        private Rank _currentRank;


        public decimal Experience
        { 
            get { return _experience; }
            set
            {
                if (value >= 0)
                {
                    _experience = value;
                }
            }
        }


        public PlayerRank() { }


        public void AddExperience(decimal amount)
        {
            _experience += amount;
            UpdateRank();
        }

        public void UpdateRank()
        {
            Rank newRank = RankRepository.GetRank(_experience);

            if (_currentRank != null && newRank.Id == _currentRank.Id)
                return;

            _currentRank = newRank;
            OnRankUpdated(EventArgs.Empty);
        }

        public string GetRankName()
        {
            return _currentRank.Name;
        }

        public int GetRankId()
        {
            return _currentRank.Id;
        }

        public Image GetRankImage()
        {
            return _currentRank.RankImage;
        }
    }
}
