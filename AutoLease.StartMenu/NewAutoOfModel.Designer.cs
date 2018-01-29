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
            this.components = new System.ComponentModel.Container();
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
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.RobTrRadioButton = new System.Windows.Forms.RadioButton();
            this.VarTrRadioButton = new System.Windows.Forms.RadioButton();
            this.AutTrRadioButton = new System.Windows.Forms.RadioButton();
            this.MechTrRadioButton = new System.Windows.Forms.RadioButton();
            this.TransmissiomLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.TransmissionErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransmissionErrorProvider)).BeginInit();
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
            this.ProductYearMaskedTextBox.TabIndex = 0;
            this.ProductYearMaskedTextBox.TextChanged += new System.EventHandler(this.ProductYearMaskedTextBox_TextChanged);
            this.ProductYearMaskedTextBox.Leave += new System.EventHandler(this.ProductYearMaskedTextBox_Leave);
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
            this.ColorLabel.Location = new System.Drawing.Point(29, 79);
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
            this.MileAgeLabel.Location = new System.Drawing.Point(29, 138);
            this.MileAgeLabel.Name = "MileAgeLabel";
            this.MileAgeLabel.Size = new System.Drawing.Size(99, 20);
            this.MileAgeLabel.TabIndex = 28;
            this.MileAgeLabel.Text = "Пробег (км)";
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ColorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorTextBox.Location = new System.Drawing.Point(19, 102);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(151, 22);
            this.ColorTextBox.TabIndex = 1;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            this.ColorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ColorTextBox_KeyPress);
            // 
            // MileAgeTextBox
            // 
            this.MileAgeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MileAgeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MileAgeTextBox.Location = new System.Drawing.Point(19, 161);
            this.MileAgeTextBox.Name = "MileAgeTextBox";
            this.MileAgeTextBox.Size = new System.Drawing.Size(151, 22);
            this.MileAgeTextBox.TabIndex = 2;
            this.MileAgeTextBox.TextChanged += new System.EventHandler(this.MileAgeTextBox_TextChanged);
            this.MileAgeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MileAgeTextBox_KeyPress);
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
            this.ReadyButton.Location = new System.Drawing.Point(272, 422);
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
            // ErrorProvider
            // 
            this.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProvider.ContainerControl = this;
            // 
            // RobTrRadioButton
            // 
            this.RobTrRadioButton.AutoSize = true;
            this.RobTrRadioButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RobTrRadioButton.Location = new System.Drawing.Point(140, 241);
            this.RobTrRadioButton.Name = "RobTrRadioButton";
            this.RobTrRadioButton.Size = new System.Drawing.Size(140, 21);
            this.RobTrRadioButton.TabIndex = 45;
            this.RobTrRadioButton.TabStop = true;
            this.RobTrRadioButton.Text = "роботизированная";
            this.RobTrRadioButton.UseVisualStyleBackColor = true;
            this.RobTrRadioButton.CheckedChanged += new System.EventHandler(this.RobTrRadioButton_CheckedChanged);
            // 
            // VarTrRadioButton
            // 
            this.VarTrRadioButton.AutoSize = true;
            this.VarTrRadioButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VarTrRadioButton.Location = new System.Drawing.Point(19, 241);
            this.VarTrRadioButton.Name = "VarTrRadioButton";
            this.VarTrRadioButton.Size = new System.Drawing.Size(102, 21);
            this.VarTrRadioButton.TabIndex = 44;
            this.VarTrRadioButton.TabStop = true;
            this.VarTrRadioButton.Text = "вариативная";
            this.VarTrRadioButton.UseVisualStyleBackColor = true;
            this.VarTrRadioButton.CheckedChanged += new System.EventHandler(this.VarTrRadioButton_CheckedChanged);
            // 
            // AutTrRadioButton
            // 
            this.AutTrRadioButton.AutoSize = true;
            this.AutTrRadioButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutTrRadioButton.Location = new System.Drawing.Point(140, 220);
            this.AutTrRadioButton.Name = "AutTrRadioButton";
            this.AutTrRadioButton.Size = new System.Drawing.Size(126, 21);
            this.AutTrRadioButton.TabIndex = 43;
            this.AutTrRadioButton.TabStop = true;
            this.AutTrRadioButton.Text = "автоматическая";
            this.AutTrRadioButton.UseVisualStyleBackColor = true;
            this.AutTrRadioButton.CheckedChanged += new System.EventHandler(this.AutTrRadioButton_CheckedChanged);
            // 
            // MechTrRadioButton
            // 
            this.MechTrRadioButton.AutoSize = true;
            this.MechTrRadioButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MechTrRadioButton.Location = new System.Drawing.Point(19, 220);
            this.MechTrRadioButton.Name = "MechTrRadioButton";
            this.MechTrRadioButton.Size = new System.Drawing.Size(115, 21);
            this.MechTrRadioButton.TabIndex = 42;
            this.MechTrRadioButton.TabStop = true;
            this.MechTrRadioButton.Text = "механическая";
            this.MechTrRadioButton.UseVisualStyleBackColor = true;
            this.MechTrRadioButton.CheckedChanged += new System.EventHandler(this.MechTrRadioButton_CheckedChanged);
            // 
            // TransmissiomLabel
            // 
            this.TransmissiomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransmissiomLabel.AutoSize = true;
            this.TransmissiomLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransmissiomLabel.Location = new System.Drawing.Point(29, 197);
            this.TransmissiomLabel.Name = "TransmissiomLabel";
            this.TransmissiomLabel.Size = new System.Drawing.Size(145, 20);
            this.TransmissiomLabel.TabIndex = 41;
            this.TransmissiomLabel.Text = "Коробка передач";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionLabel.Location = new System.Drawing.Point(29, 275);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(88, 20);
            this.DescriptionLabel.TabIndex = 47;
            this.DescriptionLabel.Text = "Описание";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(19, 298);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionTextBox.Size = new System.Drawing.Size(257, 108);
            this.DescriptionTextBox.TabIndex = 46;
            this.DescriptionTextBox.TextChanged += new System.EventHandler(this.DescriptionTextBox_TextChanged);
            // 
            // TransmissionErrorProvider
            // 
            this.TransmissionErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.TransmissionErrorProvider.ContainerControl = this;
            // 
            // NewAutoOfModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(409, 464);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.RobTrRadioButton);
            this.Controls.Add(this.VarTrRadioButton);
            this.Controls.Add(this.AutTrRadioButton);
            this.Controls.Add(this.MechTrRadioButton);
            this.Controls.Add(this.TransmissiomLabel);
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
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransmissionErrorProvider)).EndInit();
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
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.RadioButton RobTrRadioButton;
        private System.Windows.Forms.RadioButton VarTrRadioButton;
        private System.Windows.Forms.RadioButton AutTrRadioButton;
        private System.Windows.Forms.RadioButton MechTrRadioButton;
        private System.Windows.Forms.Label TransmissiomLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.ErrorProvider TransmissionErrorProvider;
    }
}