using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyMoney.Properties;

namespace EasyMoney.Entities
{
    public class Rank
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal RequiredExperience { get; set; }
        public Image RankImage { get; set; }
    }
}
