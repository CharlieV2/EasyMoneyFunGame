using EasyMoney.Pages;
using System.Drawing;
using System;
using System.Windows.Forms;

namespace EasyMoney
{
    partial class MainPage
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ScoreCounter = new System.Windows.Forms.Label();
            this.RankButton = new EasyMoney.CustomControls.MyRankButton();
            this.MainButton = new EasyMoney.CustomControls.MyPictureButton();
            this.AuthPage = new EasyMoney.Pages.AuthPage();
            ((System.ComponentModel.ISupportInitialize)(this.RankButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainButton)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreCounter
            // 
            this.ScoreCounter.AutoSize = true;
            this.ScoreCounter.BackColor = System.Drawing.Color.Transparent;
            this.ScoreCounter.Font = new System.Drawing.Font("VAG World", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreCounter.ForeColor = System.Drawing.Color.White;
            this.ScoreCounter.Location = new System.Drawing.Point(551, 605);
            this.ScoreCounter.Name = "ScoreCounter";
            this.ScoreCounter.Size = new System.Drawing.Size(326, 194);
            this.ScoreCounter.TabIndex = 3;
            this.ScoreCounter.Text = "1000";
            this.ScoreCounter.TextChanged += new System.EventHandler(this.ScoreCounter_TextChanged);
            // 
            // RankButton
            // 
            this.RankButton.BackColor = System.Drawing.Color.Transparent;
            this.RankButton.Image = global::EasyMoney.Properties.Resources.RankF;
            this.RankButton.Location = new System.Drawing.Point(12, 12);
            this.RankButton.Name = "RankButton";
            this.RankButton.Size = new System.Drawing.Size(200, 200);
            this.RankButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RankButton.TabIndex = 2;
            this.RankButton.TabStop = false;
            // 
            // MainButton
            // 
            this.MainButton.BackColor = System.Drawing.Color.Transparent;
            this.MainButton.DefaultImage = global::EasyMoney.Properties.Resources.MainButton_Default;
            this.MainButton.EnterImage = global::EasyMoney.Properties.Resources.MainButton_Active;
            this.MainButton.Image = global::EasyMoney.Properties.Resources.MainButton_Default;
            this.MainButton.Location = new System.Drawing.Point(535, 249);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(358, 353);
            this.MainButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainButton.TabIndex = 1;
            this.MainButton.TabStop = false;
            this.MainButton.Click += new System.EventHandler(this.MainButton_Click);
            // 
            // AuthPage
            // 
            this.AuthPage.BackColor = System.Drawing.Color.White;
            this.AuthPage.Location = new System.Drawing.Point(0, 0);
            this.AuthPage.Name = "AuthPage";
            this.AuthPage.Size = new System.Drawing.Size(1428, 864);
            this.AuthPage.TabIndex = 4;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::EasyMoney.Properties.Resources.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1428, 864);
            this.Controls.Add(this.RankButton);
            this.Controls.Add(this.MainButton);
            this.Controls.Add(this.ScoreCounter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.Text = "Easy Money";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.RankButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ShowAuthPage()
        {
            this.Controls.Add(this.AuthPage);
            AuthPage.BringToFront();
        }



        #endregion
        private CustomControls.MyPictureButton MainButton;
        private CustomControls.MyRankButton RankButton;
        private Label ScoreCounter;
        private AuthPage AuthPage;

        private void ScoreCounter_TextChanged(object sender, EventArgs e)
        {
            ScoreCounter.Location = new Point(this.Width / 2 - ScoreCounter.Width / 2, ScoreCounter.Location.Y);
        }
    }
}

