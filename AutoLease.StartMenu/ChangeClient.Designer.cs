namespace AutoLease.StartMenu
{
    partial class ChangeClient
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
            this.NameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SurnameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.FathernameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.NameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SurnameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.FathernameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.NameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SurnameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.FathernameLabel = new System.Windows.Forms.Label();
            this.FathernameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
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
            this.OKbutton.Location = new System.Drawing.Point(232, 161);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(70, 25);
            this.OKbutton.TabIndex = 3;
            this.OKbutton.Text = "ок";
            this.OKbutton.UseVisualStyleBackColor = false;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
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
            // NameTextBox
            // 
            this.NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameTextBox.AsciiOnly = true;
            this.NameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NameTextBox.BeepOnError = true;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(12, 82);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(207, 24);
            this.NameTextBox.TabIndex = 1;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SurnameTextBox.AsciiOnly = true;
            this.SurnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameTextBox.Location = new System.Drawing.Point(12, 32);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(207, 24);
            this.SurnameTextBox.TabIndex = 0;
            // 
            // FathernameLabel
            // 
            this.FathernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FathernameLabel.AutoSize = true;
            this.FathernameLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.FathernameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FathernameLabel.Location = new System.Drawing.Point(30, 109);
            this.FathernameLabel.Name = "FathernameLabel";
            this.FathernameLabel.Size = new System.Drawing.Size(78, 20);
            this.FathernameLabel.TabIndex = 17;
            this.FathernameLabel.Text = "Отчество";
            // 
            // FathernameTextBox
            // 
            this.FathernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FathernameTextBox.AsciiOnly = true;
            this.FathernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FathernameTextBox.Location = new System.Drawing.Point(12, 132);
            this.FathernameTextBox.Name = "FathernameTextBox";
            this.FathernameTextBox.Size = new System.Drawing.Size(207, 24);
            this.FathernameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(30, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Имя";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.SurnameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SurnameLabel.Location = new System.Drawing.Point(30, 9);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(78, 20);
            this.SurnameLabel.TabIndex = 16;
            this.SurnameLabel.Text = "Фамилия";
            // 
            // ChangeClient
            // 
            this.AcceptButton = this.OKbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(314, 198);
            this.Controls.Add(this.FathernameLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FathernameTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.OKbutton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeClient";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.NameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SurnameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FathernameErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.ErrorProvider NameErrorProvider;
        private System.Windows.Forms.ErrorProvider SurnameErrorProvider;
        private System.Windows.Forms.ErrorProvider FathernameErrorProvider;
        private System.Windows.Forms.ToolTip NameToolTip;
        private System.Windows.Forms.ToolTip SurnameToolTip;
        private System.Windows.Forms.ToolTip FathernameToolTip;
        private System.Windows.Forms.Label FathernameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox FathernameTextBox;
        private System.Windows.Forms.MaskedTextBox SurnameTextBox;
        private System.Windows.Forms.MaskedTextBox NameTextBox;
    }
}