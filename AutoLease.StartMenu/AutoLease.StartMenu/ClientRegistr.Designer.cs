namespace AutoLease.StartMenu
{
    partial class ClientRegistr
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientRegistr));
            this.NameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SurnameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.FathernameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.FathernameLabel = new System.Windows.Forms.Label();
            this.SexLabel = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.BirthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CreationDateLabel = new System.Windows.Forms.Label();
            this.ReadyButton = new System.Windows.Forms.Button();
            this.NameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SurnameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.FathernameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CreationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BirthdayErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SexErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DriverLicLabel = new System.Windows.Forms.Label();
            this.DriverLicCheckBox = new System.Windows.Forms.CheckBox();
            this.DriverLicDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DriverLicDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BirthdayErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SexErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            resources.ApplyResources(this.NameTextBox, "NameTextBox");
            this.NameTextBox.AsciiOnly = true;
            this.NameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.NameTextBox.BeepOnError = true;
            this.NameTextBox.Name = "NameTextBox";
            // 
            // SurnameTextBox
            // 
            resources.ApplyResources(this.SurnameTextBox, "SurnameTextBox");
            this.SurnameTextBox.AsciiOnly = true;
            this.SurnameTextBox.Name = "SurnameTextBox";
            // 
            // FathernameTextBox
            // 
            resources.ApplyResources(this.FathernameTextBox, "FathernameTextBox");
            this.FathernameTextBox.AsciiOnly = true;
            this.FathernameTextBox.Name = "FathernameTextBox";
            // 
            // MaleRadioButton
            // 
            resources.ApplyResources(this.MaleRadioButton, "MaleRadioButton");
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            this.MaleRadioButton.CheckedChanged += new System.EventHandler(this.MaleRadioButton_CheckedChanged);
            // 
            // FemaleRadioButton
            // 
            resources.ApplyResources(this.FemaleRadioButton, "FemaleRadioButton");
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            this.FemaleRadioButton.CheckedChanged += new System.EventHandler(this.FemaleRadioButton_CheckedChanged);
            // 
            // NameLabel
            // 
            resources.ApplyResources(this.NameLabel, "NameLabel");
            this.NameLabel.Name = "NameLabel";
            // 
            // SurnameLabel
            // 
            resources.ApplyResources(this.SurnameLabel, "SurnameLabel");
            this.SurnameLabel.Name = "SurnameLabel";
            // 
            // FathernameLabel
            // 
            resources.ApplyResources(this.FathernameLabel, "FathernameLabel");
            this.FathernameLabel.Name = "FathernameLabel";
            // 
            // SexLabel
            // 
            resources.ApplyResources(this.SexLabel, "SexLabel");
            this.SexLabel.Name = "SexLabel";
            // 
            // BirthdayLabel
            // 
            resources.ApplyResources(this.BirthdayLabel, "BirthdayLabel");
            this.BirthdayLabel.Name = "BirthdayLabel";
            // 
            // BirthdayDateTimePicker
            // 
            resources.ApplyResources(this.BirthdayDateTimePicker, "BirthdayDateTimePicker");
            this.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker";
            this.BirthdayDateTimePicker.ValueChanged += new System.EventHandler(this.BirthdayDateTimePicker_ValueChanged);
            // 
            // CreationDateLabel
            // 
            resources.ApplyResources(this.CreationDateLabel, "CreationDateLabel");
            this.CreationDateLabel.Name = "CreationDateLabel";
            // 
            // ReadyButton
            // 
            resources.ApplyResources(this.ReadyButton, "ReadyButton");
            this.ReadyButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ReadyButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ReadyButton.FlatAppearance.BorderSize = 2;
            this.ReadyButton.Name = "ReadyButton";
            this.ReadyButton.UseVisualStyleBackColor = false;
            this.ReadyButton.Click += new System.EventHandler(this.ReadyButton_Click);
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
            // CreationDateTimePicker
            // 
            resources.ApplyResources(this.CreationDateTimePicker, "CreationDateTimePicker");
            this.CreationDateTimePicker.Name = "CreationDateTimePicker";
            this.CreationDateTimePicker.Value = new System.DateTime(2017, 12, 1, 13, 58, 50, 0);
            // 
            // BirthdayErrorProvider
            // 
            this.BirthdayErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.BirthdayErrorProvider.ContainerControl = this;
            // 
            // SexErrorProvider
            // 
            this.SexErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.SexErrorProvider.ContainerControl = this;
            // 
            // DriverLicLabel
            // 
            resources.ApplyResources(this.DriverLicLabel, "DriverLicLabel");
            this.DriverLicLabel.Name = "DriverLicLabel";
            // 
            // DriverLicCheckBox
            // 
            resources.ApplyResources(this.DriverLicCheckBox, "DriverLicCheckBox");
            this.DriverLicCheckBox.Name = "DriverLicCheckBox";
            this.DriverLicCheckBox.UseVisualStyleBackColor = true;
            this.DriverLicCheckBox.CheckedChanged += new System.EventHandler(this.DriverLicCheckBox_CheckedChanged);
            // 
            // DriverLicDateTimePicker
            // 
            resources.ApplyResources(this.DriverLicDateTimePicker, "DriverLicDateTimePicker");
            this.DriverLicDateTimePicker.Name = "DriverLicDateTimePicker";
            // 
            // DriverLicDateLabel
            // 
            resources.ApplyResources(this.DriverLicDateLabel, "DriverLicDateLabel");
            this.DriverLicDateLabel.Name = "DriverLicDateLabel";
            // 
            // ClientRegistr
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.Controls.Add(this.DriverLicDateLabel);
            this.Controls.Add(this.DriverLicDateTimePicker);
            this.Controls.Add(this.DriverLicCheckBox);
            this.Controls.Add(this.DriverLicLabel);
            this.Controls.Add(this.ReadyButton);
            this.Controls.Add(this.CreationDateTimePicker);
            this.Controls.Add(this.CreationDateLabel);
            this.Controls.Add(this.BirthdayDateTimePicker);
            this.Controls.Add(this.BirthdayLabel);
            this.Controls.Add(this.SexLabel);
            this.Controls.Add(this.FathernameLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.FemaleRadioButton);
            this.Controls.Add(this.MaleRadioButton);
            this.Controls.Add(this.FathernameTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MinimizeBox = false;
            this.Name = "ClientRegistr";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientRegistr_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.BirthdayErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SexErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox NameTextBox;
        private System.Windows.Forms.MaskedTextBox SurnameTextBox;
        private System.Windows.Forms.MaskedTextBox FathernameTextBox;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label FathernameLabel;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.DateTimePicker BirthdayDateTimePicker;
        private System.Windows.Forms.Label CreationDateLabel;
        private System.Windows.Forms.Button ReadyButton;
        private System.Windows.Forms.ToolTip NameToolTip;
        private System.Windows.Forms.ToolTip SurnameToolTip;
        private System.Windows.Forms.ToolTip FathernameToolTip;
        private System.Windows.Forms.DateTimePicker CreationDateTimePicker;
        private System.Windows.Forms.ErrorProvider BirthdayErrorProvider;
        private System.Windows.Forms.ErrorProvider SexErrorProvider;
        private System.Windows.Forms.Label DriverLicDateLabel;
        private System.Windows.Forms.DateTimePicker DriverLicDateTimePicker;
        private System.Windows.Forms.CheckBox DriverLicCheckBox;
        private System.Windows.Forms.Label DriverLicLabel;
    }
}

