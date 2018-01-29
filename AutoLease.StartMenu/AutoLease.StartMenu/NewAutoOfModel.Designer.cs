namespace AutoLease.StartMenu
{
    partial class NewAutoOfModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAutoOfModel));
            this.ProductYearMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ProductYearLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.MileAgeLabel = new System.Windows.Forms.Label();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.MileAgeTextBox = new System.Windows.Forms.TextBox();
            this.OpenPhotoButton = new System.Windows.Forms.Button();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.ReadyButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductYearMaskedTextBox
            // 
            this.ProductYearMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProductYearMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductYearMaskedTextBox.Location = new System.Drawing.Point(20, 45);
            this.ProductYearMaskedTextBox.Mask = "0000 г\\.";
            this.ProductYearMaskedTextBox.Name = "ProductYearMaskedTextBox";
            this.ProductYearMaskedTextBox.Size = new System.Drawing.Size(151, 22);
            this.ProductYearMaskedTextBox.TabIndex = 26;
            this.ProductYearMaskedTextBox.TextChanged += new System.EventHandler(this.ProductYearMaskedTextBox_TextChanged);
            // 
            // ProductYearLabel
            // 
            this.ProductYearLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProductYearLabel.AutoSize = true;
            this.ProductYearLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductYearLabel.Location = new System.Drawing.Point(29, 22);
            this.ProductYearLabel.Name = "ProductYearLabel";
            this.ProductYearLabel.Size = new System.Drawing.Size(101, 20);
            this.ProductYearLabel.TabIndex = 25;
            this.ProductYearLabel.Text = "Год выпуска";
            // 
            // ColorLabel
            // 
            this.ColorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorLabel.Location = new System.Drawing.Point(29, 85);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(43, 20);
            this.ColorLabel.TabIndex = 27;
            this.ColorLabel.Text = "Цвет";
            // 
            // MileAgeLabel
            // 
            this.MileAgeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MileAgeLabel.AutoSize = true;
            this.MileAgeLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MileAgeLabel.Location = new System.Drawing.Point(29, 143);
            this.MileAgeLabel.Name = "MileAgeLabel";
            this.MileAgeLabel.Size = new System.Drawing.Size(64, 20);
            this.MileAgeLabel.TabIndex = 28;
            this.MileAgeLabel.Text = "Пробег";
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ColorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorTextBox.Location = new System.Drawing.Point(20, 108);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(151, 22);
            this.ColorTextBox.TabIndex = 29;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // MileAgeTextBox
            // 
            this.MileAgeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MileAgeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MileAgeTextBox.Location = new System.Drawing.Point(20, 166);
            this.MileAgeTextBox.Name = "MileAgeTextBox";
            this.MileAgeTextBox.Size = new System.Drawing.Size(151, 22);
            this.MileAgeTextBox.TabIndex = 30;
            this.MileAgeTextBox.TextChanged += new System.EventHandler(this.MileAgeTextBox_TextChanged);
            // 
            // OpenPhotoButton
            // 
            this.OpenPhotoButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OpenPhotoButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OpenPhotoButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OpenPhotoButton.FlatAppearance.BorderSize = 2;
            this.OpenPhotoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenPhotoButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenPhotoButton.Location = new System.Drawing.Point(260, 170);
            this.OpenPhotoButton.Name = "OpenPhotoButton";
            this.OpenPhotoButton.Size = new System.Drawing.Size(125, 30);
            this.OpenPhotoButton.TabIndex = 32;
            this.OpenPhotoButton.Text = "Загрузить";
            this.OpenPhotoButton.UseVisualStyleBackColor = false;
            this.OpenPhotoButton.Click += new System.EventHandler(this.OpenPhotoButton_Click);
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PhotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhotoPictureBox.Location = new System.Drawing.Point(201, 22);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(184, 142);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoPictureBox.TabIndex = 31;
            this.PhotoPictureBox.TabStop = false;
            this.PhotoPictureBox.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.PhotoPictureBox_LoadCompleted);
            // 
            // ReadyButton
            // 
            this.ReadyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadyButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ReadyButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ReadyButton.FlatAppearance.BorderSize = 2;
            this.ReadyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadyButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadyButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ReadyButton.Location = new System.Drawing.Point(260, 223);
            this.ReadyButton.Name = "ReadyButton";
            this.ReadyButton.Size = new System.Drawing.Size(125, 30);
            this.ReadyButton.TabIndex = 33;
            this.ReadyButton.Text = "Готово";
            this.ReadyButton.UseVisualStyleBackColor = false;
            this.ReadyButton.Click += new System.EventHandler(this.ReadyButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // NewAutoOfModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(409, 266);
            this.Controls.Add(this.ReadyButton);
            this.Controls.Add(this.OpenPhotoButton);
            this.Controls.Add(this.PhotoPictureBox);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.MileAgeLabel);
            this.Controls.Add(this.ColorTextBox);
            this.Controls.Add(this.MileAgeTextBox);
            this.Controls.Add(this.ProductYearMaskedTextBox);
            this.Controls.Add(this.ProductYearLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "NewAutoOfModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый автомобиль";
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox ProductYearMaskedTextBox;
        private System.Windows.Forms.Label ProductYearLabel;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label MileAgeLabel;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.TextBox MileAgeTextBox;
        private System.Windows.Forms.Button OpenPhotoButton;
        private System.Windows.Forms.PictureBox PhotoPictureBox;
        private System.Windows.Forms.Button ReadyButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}