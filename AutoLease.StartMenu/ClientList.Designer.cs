namespace AutoLease.StartMenu
{
    partial class ClientList
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
            System.Windows.Forms.Button SearchButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientList));
            this.searchErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.AutoAddButton = new System.Windows.Forms.Button();
            this.IDRadioButton = new System.Windows.Forms.RadioButton();
            this.NameRadioButton = new System.Windows.Forms.RadioButton();
            this.SurnameRadioButton = new System.Windows.Forms.RadioButton();
            this.clientListTable = new System.Windows.Forms.TableLayoutPanel();
            this.InfoTable = new System.Windows.Forms.TableLayoutPanel();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.SexLabel = new System.Windows.Forms.Label();
            this.LicenseLabel = new System.Windows.Forms.Label();
            this.CreationDateLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.DebtLabel = new System.Windows.Forms.Label();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.CreationDateTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.DebtCheckBox = new System.Windows.Forms.CheckBox();
            this.SexTextBox = new System.Windows.Forms.TextBox();
            this.LicenseTextBox = new System.Windows.Forms.TextBox();
            this.ButtonsTable = new System.Windows.Forms.TableLayoutPanel();
            this.OpenButton = new System.Windows.Forms.Button();
            this.NSFTextBox = new System.Windows.Forms.TextBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.StatusToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ClientsToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.AutoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.DateToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LeaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchErrorProvider)).BeginInit();
            this.clientListTable.SuspendLayout();
            this.InfoTable.SuspendLayout();
            this.ButtonsTable.SuspendLayout();
            this.StatusToolStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            SearchButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            SearchButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            SearchButton.FlatAppearance.BorderSize = 2;
            SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SearchButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            SearchButton.Location = new System.Drawing.Point(464, 49);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new System.Drawing.Size(125, 30);
            SearchButton.TabIndex = 1;
            SearchButton.Text = "Поиск";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchErrorProvider
            // 
            this.searchErrorProvider.ContainerControl = this;
            // 
            // AutoAddButton
            // 
            this.AutoAddButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AutoAddButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AutoAddButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AutoAddButton.FlatAppearance.BorderSize = 2;
            this.AutoAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoAddButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutoAddButton.Location = new System.Drawing.Point(8, 59);
            this.AutoAddButton.Name = "AutoAddButton";
            this.AutoAddButton.Size = new System.Drawing.Size(98, 50);
            this.AutoAddButton.TabIndex = 17;
            this.AutoAddButton.Text = "Добавить авто";
            this.AutoAddButton.UseVisualStyleBackColor = false;
            this.AutoAddButton.Click += new System.EventHandler(this.AutoAddButton_Click);
            // 
            // IDRadioButton
            // 
            this.IDRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IDRadioButton.AutoSize = true;
            this.IDRadioButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDRadioButton.Location = new System.Drawing.Point(330, 75);
            this.IDRadioButton.Name = "IDRadioButton";
            this.IDRadioButton.Size = new System.Drawing.Size(54, 20);
            this.IDRadioButton.TabIndex = 31;
            this.IDRadioButton.Text = "по ID";
            this.IDRadioButton.UseVisualStyleBackColor = true;
            this.IDRadioButton.CheckedChanged += new System.EventHandler(this.IDRadioButton_CheckedChanged);
            // 
            // NameRadioButton
            // 
            this.NameRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameRadioButton.AutoSize = true;
            this.NameRadioButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameRadioButton.Location = new System.Drawing.Point(216, 75);
            this.NameRadioButton.Name = "NameRadioButton";
            this.NameRadioButton.Size = new System.Drawing.Size(81, 20);
            this.NameRadioButton.TabIndex = 30;
            this.NameRadioButton.Text = "по имени";
            this.NameRadioButton.UseVisualStyleBackColor = true;
            this.NameRadioButton.CheckedChanged += new System.EventHandler(this.NameRadioButton_CheckedChanged);
            // 
            // SurnameRadioButton
            // 
            this.SurnameRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SurnameRadioButton.AutoSize = true;
            this.SurnameRadioButton.Checked = true;
            this.SurnameRadioButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameRadioButton.Location = new System.Drawing.Point(90, 75);
            this.SurnameRadioButton.Name = "SurnameRadioButton";
            this.SurnameRadioButton.Size = new System.Drawing.Size(100, 20);
            this.SurnameRadioButton.TabIndex = 29;
            this.SurnameRadioButton.TabStop = true;
            this.SurnameRadioButton.Text = "по фамилии";
            this.SurnameRadioButton.UseVisualStyleBackColor = true;
            this.SurnameRadioButton.CheckedChanged += new System.EventHandler(this.SurnameRadioButton_CheckedChanged);
            // 
            // clientListTable
            // 
            this.clientListTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientListTable.BackColor = System.Drawing.Color.PapayaWhip;
            this.clientListTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.clientListTable.ColumnCount = 3;
            this.clientListTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.clientListTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.clientListTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.clientListTable.Controls.Add(this.InfoTable, 1, 0);
            this.clientListTable.Controls.Add(this.ButtonsTable, 2, 0);
            this.clientListTable.Controls.Add(this.NSFTextBox, 0, 0);
            this.clientListTable.Location = new System.Drawing.Point(24, 101);
            this.clientListTable.Name = "clientListTable";
            this.clientListTable.RowCount = 1;
            this.clientListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.clientListTable.Size = new System.Drawing.Size(840, 120);
            this.clientListTable.TabIndex = 28;
            // 
            // InfoTable
            // 
            this.InfoTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoTable.BackColor = System.Drawing.Color.PapayaWhip;
            this.InfoTable.ColumnCount = 4;
            this.InfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.InfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.InfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.InfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.InfoTable.Controls.Add(this.AgeLabel, 0, 0);
            this.InfoTable.Controls.Add(this.SexLabel, 0, 1);
            this.InfoTable.Controls.Add(this.LicenseLabel, 0, 2);
            this.InfoTable.Controls.Add(this.CreationDateLabel, 2, 0);
            this.InfoTable.Controls.Add(this.IDLabel, 2, 1);
            this.InfoTable.Controls.Add(this.DebtLabel, 2, 2);
            this.InfoTable.Controls.Add(this.AgeTextBox, 1, 0);
            this.InfoTable.Controls.Add(this.CreationDateTextBox, 3, 0);
            this.InfoTable.Controls.Add(this.IDTextBox, 3, 1);
            this.InfoTable.Controls.Add(this.DebtCheckBox, 3, 2);
            this.InfoTable.Controls.Add(this.SexTextBox, 1, 1);
            this.InfoTable.Controls.Add(this.LicenseTextBox, 1, 2);
            this.InfoTable.Location = new System.Drawing.Point(181, 4);
            this.InfoTable.Name = "InfoTable";
            this.InfoTable.RowCount = 3;
            this.InfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.InfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.InfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.InfoTable.Size = new System.Drawing.Size(524, 112);
            this.InfoTable.TabIndex = 1;
            // 
            // AgeLabel
            // 
            this.AgeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgeLabel.Location = new System.Drawing.Point(35, 10);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(61, 17);
            this.AgeLabel.TabIndex = 0;
            this.AgeLabel.Text = "Возраст";
            // 
            // SexLabel
            // 
            this.SexLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SexLabel.AutoSize = true;
            this.SexLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SexLabel.Location = new System.Drawing.Point(49, 47);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(33, 17);
            this.SexLabel.TabIndex = 1;
            this.SexLabel.Text = "Пол";
            // 
            // LicenseLabel
            // 
            this.LicenseLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LicenseLabel.AutoSize = true;
            this.LicenseLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LicenseLabel.Location = new System.Drawing.Point(40, 84);
            this.LicenseLabel.Name = "LicenseLabel";
            this.LicenseLabel.Size = new System.Drawing.Size(50, 17);
            this.LicenseLabel.TabIndex = 2;
            this.LicenseLabel.Text = "Права";
            // 
            // CreationDateLabel
            // 
            this.CreationDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreationDateLabel.AutoSize = true;
            this.CreationDateLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreationDateLabel.Location = new System.Drawing.Point(274, 10);
            this.CreationDateLabel.Name = "CreationDateLabel";
            this.CreationDateLabel.Size = new System.Drawing.Size(107, 17);
            this.CreationDateLabel.TabIndex = 3;
            this.CreationDateLabel.Text = "Дата создания";
            // 
            // IDLabel
            // 
            this.IDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDLabel.Location = new System.Drawing.Point(317, 47);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 17);
            this.IDLabel.TabIndex = 4;
            this.IDLabel.Text = "ID";
            // 
            // DebtLabel
            // 
            this.DebtLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DebtLabel.AutoSize = true;
            this.DebtLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DebtLabel.Location = new System.Drawing.Point(272, 84);
            this.DebtLabel.Name = "DebtLabel";
            this.DebtLabel.Size = new System.Drawing.Size(110, 17);
            this.DebtLabel.TabIndex = 5;
            this.DebtLabel.Text = "Задолженность";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AgeTextBox.Enabled = false;
            this.AgeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgeTextBox.Location = new System.Drawing.Point(146, 7);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(100, 22);
            this.AgeTextBox.TabIndex = 6;
            // 
            // CreationDateTextBox
            // 
            this.CreationDateTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreationDateTextBox.Enabled = false;
            this.CreationDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreationDateTextBox.Location = new System.Drawing.Point(408, 7);
            this.CreationDateTextBox.Name = "CreationDateTextBox";
            this.CreationDateTextBox.Size = new System.Drawing.Size(100, 22);
            this.CreationDateTextBox.TabIndex = 9;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDTextBox.Enabled = false;
            this.IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDTextBox.Location = new System.Drawing.Point(408, 44);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 22);
            this.IDTextBox.TabIndex = 10;
            // 
            // DebtCheckBox
            // 
            this.DebtCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DebtCheckBox.AutoSize = true;
            this.DebtCheckBox.Enabled = false;
            this.DebtCheckBox.Location = new System.Drawing.Point(451, 86);
            this.DebtCheckBox.Name = "DebtCheckBox";
            this.DebtCheckBox.Size = new System.Drawing.Size(15, 14);
            this.DebtCheckBox.TabIndex = 12;
            this.DebtCheckBox.UseVisualStyleBackColor = true;
            // 
            // SexTextBox
            // 
            this.SexTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SexTextBox.Enabled = false;
            this.SexTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SexTextBox.Location = new System.Drawing.Point(146, 44);
            this.SexTextBox.Name = "SexTextBox";
            this.SexTextBox.Size = new System.Drawing.Size(100, 22);
            this.SexTextBox.TabIndex = 7;
            // 
            // LicenseTextBox
            // 
            this.LicenseTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LicenseTextBox.Enabled = false;
            this.LicenseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LicenseTextBox.Location = new System.Drawing.Point(146, 82);
            this.LicenseTextBox.Name = "LicenseTextBox";
            this.LicenseTextBox.Size = new System.Drawing.Size(100, 22);
            this.LicenseTextBox.TabIndex = 13;
            // 
            // ButtonsTable
            // 
            this.ButtonsTable.ColumnCount = 1;
            this.ButtonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsTable.Controls.Add(this.OpenButton, 0, 0);
            this.ButtonsTable.Controls.Add(this.AutoAddButton, 0, 1);
            this.ButtonsTable.Location = new System.Drawing.Point(712, 4);
            this.ButtonsTable.Name = "ButtonsTable";
            this.ButtonsTable.RowCount = 2;
            this.ButtonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonsTable.Size = new System.Drawing.Size(114, 112);
            this.ButtonsTable.TabIndex = 5;
            // 
            // OpenButton
            // 
            this.OpenButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OpenButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OpenButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OpenButton.FlatAppearance.BorderSize = 2;
            this.OpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenButton.Location = new System.Drawing.Point(8, 13);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(98, 30);
            this.OpenButton.TabIndex = 26;
            this.OpenButton.Text = "Открыть";
            this.OpenButton.UseVisualStyleBackColor = false;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // NSFTextBox
            // 
            this.NSFTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NSFTextBox.Enabled = false;
            this.NSFTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NSFTextBox.Location = new System.Drawing.Point(7, 27);
            this.NSFTextBox.Multiline = true;
            this.NSFTextBox.Name = "NSFTextBox";
            this.NSFTextBox.Size = new System.Drawing.Size(164, 66);
            this.NSFTextBox.TabIndex = 4;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchTextBox.Location = new System.Drawing.Point(64, 49);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(394, 20);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            this.SearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTextBox_KeyPress);
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
            this.StatusToolStrip.Location = new System.Drawing.Point(0, 436);
            this.StatusToolStrip.Name = "StatusToolStrip";
            this.StatusToolStrip.Size = new System.Drawing.Size(884, 25);
            this.StatusToolStrip.TabIndex = 36;
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
            this.menuStrip1.Size = new System.Drawing.Size(884, 38);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientListToolStripMenuItem,
            this.AutoListToolStripMenuItem});
            this.OpenToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(68, 34);
            this.OpenToolStripMenuItem.Text = "Открыть";
            // 
            // ClientListToolStripMenuItem
            // 
            this.ClientListToolStripMenuItem.Enabled = false;
            this.ClientListToolStripMenuItem.Name = "ClientListToolStripMenuItem";
            this.ClientListToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.ClientListToolStripMenuItem.Text = "Список клиентов";
            // 
            // AutoListToolStripMenuItem
            // 
            this.AutoListToolStripMenuItem.Name = "AutoListToolStripMenuItem";
            this.AutoListToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.AutoListToolStripMenuItem.Text = "Список авто";
            this.AutoListToolStripMenuItem.Click += new System.EventHandler(this.AutoListToolStripMenuItem1_Click);
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
            this.LeaseToolStripMenuItem.Name = "LeaseToolStripMenuItem";
            this.LeaseToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.LeaseToolStripMenuItem.Text = "Выдачу";
            this.LeaseToolStripMenuItem.Click += new System.EventHandler(this.LeaseToolStripMenuItem_Click);
            // 
            // ReturnToolStripMenuItem
            // 
            this.ReturnToolStripMenuItem.Enabled = false;
            this.ReturnToolStripMenuItem.Name = "ReturnToolStripMenuItem";
            this.ReturnToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.ReturnToolStripMenuItem.Text = "Возврат";
            // 
            // ClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.StatusToolStrip);
            this.Controls.Add(this.IDRadioButton);
            this.Controls.Add(this.NameRadioButton);
            this.Controls.Add(this.SurnameRadioButton);
            this.Controls.Add(this.clientListTable);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(SearchButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClientList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список клиентов";
            this.Activated += new System.EventHandler(this.ClientList_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientCard_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.searchErrorProvider)).EndInit();
            this.clientListTable.ResumeLayout(false);
            this.clientListTable.PerformLayout();
            this.InfoTable.ResumeLayout(false);
            this.InfoTable.PerformLayout();
            this.ButtonsTable.ResumeLayout(false);
            this.StatusToolStrip.ResumeLayout(false);
            this.StatusToolStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider searchErrorProvider;
        private System.Windows.Forms.Button AutoAddButton;
        private System.Windows.Forms.RadioButton IDRadioButton;
        private System.Windows.Forms.RadioButton NameRadioButton;
        private System.Windows.Forms.RadioButton SurnameRadioButton;
        private System.Windows.Forms.TableLayoutPanel clientListTable;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.TableLayoutPanel InfoTable;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.Label LicenseLabel;
        private System.Windows.Forms.Label CreationDateLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label DebtLabel;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.TextBox CreationDateTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.CheckBox DebtCheckBox;
        private System.Windows.Forms.TextBox SexTextBox;
        private System.Windows.Forms.TextBox NSFTextBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.TableLayoutPanel ButtonsTable;
        private System.Windows.Forms.ToolStrip StatusToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox ClientsToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox AutoToolStripTextBox;
        private System.Windows.Forms.ToolStripTextBox DateToolStripTextBox;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.TextBox LicenseTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AutoListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LeaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReturnToolStripMenuItem;
    }
}