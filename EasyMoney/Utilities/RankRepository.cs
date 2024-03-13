using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMoney.Properties;
using EasyMoney.Entities;

namespace EasyMoney.Utilities
{
    public static class RankRepository
    {
        public static List<Rank> Ranks = new List<Rank>
        {
            new Rank { Id = 0, Name = "F", RequiredExperience = 0, RankImage = Resources.RankF },
            new Rank { Id = 1, Name = "E", RequiredExperience = 10, RankImage = Resources.RankE },
            new Rank { Id = 2, Name = "D", RequiredExperience = 20, RankImage = Resources.RankD },
            new Rank { Id = 3, Name = "C", RequiredExperience = 30, RankImage = Resources.RankC },
            new Rank { Id = 4, Name = "B", RequiredExperience = 40, RankImage = Resources.RankB },
            new Rank { Id = 5, Name = "A", RequiredExperience = 50, RankImage = Resources.RankA },
            new Rank { Id = 6, Name = "S", RequiredExperience = 60, RankImage = Resources.RankS },
            new Rank { Id = 7, Name = "L", RequiredExperience = 70, RankImage = Resources.RankL }
        };

        public static Rank GetRank(decimal experience)
        {
            return Ranks.OrderByDescending(r => r.RequiredExperience)
                        .FirstOrDefault(r => r.RequiredExperience <= experience);
        }

        public static decimal GetRequiredExperienceToRankUp(int currentId)
        {
            if (currentId >= Ranks.Count - 1)
                return -1;

            return Ranks
                .Where(rank => rank.Id > currentId)
                .Select(rank => rank.RequiredExperience)
                .FirstOrDefault();
        }
    }
}
