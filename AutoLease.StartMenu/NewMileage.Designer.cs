namespace AutoLease.StartMenu
{
    partial class NewMileage
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
            this.OKButton = new System.Windows.Forms.Button();
            this.MileageLabel = new System.Windows.Forms.Label();
            this.MileageTextBox = new System.Windows.Forms.TextBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OKButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OKButton.FlatAppearance.BorderSize = 2;
            this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKButton.Location = new System.Drawing.Point(220, 96);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(130, 33);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "Подтвердить";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // MileageLabel
            // 
            this.MileageLabel.AutoSize = true;
            this.MileageLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MileageLabel.Location = new System.Drawing.Point(12, 22);
            this.MileageLabel.Name = "MileageLabel";
            this.MileageLabel.Size = new System.Drawing.Size(240, 21);
            this.MileageLabel.TabIndex = 3;
            this.MileageLabel.Text = "Пробег после апренды (км):";
            // 
            // MileageTextBox
            // 
            this.MileageTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MileageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MileageTextBox.Location = new System.Drawing.Point(119, 55);
            this.MileageTextBox.Name = "MileageTextBox";
            this.MileageTextBox.Size = new System.Drawing.Size(133, 24);
            this.MileageTextBox.TabIndex = 5;
            this.MileageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MileageTextBox_KeyPress);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProvider.ContainerControl = this;
            // 
            // NewMileage
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(362, 141);
            this.Controls.Add(this.MileageTextBox);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.MileageLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewMileage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label MileageLabel;
        private System.Windows.Forms.TextBox MileageTextBox;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}