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
            this.NameLabel = new System.Windows.Forms.Label();
            this.FathernameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SurnameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.NameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.NameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SurnameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.FathernameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.NameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SurnameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.FathernameToolTip = new System.Windows.Forms.ToolTip(this.components);
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
            this.OKbutton.Location = new System.Drawing.Point(277, 154);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(70, 25);
            this.OKbutton.TabIndex = 5;
            this.OKbutton.Text = "ок";
            this.OKbutton.UseVisualStyleBackColor = false;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.Color.Black;
            this.NameLabel.Location = new System.Drawing.Point(12, 15);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(335, 65);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Введите ФИО клиента, которого желаете зарегестрировать:";
            // 
            // FathernameTextBox
            // 
            this.FathernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FathernameTextBox.AsciiOnly = true;
            this.FathernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FathernameTextBox.Location = new System.Drawing.Point(55, 130);
            this.FathernameTextBox.Name = "FathernameTextBox";
            this.FathernameTextBox.Size = new System.Drawing.Size(207, 24);
            this.FathernameTextBox.TabIndex = 8;
            this.FathernameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FathernameTextBox_KeyPress);
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameTextBox.AsciiOnly = true;
            this.SurnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameTextBox.Location = new System.Drawing.Point(55, 98);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(207, 24);
            this.SurnameTextBox.TabIndex = 7;
            this.SurnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurnameTextBox_KeyPress);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.AsciiOnly = true;
            this.NameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NameTextBox.BeepOnError = true;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(55, 66);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(207, 24);
            this.NameTextBox.TabIndex = 6;
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
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
            // CheckClient
            // 
            this.AcceptButton = this.OKbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(359, 191);
            this.Controls.Add(this.FathernameTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.NameLabel);
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
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.MaskedTextBox FathernameTextBox;
        private System.Windows.Forms.MaskedTextBox SurnameTextBox;
        private System.Windows.Forms.MaskedTextBox NameTextBox;
        private System.Windows.Forms.ErrorProvider NameErrorProvider;
        private System.Windows.Forms.ErrorProvider SurnameErrorProvider;
        private System.Windows.Forms.ErrorProvider FathernameErrorProvider;
        private System.Windows.Forms.ToolTip NameToolTip;
        private System.Windows.Forms.ToolTip SurnameToolTip;
        private System.Windows.Forms.ToolTip FathernameToolTip;
    }
}