namespace AutoLease.StartMenu
{
    partial class CheckClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.OKbutton = new System.Windows.Forms.Button();
            this.FathernameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SurnameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.NameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.NameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SurnameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.FathernameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.NameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SurnameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.FathernameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.FathernameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PassportLabel = new System.Windows.Forms.Label();
            this.PassportMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SurnameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FathernameErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // OKbutton
            // 
            this.OKbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKbutton.BackColor = System.Drawing.Color.DarkRed;
            this.OKbutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OKbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKbutton.Location = new System.Drawing.Point(245, 206);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(70, 25);
            this.OKbutton.TabIndex = 4;
            this.OKbutton.Text = "ок";
            this.OKbutton.UseVisualStyleBackColor = false;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // FathernameTextBox
            // 
            this.FathernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FathernameTextBox.AsciiOnly = true;
            this.FathernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FathernameTextBox.Location = new System.Drawing.Point(32, 154);
            this.FathernameTextBox.Name = "FathernameTextBox";
            this.FathernameTextBox.Size = new System.Drawing.Size(207, 24);
            this.FathernameTextBox.TabIndex = 2;
            this.FathernameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FathernameTextBox_KeyPress);
            this.FathernameTextBox.Leave += new System.EventHandler(this.FathernameTextBox_Leave);
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SurnameTextBox.AsciiOnly = true;
            this.SurnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameTextBox.Location = new System.Drawing.Point(32, 49);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(207, 24);
            this.SurnameTextBox.TabIndex = 0;
            this.SurnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurnameTextBox_KeyPress);
            this.SurnameTextBox.Leave += new System.EventHandler(this.SurnameTextBox_Leave);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameTextBox.AsciiOnly = true;
            this.NameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NameTextBox.BeepOnError = true;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(32, 99);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(207, 24);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
            this.NameTextBox.Leave += new System.EventHandler(this.NameTextBox_Leave);
            // 
            // NameErrorProvider
            // 
            this.NameErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.NameErrorProvider.ContainerControl = this;
            // 
            // SurnameErrorProvider
            // 
            this.SurnameErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.SurnameErrorProvider.ContainerControl = this;
            // 
            // FathernameErrorProvider
            // 
            this.FathernameErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.FathernameErrorProvider.ContainerControl = this;
            // 
            // NameToolTip
            // 
            this.NameToolTip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.NameToolTip.IsBalloon = true;
            // 
            // SurnameToolTip
            // 
            this.SurnameToolTip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SurnameToolTip.IsBalloon = true;
            // 
            // FathernameToolTip
            // 
            this.FathernameToolTip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FathernameToolTip.IsBalloon = true;
            // 
            // FathernameLabel
            // 
            this.FathernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FathernameLabel.AutoSize = true;
            this.FathernameLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.FathernameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FathernameLabel.Location = new System.Drawing.Point(46, 131);
            this.FathernameLabel.Name = "FathernameLabel";
            this.FathernameLabel.Size = new System.Drawing.Size(78, 20);
            this.FathernameLabel.TabIndex = 11;
            this.FathernameLabel.Text = "Отчество";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.SurnameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SurnameLabel.Location = new System.Drawing.Point(46, 26);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(78, 20);
            this.SurnameLabel.TabIndex = 10;
            this.SurnameLabel.Text = "Фамилия";
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.NameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NameLabel.Location = new System.Drawing.Point(46, 76);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(40, 20);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "Имя";
            // 
            // PassportLabel
            // 
            this.PassportLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PassportLabel.AutoSize = true;
            this.PassportLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.PassportLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PassportLabel.Location = new System.Drawing.Point(46, 183);
            this.PassportLabel.Name = "PassportLabel";
            this.PassportLabel.Size = new System.Drawing.Size(74, 20);
            this.PassportLabel.TabIndex = 25;
            this.PassportLabel.Text = "Паспорт";
            // 
            // PassportMaskedTextBox
            // 
            this.PassportMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.PassportMaskedTextBox.Location = new System.Drawing.Point(32, 206);
            this.PassportMaskedTextBox.Mask = ">LL0000000";
            this.PassportMaskedTextBox.Name = "PassportMaskedTextBox";
            this.PassportMaskedTextBox.Size = new System.Drawing.Size(92, 22);
            this.PassportMaskedTextBox.TabIndex = 3;
            this.PassportMaskedTextBox.TextChanged += new System.EventHandler(this.PassportMaskedTextBox_TextChanged);
            // 
            // CheckClient
            // 
            this.AcceptButton = this.OKbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(327, 243);
            this.Controls.Add(this.PassportLabel);
            this.Controls.Add(this.PassportMaskedTextBox);
            this.Controls.Add(this.FathernameLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.FathernameTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.OKbutton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckClient";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CheckClient_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.NameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SurnameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FathernameErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.MaskedTextBox FathernameTextBox;
        private System.Windows.Forms.MaskedTextBox SurnameTextBox;
        private System.Windows.Forms.MaskedTextBox NameTextBox;
        private System.Windows.Forms.ErrorProvider NameErrorProvider;
        private System.Windows.Forms.ErrorProvider SurnameErrorProvider;
        private System.Windows.Forms.ErrorProvider FathernameErrorProvider;
        private System.Windows.Forms.ToolTip NameToolTip;
        private System.Windows.Forms.ToolTip SurnameToolTip;
        private System.Windows.Forms.ToolTip FathernameToolTip;
        private System.Windows.Forms.Label FathernameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PassportLabel;
        private System.Windows.Forms.MaskedTextBox PassportMaskedTextBox;
    }
}