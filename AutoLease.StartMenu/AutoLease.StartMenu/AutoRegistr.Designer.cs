namespace AutoLease.StartMenu
{
    partial class AutoRegistr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoRegistr));
            this.NameTextBox2 = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.CountryComboBox = new System.Windows.Forms.ComboBox();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SumLeaseLabel = new System.Windows.Forms.Label();
            this.SumLeaseMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.CountAutoLabel = new System.Windows.Forms.Label();
            this.CountAutoDomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenPhotoButton = new System.Windows.Forms.Button();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.AddCategoryButton = new System.Windows.Forms.Button();
            this.ReadyButton = new System.Windows.Forms.Button();
            this.AddCountryButton = new System.Windows.Forms.Button();
            this.NameTextBox1 = new System.Windows.Forms.TextBox();
            this.FuelInHourTextBox = new System.Windows.Forms.TextBox();
            this.RobTrRadioButton = new System.Windows.Forms.RadioButton();
            this.VarTrRadioButton = new System.Windows.Forms.RadioButton();
            this.AutTrRadioButton = new System.Windows.Forms.RadioButton();
            this.MechTrRadioButton = new System.Windows.Forms.RadioButton();
            this.FuelInHourLabel = new System.Windows.Forms.Label();
            this.FuelTextBox = new System.Windows.Forms.TextBox();
            this.FuelLabel = new System.Windows.Forms.Label();
            this.TransmissiomLabel = new System.Windows.Forms.Label();
            this.TransmissionErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransmissionErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextBox2
            // 
            this.NameTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameTextBox2.Enabled = false;
            this.NameTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox2.Location = new System.Drawing.Point(144, 39);
            this.NameTextBox2.Name = "NameTextBox2";
            this.NameTextBox2.Size = new System.Drawing.Size(91, 22);
            this.NameTextBox2.TabIndex = 0;
            this.NameTextBox2.TextChanged += new System.EventHandler(this.NameTextBox2_TextChanged);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(24, 503);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionTextBox.Size = new System.Drawing.Size(353, 147);
            this.DescriptionTextBox.TabIndex = 5;
            this.DescriptionTextBox.TextChanged += new System.EventHandler(this.DescriptionTextBox_TextChanged);
            // 
            // CountryComboBox
            // 
            this.CountryComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CountryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryComboBox.FormattingEnabled = true;
            this.CountryComboBox.Items.AddRange(new object[] {
            "Россия",
            "Великобритания",
            "США",
            "Италия",
            "Франция",
            "Германия"});
            this.CountryComboBox.Location = new System.Drawing.Point(24, 96);
            this.CountryComboBox.Name = "CountryComboBox";
            this.CountryComboBox.Size = new System.Drawing.Size(211, 24);
            this.CountryComboBox.TabIndex = 8;
            this.CountryComboBox.TextUpdate += new System.EventHandler(this.CountryComboBox_TextUpdate);
            // 
            // CountryLabel
            // 
            this.CountryLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryLabel.Location = new System.Drawing.Point(33, 73);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(132, 20);
            this.CountryLabel.TabIndex = 9;
            this.CountryLabel.Text = "Страна выпуска";
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(33, 12);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(103, 20);
            this.NameLabel.TabIndex = 11;
            this.NameLabel.Text = "Имя модели";
            // 
            // SumLeaseLabel
            // 
            this.SumLeaseLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SumLeaseLabel.AutoSize = true;
            this.SumLeaseLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumLeaseLabel.Location = new System.Drawing.Point(33, 387);
            this.SumLeaseLabel.Name = "SumLeaseLabel";
            this.SumLeaseLabel.Size = new System.Drawing.Size(124, 20);
            this.SumLeaseLabel.TabIndex = 12;
            this.SumLeaseLabel.Text = "Аренда в сутки";
            // 
            // SumLeaseMaskedTextBox
            // 
            this.SumLeaseMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SumLeaseMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumLeaseMaskedTextBox.Location = new System.Drawing.Point(24, 410);
            this.SumLeaseMaskedTextBox.Mask = "00\\, 00 \\$";
            this.SumLeaseMaskedTextBox.Name = "SumLeaseMaskedTextBox";
            this.SumLeaseMaskedTextBox.Size = new System.Drawing.Size(211, 22);
            this.SumLeaseMaskedTextBox.TabIndex = 13;
            this.SumLeaseMaskedTextBox.TextChanged += new System.EventHandler(this.SumLeaseMaskedTextBox_TextChanged);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionLabel.Location = new System.Drawing.Point(30, 480);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(88, 20);
            this.DescriptionLabel.TabIndex = 14;
            this.DescriptionLabel.Text = "Описание";
            // 
            // CountAutoLabel
            // 
            this.CountAutoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CountAutoLabel.AutoSize = true;
            this.CountAutoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountAutoLabel.Location = new System.Drawing.Point(33, 449);
            this.CountAutoLabel.Name = "CountAutoLabel";
            this.CountAutoLabel.Size = new System.Drawing.Size(132, 20);
            this.CountAutoLabel.TabIndex = 15;
            this.CountAutoLabel.Text = "Количество авто";
            this.CountAutoLabel.UseMnemonic = false;
            // 
            // CountAutoDomainUpDown
            // 
            this.CountAutoDomainUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CountAutoDomainUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountAutoDomainUpDown.Items.Add("10");
            this.CountAutoDomainUpDown.Items.Add("9");
            this.CountAutoDomainUpDown.Items.Add("8");
            this.CountAutoDomainUpDown.Items.Add("7");
            this.CountAutoDomainUpDown.Items.Add("6");
            this.CountAutoDomainUpDown.Items.Add("5");
            this.CountAutoDomainUpDown.Items.Add("4");
            this.CountAutoDomainUpDown.Items.Add("3");
            this.CountAutoDomainUpDown.Items.Add("2");
            this.CountAutoDomainUpDown.Items.Add("1");
            this.CountAutoDomainUpDown.Items.Add("0");
            this.CountAutoDomainUpDown.Location = new System.Drawing.Point(176, 449);
            this.CountAutoDomainUpDown.Name = "CountAutoDomainUpDown";
            this.CountAutoDomainUpDown.Size = new System.Drawing.Size(40, 22);
            this.CountAutoDomainUpDown.TabIndex = 16;
            this.CountAutoDomainUpDown.Tag = "";
            this.CountAutoDomainUpDown.Text = "0";
            this.CountAutoDomainUpDown.Wrap = true;
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PhotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhotoPictureBox.Location = new System.Drawing.Point(311, 24);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(269, 229);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoPictureBox.TabIndex = 18;
            this.PhotoPictureBox.TabStop = false;
            this.PhotoPictureBox.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.PhotoPictureBox_LoadCompleted);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // OpenPhotoButton
            // 
            this.OpenPhotoButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OpenPhotoButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OpenPhotoButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OpenPhotoButton.FlatAppearance.BorderSize = 2;
            this.OpenPhotoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenPhotoButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenPhotoButton.Location = new System.Drawing.Point(455, 259);
            this.OpenPhotoButton.Name = "OpenPhotoButton";
            this.OpenPhotoButton.Size = new System.Drawing.Size(125, 30);
            this.OpenPhotoButton.TabIndex = 19;
            this.OpenPhotoButton.Text = "Загрузить";
            this.OpenPhotoButton.UseVisualStyleBackColor = false;
            this.OpenPhotoButton.Click += new System.EventHandler(this.OpenPhotoButton_Click);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabel.Location = new System.Drawing.Point(33, 134);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(85, 20);
            this.CategoryLabel.TabIndex = 20;
            this.CategoryLabel.Text = "Категория";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(24, 157);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(211, 24);
            this.CategoryComboBox.TabIndex = 21;
            this.CategoryComboBox.TextUpdate += new System.EventHandler(this.CategoryComboBox_TextUpdate);
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddCategoryButton.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.AddCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddCategoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCategoryButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.AddCategoryButton.Location = new System.Drawing.Point(241, 155);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(29, 28);
            this.AddCategoryButton.TabIndex = 23;
            this.AddCategoryButton.Text = "+";
            this.AddCategoryButton.UseVisualStyleBackColor = true;
            this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
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
            this.ReadyButton.Location = new System.Drawing.Point(465, 632);
            this.ReadyButton.Name = "ReadyButton";
            this.ReadyButton.Size = new System.Drawing.Size(125, 30);
            this.ReadyButton.TabIndex = 27;
            this.ReadyButton.Text = "Готово";
            this.ReadyButton.UseVisualStyleBackColor = false;
            this.ReadyButton.Click += new System.EventHandler(this.ReadyButton_Click);
            // 
            // AddCountryButton
            // 
            this.AddCountryButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddCountryButton.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.AddCountryButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddCountryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCountryButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.AddCountryButton.Location = new System.Drawing.Point(241, 94);
            this.AddCountryButton.Name = "AddCountryButton";
            this.AddCountryButton.Size = new System.Drawing.Size(29, 28);
            this.AddCountryButton.TabIndex = 29;
            this.AddCountryButton.Text = "+";
            this.AddCountryButton.UseVisualStyleBackColor = true;
            this.AddCountryButton.Click += new System.EventHandler(this.AddCountryButton_Click);
            // 
            // NameTextBox1
            // 
            this.NameTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameTextBox1.Enabled = false;
            this.NameTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox1.Location = new System.Drawing.Point(24, 39);
            this.NameTextBox1.Name = "NameTextBox1";
            this.NameTextBox1.Size = new System.Drawing.Size(114, 22);
            this.NameTextBox1.TabIndex = 32;
            this.NameTextBox1.TextChanged += new System.EventHandler(this.NameTextBox1_TextChanged);
            // 
            // FuelInHourTextBox
            // 
            this.FuelInHourTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FuelInHourTextBox.Location = new System.Drawing.Point(24, 349);
            this.FuelInHourTextBox.Name = "FuelInHourTextBox";
            this.FuelInHourTextBox.Size = new System.Drawing.Size(211, 22);
            this.FuelInHourTextBox.TabIndex = 41;
            this.FuelInHourTextBox.TextChanged += new System.EventHandler(this.FuelInHourTextBox_TextChanged);
            // 
            // RobTrRadioButton
            // 
            this.RobTrRadioButton.AutoSize = true;
            this.RobTrRadioButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RobTrRadioButton.Location = new System.Drawing.Point(144, 238);
            this.RobTrRadioButton.Name = "RobTrRadioButton";
            this.RobTrRadioButton.Size = new System.Drawing.Size(140, 21);
            this.RobTrRadioButton.TabIndex = 40;
            this.RobTrRadioButton.TabStop = true;
            this.RobTrRadioButton.Text = "роботизированная";
            this.RobTrRadioButton.UseVisualStyleBackColor = true;
            this.RobTrRadioButton.CheckedChanged += new System.EventHandler(this.RobTrRadioButton_CheckedChanged);
            // 
            // VarTrRadioButton
            // 
            this.VarTrRadioButton.AutoSize = true;
            this.VarTrRadioButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VarTrRadioButton.Location = new System.Drawing.Point(23, 238);
            this.VarTrRadioButton.Name = "VarTrRadioButton";
            this.VarTrRadioButton.Size = new System.Drawing.Size(102, 21);
            this.VarTrRadioButton.TabIndex = 39;
            this.VarTrRadioButton.TabStop = true;
            this.VarTrRadioButton.Text = "вариативная";
            this.VarTrRadioButton.UseVisualStyleBackColor = true;
            this.VarTrRadioButton.CheckedChanged += new System.EventHandler(this.VarTrRadioButton_CheckedChanged);
            // 
            // AutTrRadioButton
            // 
            this.AutTrRadioButton.AutoSize = true;
            this.AutTrRadioButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutTrRadioButton.Location = new System.Drawing.Point(144, 217);
            this.AutTrRadioButton.Name = "AutTrRadioButton";
            this.AutTrRadioButton.Size = new System.Drawing.Size(126, 21);
            this.AutTrRadioButton.TabIndex = 38;
            this.AutTrRadioButton.TabStop = true;
            this.AutTrRadioButton.Text = "автоматическая";
            this.AutTrRadioButton.UseVisualStyleBackColor = true;
            this.AutTrRadioButton.CheckedChanged += new System.EventHandler(this.AutTrRadioButton_CheckedChanged);
            // 
            // MechTrRadioButton
            // 
            this.MechTrRadioButton.AutoSize = true;
            this.MechTrRadioButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MechTrRadioButton.Location = new System.Drawing.Point(23, 217);
            this.MechTrRadioButton.Name = "MechTrRadioButton";
            this.MechTrRadioButton.Size = new System.Drawing.Size(115, 21);
            this.MechTrRadioButton.TabIndex = 37;
            this.MechTrRadioButton.TabStop = true;
            this.MechTrRadioButton.Text = "механическая";
            this.MechTrRadioButton.UseVisualStyleBackColor = true;
            this.MechTrRadioButton.CheckedChanged += new System.EventHandler(this.MechTrRadioButton_CheckedChanged);
            // 
            // FuelInHourLabel
            // 
            this.FuelInHourLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FuelInHourLabel.Location = new System.Drawing.Point(33, 325);
            this.FuelInHourLabel.Name = "FuelInHourLabel";
            this.FuelInHourLabel.Size = new System.Drawing.Size(183, 27);
            this.FuelInHourLabel.TabIndex = 36;
            this.FuelInHourLabel.Text = "Расход топлива (в час)";
            // 
            // FuelTextBox
            // 
            this.FuelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FuelTextBox.Location = new System.Drawing.Point(24, 293);
            this.FuelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FuelTextBox.Name = "FuelTextBox";
            this.FuelTextBox.Size = new System.Drawing.Size(211, 22);
            this.FuelTextBox.TabIndex = 35;
            this.FuelTextBox.TextChanged += new System.EventHandler(this.FuelTextBox_TextChanged);
            // 
            // FuelLabel
            // 
            this.FuelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FuelLabel.AutoSize = true;
            this.FuelLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FuelLabel.Location = new System.Drawing.Point(33, 271);
            this.FuelLabel.Name = "FuelLabel";
            this.FuelLabel.Size = new System.Drawing.Size(95, 20);
            this.FuelLabel.TabIndex = 34;
            this.FuelLabel.Text = "Тип топлива";
            // 
            // TransmissiomLabel
            // 
            this.TransmissiomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransmissiomLabel.AutoSize = true;
            this.TransmissiomLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransmissiomLabel.Location = new System.Drawing.Point(33, 193);
            this.TransmissiomLabel.Name = "TransmissiomLabel";
            this.TransmissiomLabel.Size = new System.Drawing.Size(145, 20);
            this.TransmissiomLabel.TabIndex = 33;
            this.TransmissiomLabel.Text = "Коробка передач";
            // 
            // TransmissionErrorProvider
            // 
            this.TransmissionErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.TransmissionErrorProvider.ContainerControl = this;
            // 
            // AutoRegistr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(20, 20);
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(602, 674);
            this.Controls.Add(this.FuelInHourTextBox);
            this.Controls.Add(this.RobTrRadioButton);
            this.Controls.Add(this.VarTrRadioButton);
            this.Controls.Add(this.AutTrRadioButton);
            this.Controls.Add(this.MechTrRadioButton);
            this.Controls.Add(this.FuelInHourLabel);
            this.Controls.Add(this.FuelTextBox);
            this.Controls.Add(this.FuelLabel);
            this.Controls.Add(this.TransmissiomLabel);
            this.Controls.Add(this.NameTextBox1);
            this.Controls.Add(this.AddCountryButton);
            this.Controls.Add(this.ReadyButton);
            this.Controls.Add(this.AddCategoryButton);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.OpenPhotoButton);
            this.Controls.Add(this.PhotoPictureBox);
            this.Controls.Add(this.CountAutoDomainUpDown);
            this.Controls.Add(this.CountAutoLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.SumLeaseMaskedTextBox);
            this.Controls.Add(this.SumLeaseLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CountryLabel);
            this.Controls.Add(this.CountryComboBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.NameTextBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AutoRegistr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация новой модели автомобиля";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AutoRegistr_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransmissionErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox2;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.ComboBox CountryComboBox;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SumLeaseLabel;
        private System.Windows.Forms.MaskedTextBox SumLeaseMaskedTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label CountAutoLabel;
        private System.Windows.Forms.DomainUpDown CountAutoDomainUpDown;
        private System.Windows.Forms.PictureBox PhotoPictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button OpenPhotoButton;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Button AddCategoryButton;
        private System.Windows.Forms.Button ReadyButton;
        private System.Windows.Forms.Button AddCountryButton;
        private System.Windows.Forms.TextBox NameTextBox1;
        private System.Windows.Forms.TextBox FuelInHourTextBox;
        private System.Windows.Forms.RadioButton RobTrRadioButton;
        private System.Windows.Forms.RadioButton VarTrRadioButton;
        private System.Windows.Forms.RadioButton AutTrRadioButton;
        private System.Windows.Forms.RadioButton MechTrRadioButton;
        private System.Windows.Forms.Label FuelInHourLabel;
        private System.Windows.Forms.TextBox FuelTextBox;
        private System.Windows.Forms.Label FuelLabel;
        private System.Windows.Forms.Label TransmissiomLabel;
        private System.Windows.Forms.ErrorProvider TransmissionErrorProvider;
    }
}