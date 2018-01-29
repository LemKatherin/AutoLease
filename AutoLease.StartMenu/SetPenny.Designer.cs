namespace AutoLease.StartMenu
{
    partial class SetPenny
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetPenny));
            this.CraetionDateLlabel = new System.Windows.Forms.Label();
            this.PennyMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.OKbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CraetionDateLlabel
            // 
            this.CraetionDateLlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CraetionDateLlabel.AutoSize = true;
            this.CraetionDateLlabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CraetionDateLlabel.Location = new System.Drawing.Point(12, 20);
            this.CraetionDateLlabel.Name = "CraetionDateLlabel";
            this.CraetionDateLlabel.Size = new System.Drawing.Size(277, 20);
            this.CraetionDateLlabel.TabIndex = 10;
            this.CraetionDateLlabel.Text = "Введите долю задержки на сегодня";
            // 
            // PennyMaskedTextBox
            // 
            this.PennyMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PennyMaskedTextBox.Location = new System.Drawing.Point(132, 55);
            this.PennyMaskedTextBox.Mask = "\\1\\,00";
            this.PennyMaskedTextBox.Name = "PennyMaskedTextBox";
            this.PennyMaskedTextBox.Size = new System.Drawing.Size(57, 22);
            this.PennyMaskedTextBox.TabIndex = 0;
            this.PennyMaskedTextBox.TextChanged += new System.EventHandler(this.PennyMaskedTextBox_TextChanged);
            // 
            // OKbutton
            // 
            this.OKbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKbutton.BackColor = System.Drawing.Color.DarkRed;
            this.OKbutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OKbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKbutton.Location = new System.Drawing.Point(223, 71);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(70, 25);
            this.OKbutton.TabIndex = 1;
            this.OKbutton.Text = "ок";
            this.OKbutton.UseVisualStyleBackColor = false;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // SetPenny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(305, 108);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.PennyMaskedTextBox);
            this.Controls.Add(this.CraetionDateLlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetPenny";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить пеню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CraetionDateLlabel;
        private System.Windows.Forms.MaskedTextBox PennyMaskedTextBox;
        private System.Windows.Forms.Button OKbutton;
    }
}