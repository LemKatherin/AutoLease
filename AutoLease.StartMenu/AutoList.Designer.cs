namespace AutoLease.StartMenu
{
    partial class AutoList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoList));
            this.automobileListTable = new System.Windows.Forms.TableLayoutPanel();
            this.AddButton = new System.Windows.Forms.Button();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.StatusToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ClientsToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.AutoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.DateToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LeaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.EnableDateTextBox = new System.Windows.Forms.TextBox();
            this.EnableCheckBox = new System.Windows.Forms.CheckBox();
            this.EnableDateLabel = new System.Windows.Forms.Label();
            this.EnableLabel = new System.Windows.Forms.Label();
            this.MileageTextBox = new System.Windows.Forms.TextBox();
            this.MileageLabel = new System.Windows.Forms.Label();
            this.TransmissionTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.VarTrRadioButton = new System.Windows.Forms.RadioButton();
            this.MechTrRadioButton = new System.Windows.Forms.RadioButton();
            this.RobTrRadioButton = new System.Windows.Forms.RadioButton();
            this.AutTrRadioButton = new System.Windows.Forms.RadioButton();
            this.TransmissionLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.automobileInfoTable = new System.Windows.Forms.TableLayoutPanel();
            this.automobileListTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.StatusToolStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.TransmissionTableLayoutPanel.SuspendLayout();
            this.automobileInfoTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // automobileListTable
            // 
            this.automobileListTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.automobileListTable.BackColor = System.Drawing.Color.PapayaWhip;
            this.automobileListTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.automobileListTable.ColumnCount = 3;
            this.automobileListTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.60976F));
            this.automobileListTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.39024F));
            this.automobileListTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.automobileListTable.Controls.Add(this.automobileInfoTable, 0, 0);
            this.automobileListTable.Controls.Add(this.AddButton, 2, 0);
            this.automobileListTable.Controls.Add(this.PhotoPictureBox, 0, 0);
            this.automobileListTable.Location = new System.Drawing.Point(12, 92);
            this.automobileListTable.Name = "automobileListTable";
            this.automobileListTable.RowCount = 1;
            this.automobileListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.automobileListTable.Size = new System.Drawing.Size(952, 284);
            this.automobileListTable.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AddButton.Enabled = false;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AddButton.FlatAppearance.BorderSize = 2;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(824, 115);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 53);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Оформить выдачу";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PhotoPictureBox.Enabled = false;
            this.PhotoPictureBox.Location = new System.Drawing.Point(4, 71);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(202, 142);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoPictureBox.TabIndex = 1;
            this.PhotoPictureBox.TabStop = false;
            // 
            // AddNewButton
            // 
            this.AddNewButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AddNewButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AddNewButton.FlatAppearance.BorderSize = 2;
            this.AddNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewButton.Location = new System.Drawing.Point(749, 41);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(200, 35);
            this.AddNewButton.TabIndex = 0;
            this.AddNewButton.Text = "Добавить новое авто";
            this.AddNewButton.UseVisualStyleBackColor = false;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // StatusToolStrip
            // 
            this.StatusToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatusToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.StatusToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.ClientsToolStripTextBox,
            this.toolStripLabel2,
            this.AutoToolStripTextBox,
            this.DateToolStripTextBox});
            this.StatusToolStrip.Location = new System.Drawing.Point(0, 568);
            this.StatusToolStrip.Name = "StatusToolStrip";
            this.StatusToolStrip.Size = new System.Drawing.Size(976, 25);
            this.StatusToolStrip.TabIndex = 46;
            this.StatusToolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(58, 22);
            this.toolStripLabel1.Text = "Клиенты:";
            // 
            // ClientsToolStripTextBox
            // 
            this.ClientsToolStripTextBox.Enabled = false;
            this.ClientsToolStripTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.ClientsToolStripTextBox.Name = "ClientsToolStripTextBox";
            this.ClientsToolStripTextBox.Size = new System.Drawing.Size(50, 23);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(80, 22);
            this.toolStripLabel2.Text = "Автомобили:";
            // 
            // AutoToolStripTextBox
            // 
            this.AutoToolStripTextBox.Enabled = false;
            this.AutoToolStripTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.AutoToolStripTextBox.Name = "AutoToolStripTextBox";
            this.AutoToolStripTextBox.Size = new System.Drawing.Size(50, 23);
            // 
            // DateToolStripTextBox
            // 
            this.DateToolStripTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.DateToolStripTextBox.Enabled = false;
            this.DateToolStripTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.DateToolStripTextBox.Name = "DateToolStripTextBox";
            this.DateToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.RegistrationToolStripMenuItem,
            this.FormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.RegistrationToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 38);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientListToolStripMenuItem1,
            this.AutoListToolStripMenuItem});
            this.OpenToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(68, 34);
            this.OpenToolStripMenuItem.Text = "Открыть";
            // 
            // ClientListToolStripMenuItem1
            // 
            this.ClientListToolStripMenuItem1.Name = "ClientListToolStripMenuItem1";
            this.ClientListToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.ClientListToolStripMenuItem1.Text = "Список клиентов";
            this.ClientListToolStripMenuItem1.Click += new System.EventHandler(this.ClientListToolStripMenuItem1_Click);
            // 
            // AutoListToolStripMenuItem
            // 
            this.AutoListToolStripMenuItem.Enabled = false;
            this.AutoListToolStripMenuItem.Name = "AutoListToolStripMenuItem";
            this.AutoListToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.AutoListToolStripMenuItem.Text = "Список авто";
            // 
            // RegistrationToolStripMenuItem
            // 
            this.RegistrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientToolStripMenuItem,
            this.AutoToolStripMenuItem,
            this.CategoryToolStripMenuItem});
            this.RegistrationToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationToolStripMenuItem.Name = "RegistrationToolStripMenuItem";
            this.RegistrationToolStripMenuItem.Size = new System.Drawing.Size(96, 34);
            this.RegistrationToolStripMenuItem.Text = "Регистрация";
            // 
            // ClientToolStripMenuItem
            // 
            this.ClientToolStripMenuItem.Name = "ClientToolStripMenuItem";
            this.ClientToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.ClientToolStripMenuItem.Text = "Клиента";
            this.ClientToolStripMenuItem.Click += new System.EventHandler(this.ClientToolStripMenuItem_Click);
            // 
            // AutoToolStripMenuItem
            // 
            this.AutoToolStripMenuItem.Name = "AutoToolStripMenuItem";
            this.AutoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.AutoToolStripMenuItem.Text = "Модели авто";
            this.AutoToolStripMenuItem.Click += new System.EventHandler(this.AutoToolStripMenuItem_Click);
            // 
            // CategoryToolStripMenuItem
            // 
            this.CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem";
            this.CategoryToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.CategoryToolStripMenuItem.Text = "Категории авто";
            this.CategoryToolStripMenuItem.Click += new System.EventHandler(this.CategoryToolStripMenuItem_Click);
            // 
            // FormToolStripMenuItem
            // 
            this.FormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LeaseToolStripMenuItem,
            this.ReturnToolStripMenuItem});
            this.FormToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormToolStripMenuItem.Name = "FormToolStripMenuItem";
            this.FormToolStripMenuItem.Size = new System.Drawing.Size(88, 34);
            this.FormToolStripMenuItem.Text = "Оформить";
            // 
            // LeaseToolStripMenuItem
            // 
            this.LeaseToolStripMenuItem.Enabled = false;
            this.LeaseToolStripMenuItem.Name = "LeaseToolStripMenuItem";
            this.LeaseToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.LeaseToolStripMenuItem.Text = "Выдачу";
            // 
            // ReturnToolStripMenuItem
            // 
            this.ReturnToolStripMenuItem.Name = "ReturnToolStripMenuItem";
            this.ReturnToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.ReturnToolStripMenuItem.Text = "Возврат";
            this.ReturnToolStripMenuItem.Click += new System.EventHandler(this.ReturnToolStripMenuItem_Click);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDTextBox.Enabled = false;
            this.IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDTextBox.Location = new System.Drawing.Point(465, 59);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(132, 22);
            this.IDTextBox.TabIndex = 10;
            // 
            // IDLabel
            // 
            this.IDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDLabel.Location = new System.Drawing.Point(371, 60);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(25, 20);
            this.IDLabel.TabIndex = 9;
            this.IDLabel.Text = "ID";
            // 
            // EnableDateTextBox
            // 
            this.EnableDateTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnableDateTextBox.Enabled = false;
            this.EnableDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnableDateTextBox.Location = new System.Drawing.Point(465, 31);
            this.EnableDateTextBox.Name = "EnableDateTextBox";
            this.EnableDateTextBox.Size = new System.Drawing.Size(132, 22);
            this.EnableDateTextBox.TabIndex = 53;
            // 
            // EnableCheckBox
            // 
            this.EnableCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnableCheckBox.AutoSize = true;
            this.EnableCheckBox.Enabled = false;
            this.EnableCheckBox.Location = new System.Drawing.Point(523, 7);
            this.EnableCheckBox.Name = "EnableCheckBox";
            this.EnableCheckBox.Size = new System.Drawing.Size(15, 14);
            this.EnableCheckBox.TabIndex = 8;
            this.EnableCheckBox.UseVisualStyleBackColor = true;
            // 
            // EnableDateLabel
            // 
            this.EnableDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnableDateLabel.AutoSize = true;
            this.EnableDateLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnableDateLabel.Location = new System.Drawing.Point(308, 32);
            this.EnableDateLabel.Name = "EnableDateLabel";
            this.EnableDateLabel.Size = new System.Drawing.Size(151, 20);
            this.EnableDateLabel.TabIndex = 54;
            this.EnableDateLabel.Text = "Выдан в прокат до:";
            // 
            // EnableLabel
            // 
            this.EnableLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnableLabel.AutoSize = true;
            this.EnableLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnableLabel.Location = new System.Drawing.Point(342, 4);
            this.EnableLabel.Name = "EnableLabel";
            this.EnableLabel.Size = new System.Drawing.Size(83, 20);
            this.EnableLabel.TabIndex = 2;
            this.EnableLabel.Text = "В наличии";
            // 
            // MileageTextBox
            // 
            this.MileageTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MileageTextBox.Enabled = false;
            this.MileageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MileageTextBox.Location = new System.Drawing.Point(161, 59);
            this.MileageTextBox.Name = "MileageTextBox";
            this.MileageTextBox.Size = new System.Drawing.Size(110, 22);
            this.MileageTextBox.TabIndex = 7;
            // 
            // MileageLabel
            // 
            this.MileageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MileageLabel.AutoSize = true;
            this.MileageLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MileageLabel.Location = new System.Drawing.Point(14, 60);
            this.MileageLabel.Name = "MileageLabel";
            this.MileageLabel.Size = new System.Drawing.Size(99, 20);
            this.MileageLabel.TabIndex = 3;
            this.MileageLabel.Text = "Пробег (км)";
            // 
            // TransmissionTableLayoutPanel
            // 
            this.TransmissionTableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TransmissionTableLayoutPanel.ColumnCount = 2;
            this.automobileInfoTable.SetColumnSpan(this.TransmissionTableLayoutPanel, 3);
            this.TransmissionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TransmissionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TransmissionTableLayoutPanel.Controls.Add(this.AutTrRadioButton, 0, 0);
            this.TransmissionTableLayoutPanel.Controls.Add(this.RobTrRadioButton, 0, 1);
            this.TransmissionTableLayoutPanel.Controls.Add(this.MechTrRadioButton, 1, 0);
            this.TransmissionTableLayoutPanel.Controls.Add(this.VarTrRadioButton, 1, 1);
            this.TransmissionTableLayoutPanel.Location = new System.Drawing.Point(145, 87);
            this.TransmissionTableLayoutPanel.Name = "TransmissionTableLayoutPanel";
            this.TransmissionTableLayoutPanel.RowCount = 2;
            this.TransmissionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TransmissionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TransmissionTableLayoutPanel.Size = new System.Drawing.Size(438, 80);
            this.TransmissionTableLayoutPanel.TabIndex = 52;
            // 
            // VarTrRadioButton
            // 
            this.VarTrRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VarTrRadioButton.AutoSize = true;
            this.VarTrRadioButton.Enabled = false;
            this.VarTrRadioButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VarTrRadioButton.Location = new System.Drawing.Point(277, 49);
            this.VarTrRadioButton.Name = "VarTrRadioButton";
            this.VarTrRadioButton.Size = new System.Drawing.Size(102, 21);
            this.VarTrRadioButton.TabIndex = 23;
            this.VarTrRadioButton.TabStop = true;
            this.VarTrRadioButton.Text = "вариативная";
            this.VarTrRadioButton.UseVisualStyleBackColor = true;
            // 
            // MechTrRadioButton
            // 
            this.MechTrRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MechTrRadioButton.AutoSize = true;
            this.MechTrRadioButton.Enabled = false;
            this.MechTrRadioButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MechTrRadioButton.Location = new System.Drawing.Point(271, 9);
            this.MechTrRadioButton.Name = "MechTrRadioButton";
            this.MechTrRadioButton.Size = new System.Drawing.Size(115, 21);
            this.MechTrRadioButton.TabIndex = 21;
            this.MechTrRadioButton.TabStop = true;
            this.MechTrRadioButton.Text = "механическая";
            this.MechTrRadioButton.UseVisualStyleBackColor = true;
            // 
            // RobTrRadioButton
            // 
            this.RobTrRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RobTrRadioButton.AutoSize = true;
            this.RobTrRadioButton.Enabled = false;
            this.RobTrRadioButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RobTrRadioButton.Location = new System.Drawing.Point(39, 49);
            this.RobTrRadioButton.Name = "RobTrRadioButton";
            this.RobTrRadioButton.Size = new System.Drawing.Size(140, 21);
            this.RobTrRadioButton.TabIndex = 25;
            this.RobTrRadioButton.TabStop = true;
            this.RobTrRadioButton.Text = "роботизированная";
            this.RobTrRadioButton.UseVisualStyleBackColor = true;
            // 
            // AutTrRadioButton
            // 
            this.AutTrRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AutTrRadioButton.AutoSize = true;
            this.AutTrRadioButton.Enabled = false;
            this.AutTrRadioButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutTrRadioButton.Location = new System.Drawing.Point(46, 9);
            this.AutTrRadioButton.Name = "AutTrRadioButton";
            this.AutTrRadioButton.Size = new System.Drawing.Size(126, 21);
            this.AutTrRadioButton.TabIndex = 24;
            this.AutTrRadioButton.TabStop = true;
            this.AutTrRadioButton.Text = "автоматическая";
            this.AutTrRadioButton.UseVisualStyleBackColor = true;
            // 
            // TransmissionLabel
            // 
            this.TransmissionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TransmissionLabel.AutoSize = true;
            this.TransmissionLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransmissionLabel.Location = new System.Drawing.Point(24, 107);
            this.TransmissionLabel.Name = "TransmissionLabel";
            this.TransmissionLabel.Size = new System.Drawing.Size(80, 40);
            this.TransmissionLabel.TabIndex = 48;
            this.TransmissionLabel.Text = "Коробка передач";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.automobileInfoTable.SetColumnSpan(this.DescriptionTextBox, 3);
            this.DescriptionTextBox.Enabled = false;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(147, 175);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(434, 96);
            this.DescriptionTextBox.TabIndex = 50;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionLabel.Location = new System.Drawing.Point(20, 213);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(88, 20);
            this.DescriptionLabel.TabIndex = 49;
            this.DescriptionLabel.Text = "Описание";
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ColorTextBox.Enabled = false;
            this.ColorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorTextBox.Location = new System.Drawing.Point(131, 31);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(171, 22);
            this.ColorTextBox.TabIndex = 5;
            // 
            // YearTextBox
            // 
            this.YearTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.YearTextBox.Enabled = false;
            this.YearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearTextBox.Location = new System.Drawing.Point(161, 3);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(110, 22);
            this.YearTextBox.TabIndex = 4;
            // 
            // ColorLabel
            // 
            this.ColorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorLabel.Location = new System.Drawing.Point(42, 32);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(43, 20);
            this.ColorLabel.TabIndex = 1;
            this.ColorLabel.Text = "Цвет";
            // 
            // YearLabel
            // 
            this.YearLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.YearLabel.AutoSize = true;
            this.YearLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearLabel.Location = new System.Drawing.Point(13, 4);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(101, 20);
            this.YearLabel.TabIndex = 0;
            this.YearLabel.Text = "Год выпуска";
            // 
            // automobileInfoTable
            // 
            this.automobileInfoTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.automobileInfoTable.ColumnCount = 4;
            this.automobileInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.4876F));
            this.automobileInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.58678F));
            this.automobileInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.28099F));
            this.automobileInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.64463F));
            this.automobileInfoTable.Controls.Add(this.YearLabel, 0, 0);
            this.automobileInfoTable.Controls.Add(this.ColorLabel, 0, 1);
            this.automobileInfoTable.Controls.Add(this.YearTextBox, 1, 0);
            this.automobileInfoTable.Controls.Add(this.ColorTextBox, 1, 1);
            this.automobileInfoTable.Controls.Add(this.DescriptionLabel, 0, 7);
            this.automobileInfoTable.Controls.Add(this.DescriptionTextBox, 1, 7);
            this.automobileInfoTable.Controls.Add(this.TransmissionLabel, 0, 6);
            this.automobileInfoTable.Controls.Add(this.TransmissionTableLayoutPanel, 1, 6);
            this.automobileInfoTable.Controls.Add(this.MileageLabel, 0, 4);
            this.automobileInfoTable.Controls.Add(this.MileageTextBox, 1, 4);
            this.automobileInfoTable.Controls.Add(this.EnableLabel, 2, 0);
            this.automobileInfoTable.Controls.Add(this.EnableDateLabel, 2, 1);
            this.automobileInfoTable.Controls.Add(this.EnableCheckBox, 3, 0);
            this.automobileInfoTable.Controls.Add(this.EnableDateTextBox, 3, 1);
            this.automobileInfoTable.Controls.Add(this.IDLabel, 2, 4);
            this.automobileInfoTable.Controls.Add(this.IDTextBox, 3, 4);
            this.automobileInfoTable.Location = new System.Drawing.Point(213, 4);
            this.automobileInfoTable.Name = "automobileInfoTable";
            this.automobileInfoTable.RowCount = 8;
            this.automobileInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.automobileInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.automobileInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.automobileInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.automobileInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.automobileInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.automobileInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.automobileInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.automobileInfoTable.Size = new System.Drawing.Size(600, 276);
            this.automobileInfoTable.TabIndex = 5;
            // 
            // AutoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(976, 593);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.StatusToolStrip);
            this.Controls.Add(this.AddNewButton);
            this.Controls.Add(this.automobileListTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AutoList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список автомобиля";
            this.Activated += new System.EventHandler(this.automobileList_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AutoList_FormClosed);
            this.automobileListTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.StatusToolStrip.ResumeLayout(false);
            this.StatusToolStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TransmissionTableLayoutPanel.ResumeLayout(false);
            this.TransmissionTableLayoutPanel.PerformLayout();
            this.automobileInfoTable.ResumeLayout(false);
            this.automobileInfoTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel automobileListTable;
        private System.Windows.Forms.PictureBox PhotoPictureBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.ToolStrip StatusToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox ClientsToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox AutoToolStripTextBox;
        private System.Windows.Forms.ToolStripTextBox DateToolStripTextBox;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientListToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AutoListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LeaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReturnToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel automobileInfoTable;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label TransmissionLabel;
        private System.Windows.Forms.TableLayoutPanel TransmissionTableLayoutPanel;
        private System.Windows.Forms.RadioButton AutTrRadioButton;
        private System.Windows.Forms.RadioButton RobTrRadioButton;
        private System.Windows.Forms.RadioButton MechTrRadioButton;
        private System.Windows.Forms.RadioButton VarTrRadioButton;
        private System.Windows.Forms.Label MileageLabel;
        private System.Windows.Forms.TextBox MileageTextBox;
        private System.Windows.Forms.Label EnableLabel;
        private System.Windows.Forms.Label EnableDateLabel;
        private System.Windows.Forms.CheckBox EnableCheckBox;
        private System.Windows.Forms.TextBox EnableDateTextBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox IDTextBox;
    }
}