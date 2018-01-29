namespace AutoLease.StartMenu
{
    partial class StartMenu
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
            this.ReturnButton = new System.Windows.Forms.Button();
            this.LeaseButton = new System.Windows.Forms.Button();
            this.ClientRegistrButton = new System.Windows.Forms.Button();
            this.AutoRegistrButton = new System.Windows.Forms.Button();
            this.CategoryRegistrButton = new System.Windows.Forms.Button();
            this.ClientListButton = new System.Windows.Forms.Button();
            this.AutoListButton = new System.Windows.Forms.Button();
            this.StatusToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ClientsToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.AutoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.DateToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.StatusToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReturnButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ReturnButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ReturnButton.FlatAppearance.BorderSize = 2;
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnButton.ForeColor = System.Drawing.Color.Black;
            this.ReturnButton.Location = new System.Drawing.Point(13, 18);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(140, 55);
            this.ReturnButton.TabIndex = 4;
            this.ReturnButton.Text = "Оформить возрат";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // LeaseButton
            // 
            this.LeaseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LeaseButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LeaseButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LeaseButton.FlatAppearance.BorderSize = 2;
            this.LeaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeaseButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeaseButton.Location = new System.Drawing.Point(13, 79);
            this.LeaseButton.Name = "LeaseButton";
            this.LeaseButton.Size = new System.Drawing.Size(140, 55);
            this.LeaseButton.TabIndex = 5;
            this.LeaseButton.Text = "Оформить выдачу";
            this.LeaseButton.UseVisualStyleBackColor = false;
            this.LeaseButton.Click += new System.EventHandler(this.LeaseButton_Click);
            // 
            // ClientRegistrButton
            // 
            this.ClientRegistrButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClientRegistrButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientRegistrButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientRegistrButton.FlatAppearance.BorderSize = 2;
            this.ClientRegistrButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientRegistrButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientRegistrButton.Location = new System.Drawing.Point(159, 18);
            this.ClientRegistrButton.Name = "ClientRegistrButton";
            this.ClientRegistrButton.Size = new System.Drawing.Size(163, 55);
            this.ClientRegistrButton.TabIndex = 6;
            this.ClientRegistrButton.Text = "Зарегистрировать клиента";
            this.ClientRegistrButton.UseVisualStyleBackColor = false;
            this.ClientRegistrButton.Click += new System.EventHandler(this.ClientRegistrButton_Click);
            // 
            // AutoRegistrButton
            // 
            this.AutoRegistrButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AutoRegistrButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AutoRegistrButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AutoRegistrButton.FlatAppearance.BorderSize = 2;
            this.AutoRegistrButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoRegistrButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutoRegistrButton.Location = new System.Drawing.Point(159, 79);
            this.AutoRegistrButton.Name = "AutoRegistrButton";
            this.AutoRegistrButton.Size = new System.Drawing.Size(163, 55);
            this.AutoRegistrButton.TabIndex = 7;
            this.AutoRegistrButton.Text = "Зарегистрировать автомобиль";
            this.AutoRegistrButton.UseVisualStyleBackColor = false;
            this.AutoRegistrButton.Click += new System.EventHandler(this.AutoRegistrButton_Click);
            // 
            // CategoryRegistrButton
            // 
            this.CategoryRegistrButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CategoryRegistrButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CategoryRegistrButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CategoryRegistrButton.FlatAppearance.BorderSize = 2;
            this.CategoryRegistrButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryRegistrButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryRegistrButton.Location = new System.Drawing.Point(159, 140);
            this.CategoryRegistrButton.Name = "CategoryRegistrButton";
            this.CategoryRegistrButton.Size = new System.Drawing.Size(163, 55);
            this.CategoryRegistrButton.TabIndex = 8;
            this.CategoryRegistrButton.Text = "Зарегистрировать категорию";
            this.CategoryRegistrButton.UseVisualStyleBackColor = false;
            this.CategoryRegistrButton.Click += new System.EventHandler(this.CategoryRegistrButton_Click);
            // 
            // ClientListButton
            // 
            this.ClientListButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClientListButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientListButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientListButton.FlatAppearance.BorderSize = 2;
            this.ClientListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientListButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientListButton.Location = new System.Drawing.Point(328, 18);
            this.ClientListButton.Name = "ClientListButton";
            this.ClientListButton.Size = new System.Drawing.Size(145, 55);
            this.ClientListButton.TabIndex = 9;
            this.ClientListButton.Text = "Открыть список клиентов";
            this.ClientListButton.UseVisualStyleBackColor = false;
            this.ClientListButton.Click += new System.EventHandler(this.ClientListButton_Click);
            // 
            // AutoListButton
            // 
            this.AutoListButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AutoListButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AutoListButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AutoListButton.FlatAppearance.BorderSize = 2;
            this.AutoListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoListButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutoListButton.Location = new System.Drawing.Point(327, 79);
            this.AutoListButton.Name = "AutoListButton";
            this.AutoListButton.Size = new System.Drawing.Size(145, 55);
            this.AutoListButton.TabIndex = 10;
            this.AutoListButton.Text = "Открыть список автомобилей";
            this.AutoListButton.UseVisualStyleBackColor = false;
            this.AutoListButton.Click += new System.EventHandler(this.AutoListButton_Click);
            // 
            // StatusToolStrip
            // 
            this.StatusToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatusToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.StatusToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.ClientsToolStripTextBox,
            this.toolStripLabel2,
            this.AutoToolStripTextBox,
            this.DateToolStripTextBox});
            this.StatusToolStrip.Location = new System.Drawing.Point(0, 207);
            this.StatusToolStrip.Name = "StatusToolStrip";
            this.StatusToolStrip.Size = new System.Drawing.Size(484, 25);
            this.StatusToolStrip.TabIndex = 11;
            this.StatusToolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(58, 22);
            this.toolStripLabel1.Text = "Клиенты:";
            // 
            // ClientsToolStripTextBox
            // 
            this.ClientsToolStripTextBox.Enabled = false;
            this.ClientsToolStripTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.ClientsToolStripTextBox.Name = "ClientsToolStripTextBox";
            this.ClientsToolStripTextBox.Size = new System.Drawing.Size(50, 23);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(80, 22);
            this.toolStripLabel2.Text = "Автомобили:";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // AutoToolStripTextBox
            // 
            this.AutoToolStripTextBox.Enabled = false;
            this.AutoToolStripTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.AutoToolStripTextBox.Name = "AutoToolStripTextBox";
            this.AutoToolStripTextBox.Size = new System.Drawing.Size(50, 23);
            // 
            // DateToolStripTextBox
            // 
            this.DateToolStripTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.DateToolStripTextBox.Enabled = false;
            this.DateToolStripTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.DateToolStripTextBox.Name = "DateToolStripTextBox";
            this.DateToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // StartMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(484, 232);
            this.Controls.Add(this.StatusToolStrip);
            this.Controls.Add(this.AutoListButton);
            this.Controls.Add(this.ClientListButton);
            this.Controls.Add(this.CategoryRegistrButton);
            this.Controls.Add(this.AutoRegistrButton);
            this.Controls.Add(this.ClientRegistrButton);
            this.Controls.Add(this.LeaseButton);
            this.Controls.Add(this.ReturnButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автопрокат";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exit);
            this.StatusToolStrip.ResumeLayout(false);
            this.StatusToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button LeaseButton;
        private System.Windows.Forms.Button ClientRegistrButton;
        private System.Windows.Forms.Button AutoRegistrButton;
        private System.Windows.Forms.Button CategoryRegistrButton;
        private System.Windows.Forms.Button ClientListButton;
        private System.Windows.Forms.Button AutoListButton;
        private System.Windows.Forms.ToolStrip StatusToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox ClientsToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox AutoToolStripTextBox;
        private System.Windows.Forms.ToolStripTextBox DateToolStripTextBox;
    }
}

