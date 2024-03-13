namespace EasyMoney.Pages
{
    partial class AuthPage
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.NewPlayerName = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.SavesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.StartMessage = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.StartMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewPlayerName
            // 
            this.NewPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewPlayerName.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.NewPlayerName.Location = new System.Drawing.Point(835, 235);
            this.NewPlayerName.Name = "NewPlayerName";
            this.NewPlayerName.Size = new System.Drawing.Size(395, 50);
            this.NewPlayerName.TabIndex = 0;
            this.NewPlayerName.TabStop = false;
            this.NewPlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.Color.MediumPurple;
            this.CreateButton.FlatAppearance.BorderSize = 0;
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateButton.ForeColor = System.Drawing.Color.White;
            this.CreateButton.Location = new System.Drawing.Point(938, 304);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(189, 59);
            this.CreateButton.TabIndex = 1;
            this.CreateButton.TabStop = false;
            this.CreateButton.Text = "Создать";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // SavesPanel
            // 
            this.SavesPanel.AutoScroll = true;
            this.SavesPanel.BackColor = System.Drawing.Color.White;
            this.SavesPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SavesPanel.Location = new System.Drawing.Point(173, 193);
            this.SavesPanel.Name = "SavesPanel";
            this.SavesPanel.Size = new System.Drawing.Size(500, 426);
            this.SavesPanel.TabIndex = 2;
            this.SavesPanel.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(281, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 65);
            this.label1.TabIndex = 3;
            this.label1.Text = "Войти как";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Location = new System.Drawing.Point(169, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 426);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(948, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 65);
            this.label2.TabIndex = 5;
            this.label2.Text = "Новый";
            // 
            // StartMessage
            // 
            this.StartMessage.Controls.Add(this.richTextBox1);
            this.StartMessage.Location = new System.Drawing.Point(104, 107);
            this.StartMessage.Name = "StartMessage";
            this.StartMessage.Size = new System.Drawing.Size(636, 673);
            this.StartMessage.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(28, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(583, 616);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "Ну ты и соня!\n\nТебя даже вчерашний шторм не разбудил.\n\nГоворят, мы уже приплыли в" +
    " Морровинд.\n\nИмя своё помнишь?";
            // 
            // AuthPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.StartMessage);
            this.Controls.Add(this.SavesPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.NewPlayerName);
            this.Name = "AuthPage";
            this.Size = new System.Drawing.Size(1428, 864);
            this.StartMessage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewPlayerName;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.FlowLayoutPanel SavesPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel StartMessage;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
