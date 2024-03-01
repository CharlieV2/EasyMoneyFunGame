using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyMoney.CustomControls
{
    public class MyPictureButton : PictureBox
    {
        #region SETTINGS
        [Category("Images")]
        [Description("Button image in default state.")]
        public Image DefaultImage { get; set; }

        [Category("Images")]
        [Description("Button image on mouse hover.")]
        public Image EnterImage { get; set; }
        #endregion


        public MyPictureButton()
        {
            SizeMode = PictureBoxSizeMode.StretchImage;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            Image = EnterImage;
            base.OnEnter(e);
        }
        
        protected override void OnMouseLeave(EventArgs e)
        {
            Image = DefaultImage;
            base.OnLeave(e);
        }
    }
}
