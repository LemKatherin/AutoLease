namespace AutoLease.StartMenu
{
    partial class ModelProductToAdd
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
            this.OKbutton = new System.Windows.Forms.Button();
            this.ModelProductTextBox = new System.Windows.Forms.TextBox();
            this.ModelProductLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKbutton
            // 
            this.OKbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKbutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OKbutton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OKbutton.Location = new System.Drawing.Point(142, 68);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(100, 25);
            this.OKbutton.TabIndex = 5;
            this.OKbutton.Text = "добавить";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // ModelProductTextBox
            // 
            this.ModelProductTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ModelProductTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelProductTextBox.Location = new System.Drawing.Point(67, 38);
            this.ModelProductTextBox.Name = "ModelProductTextBox";
            this.ModelProductTextBox.Size = new System.Drawing.Size(124, 24);
            this.ModelProductTextBox.TabIndex = 4;
            this.ModelProductTextBox.TextChanged += new System.EventHandler(this.ModelProductTextBox_TextChanged);
            this.ModelProductTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModelProductTextBox_KeyPress);
            // 
            // ModelProductLabel
            // 
            this.ModelProductLabel.AutoSize = true;
            this.ModelProductLabel.BackColor = System.Drawing.Color.White;
            this.ModelProductLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelProductLabel.ForeColor = System.Drawing.Color.Black;
            this.ModelProductLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ModelProductLabel.Location = new System.Drawing.Point(13, 10);
            this.ModelProductLabel.Name = "ModelProductLabel";
            this.ModelProductLabel.Size = new System.Drawing.Size(127, 21);
            this.ModelProductLabel.TabIndex = 3;
            this.ModelProductLabel.Text = "Введите марку";
            // 
            // ModelProductToAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(254, 101);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.ModelProductTextBox);
            this.Controls.Add(this.ModelProductLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModelProductToAdd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.TextBox ModelProductTextBox;
        private System.Windows.Forms.Label ModelProductLabel;
    }
}