using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyMoney.CustomControls
{
    partial class MyPlayerCard
    {
        private void InitializeComponent()
        {
            this.PlayerName = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayerName
            // 
            this.PlayerName.Dock = DockStyle.Left;
            this.PlayerName.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.PlayerName.ForeColor = System.Drawing.Color.White;
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Width = 200;
            this.PlayerName.TabIndex = 0;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Dock = DockStyle.Right;
            this.DeleteButton.BackColor = System.Drawing.Color.MediumPurple;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // MyPlayerCard
            // 
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.Controls.Add(this.PlayerName);
            this.Controls.Add(this.DeleteButton);
            this.Size = new System.Drawing.Size(310, 50);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label PlayerName;
        private Button DeleteButton;
    }
}
