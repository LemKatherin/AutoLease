namespace AutoLease.StartMenu
{
    partial class AutoModelList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoModelList));
            this.CategoryRadioButton = new System.Windows.Forms.RadioButton();
            this.ModelRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
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
            this.autoListTable = new System.Windows.Forms.TableLayoutPanel();
            this.AutoPhotoBox = new System.Windows.Forms.PictureBox();
            this.AutoButtonsTable = new System.Windows.Forms.TableLayoutPanel();
            this.OpenAllButton = new System.Windows.Forms.Button();
            this.OpenInfoButton = new System.Windows.Forms.Button();
            this.AutoInfoTable = new System.Windows.Forms.TableLayoutPanel();
            this.SumLeaseTextBox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.SumLeaseLabel = new System.Windows.Forms.Label();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.CountAutoLabel = new System.Windows.Forms.Label();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.CountAutoTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.StatusToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ClientsToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.AutoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.DateToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.MarkRadioButton = new System.Windows.Forms.RadioButton();
            SearchButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.autoListTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoPhotoBox)).BeginInit();
            this.AutoButtonsTable.SuspendLayout();
            this.AutoInfoTable.SuspendLayout();
            this.StatusToolStrip.SuspendLayout();
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
            SearchButton.Location = new System.Drawing.Point(493, 49);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new System.Drawing.Size(125, 30);
            SearchButton.TabIndex = 28;
            SearchButton.Text = "Поиск";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CategoryRadioButton
            // 
            this.CategoryRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CategoryRadioButton.AutoSize = true;
            this.CategoryRadioButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryRadioButton.Location = new System.Drawing.Point(331, 74);
            this.CategoryRadioButton.Name = "CategoryRadioButton";
            this.CategoryRadioButton.Size = new System.Drawing.Size(101, 20);
            this.CategoryRadioButton.TabIndex = 31;
            this.CategoryRadioButton.Text = "по категории";
            this.CategoryRadioButton.UseVisualStyleBackColor = true;
            this.CategoryRadioButton.CheckedChanged += new System.EventHandler(this.CategoryRadioButton_CheckedChanged);
            // 
            // ModelRadioButton
            // 
            this.ModelRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ModelRadioButton.AutoSize = true;
            this.ModelRadioButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelRadioButton.Location = new System.Drawing.Point(213, 74);
            this.ModelRadioButton.Name = "ModelRadioButton";
            this.ModelRadioButton.Size = new System.Drawing.Size(87, 20);
            this.ModelRadioButton.TabIndex = 30;
            this.ModelRadioButton.Text = "по модели";
            this.ModelRadioButton.UseVisualStyleBackColor = true;
            this.ModelRadioButton.CheckedChanged += new System.EventHandler(this.ModelRadioButton_CheckedChanged);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchTextBox.Location = new System.Drawing.Point(64, 49);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(423, 20);
            this.SearchTextBox.TabIndex = 29;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            this.SearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTextBox_KeyPress);
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
            this.menuStrip1.TabIndex = 34;
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
            // autoListTable
            // 
            this.autoListTable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.autoListTable.BackColor = System.Drawing.Color.PapayaWhip;
            this.autoListTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.autoListTable.ColumnCount = 3;
            this.autoListTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.75661F));
            this.autoListTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.24339F));
            this.autoListTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.autoListTable.Controls.Add(this.AutoPhotoBox, 0, 0);
            this.autoListTable.Controls.Add(this.AutoButtonsTable, 2, 0);
            this.autoListTable.Controls.Add(this.AutoInfoTable, 1, 0);
            this.autoListTable.Location = new System.Drawing.Point(24, 100);
            this.autoListTable.Name = "autoListTable";
            this.autoListTable.RowCount = 1;
            this.autoListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.autoListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.autoListTable.Size = new System.Drawing.Size(840, 120);
            this.autoListTable.TabIndex = 44;
            // 
            // AutoPhotoBox
            // 
            this.AutoPhotoBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AutoPhotoBox.Enabled = false;
            this.AutoPhotoBox.Location = new System.Drawing.Point(8, 10);
            this.AutoPhotoBox.Name = "AutoPhotoBox";
            this.AutoPhotoBox.Size = new System.Drawing.Size(162, 99);
            this.AutoPhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AutoPhotoBox.TabIndex = 0;
            this.AutoPhotoBox.TabStop = false;
            // 
            // AutoButtonsTable
            // 
            this.AutoButtonsTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AutoButtonsTable.ColumnCount = 1;
            this.AutoButtonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AutoButtonsTable.Controls.Add(this.OpenAllButton, 0, 1);
            this.AutoButtonsTable.Controls.Add(this.OpenInfoButton, 0, 0);
            this.AutoButtonsTable.Location = new System.Drawing.Point(721, 4);
            this.AutoButtonsTable.Name = "AutoButtonsTable";
            this.AutoButtonsTable.RowCount = 2;
            this.AutoButtonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AutoButtonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AutoButtonsTable.Size = new System.Drawing.Size(113, 112);
            this.AutoButtonsTable.TabIndex = 2;
            // 
            // OpenAllButton
            // 
            this.OpenAllButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OpenAllButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OpenAllButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OpenAllButton.FlatAppearance.BorderSize = 2;
            this.OpenAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenAllButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenAllButton.Location = new System.Drawing.Point(6, 69);
            this.OpenAllButton.Name = "OpenAllButton";
            this.OpenAllButton.Size = new System.Drawing.Size(100, 30);
            this.OpenAllButton.TabIndex = 35;
            this.OpenAllButton.Text = "Все авто";
            this.OpenAllButton.UseVisualStyleBackColor = false;
            this.OpenAllButton.Click += new System.EventHandler(this.OpenAllButton_Click);
            // 
            // OpenInfoButton
            // 
            this.OpenInfoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OpenInfoButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OpenInfoButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OpenInfoButton.FlatAppearance.BorderSize = 2;
            this.OpenInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenInfoButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenInfoButton.Location = new System.Drawing.Point(6, 13);
            this.OpenInfoButton.Name = "OpenInfoButton";
            this.OpenInfoButton.Size = new System.Drawing.Size(100, 30);
            this.OpenInfoButton.TabIndex = 34;
            this.OpenInfoButton.Text = "Автокарточка";
            this.OpenInfoButton.UseVisualStyleBackColor = false;
            this.OpenInfoButton.Click += new System.EventHandler(this.OpenInfoButton_Click);
            // 
            // AutoInfoTable
            // 
            this.AutoInfoTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoInfoTable.BackColor = System.Drawing.Color.PapayaWhip;
            this.AutoInfoTable.ColumnCount = 4;
            this.AutoInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AutoInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AutoInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AutoInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AutoInfoTable.Controls.Add(this.SumLeaseTextBox, 3, 1);
            this.AutoInfoTable.Controls.Add(this.ModelLabel, 0, 0);
            this.AutoInfoTable.Controls.Add(this.SumLeaseLabel, 2, 1);
            this.AutoInfoTable.Controls.Add(this.CountryLabel, 0, 1);
            this.AutoInfoTable.Controls.Add(this.CountAutoLabel, 2, 0);
            this.AutoInfoTable.Controls.Add(this.CountryTextBox, 1, 1);
            this.AutoInfoTable.Controls.Add(this.CountAutoTextBox, 3, 0);
            this.AutoInfoTable.Controls.Add(this.ModelTextBox, 1, 0);
            this.AutoInfoTable.Controls.Add(this.CategoryLabel, 0, 2);
            this.AutoInfoTable.Controls.Add(this.CategoryTextBox, 1, 2);
            this.AutoInfoTable.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutoInfoTable.Location = new System.Drawing.Point(181, 4);
            this.AutoInfoTable.Name = "AutoInfoTable";
            this.AutoInfoTable.RowCount = 3;
            this.AutoInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.AutoInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.AutoInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.AutoInfoTable.Size = new System.Drawing.Size(531, 112);
            this.AutoInfoTable.TabIndex = 1;
            // 
            // SumLeaseTextBox
            // 
            this.SumLeaseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SumLeaseTextBox.Enabled = false;
            this.SumLeaseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumLeaseTextBox.Location = new System.Drawing.Point(398, 44);
            this.SumLeaseTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SumLeaseTextBox.Name = "SumLeaseTextBox";
            this.SumLeaseTextBox.Size = new System.Drawing.Size(131, 22);
            this.SumLeaseTextBox.TabIndex = 35;
            // 
            // ModelLabel
            // 
            this.ModelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelLabel.Location = new System.Drawing.Point(37, 10);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(57, 17);
            this.ModelLabel.TabIndex = 0;
            this.ModelLabel.Text = "Модель";
            // 
            // SumLeaseLabel
            // 
            this.SumLeaseLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SumLeaseLabel.AutoSize = true;
            this.SumLeaseLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumLeaseLabel.Location = new System.Drawing.Point(269, 47);
            this.SumLeaseLabel.Name = "SumLeaseLabel";
            this.SumLeaseLabel.Size = new System.Drawing.Size(122, 17);
            this.SumLeaseLabel.TabIndex = 34;
            this.SumLeaseLabel.Text = "Аренда в сутки, $";
            // 
            // CountryLabel
            // 
            this.CountryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryLabel.Location = new System.Drawing.Point(36, 47);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(59, 17);
            this.CountryLabel.TabIndex = 1;
            this.CountryLabel.Text = "Страна";
            // 
            // CountAutoLabel
            // 
            this.CountAutoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CountAutoLabel.AutoSize = true;
            this.CountAutoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountAutoLabel.Location = new System.Drawing.Point(288, 10);
            this.CountAutoLabel.Name = "CountAutoLabel";
            this.CountAutoLabel.Size = new System.Drawing.Size(84, 17);
            this.CountAutoLabel.TabIndex = 3;
            this.CountAutoLabel.Text = "Кол-во авто";
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CountryTextBox.Enabled = false;
            this.CountryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryTextBox.Location = new System.Drawing.Point(135, 44);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(126, 22);
            this.CountryTextBox.TabIndex = 7;
            // 
            // CountAutoTextBox
            // 
            this.CountAutoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CountAutoTextBox.Enabled = false;
            this.CountAutoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountAutoTextBox.Location = new System.Drawing.Point(399, 7);
            this.CountAutoTextBox.Name = "CountAutoTextBox";
            this.CountAutoTextBox.Size = new System.Drawing.Size(129, 22);
            this.CountAutoTextBox.TabIndex = 9;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ModelTextBox.Enabled = false;
            this.ModelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelTextBox.Location = new System.Drawing.Point(135, 7);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(126, 22);
            this.ModelTextBox.TabIndex = 6;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabel.Location = new System.Drawing.Point(28, 84);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(75, 17);
            this.CategoryLabel.TabIndex = 5;
            this.CategoryLabel.Text = "Категория";
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryTextBox.Enabled = false;
            this.CategoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryTextBox.Location = new System.Drawing.Point(135, 82);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(126, 22);
            this.CategoryTextBox.TabIndex = 11;
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
            this.StatusToolStrip.TabIndex = 45;
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
            // MarkRadioButton
            // 
            this.MarkRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MarkRadioButton.AutoSize = true;
            this.MarkRadioButton.Checked = true;
            this.MarkRadioButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MarkRadioButton.Location = new System.Drawing.Point(99, 74);
            this.MarkRadioButton.Name = "MarkRadioButton";
            this.MarkRadioButton.Size = new System.Drawing.Size(82, 20);
            this.MarkRadioButton.TabIndex = 46;
            this.MarkRadioButton.TabStop = true;
            this.MarkRadioButton.Text = "по марке";
            this.MarkRadioButton.UseVisualStyleBackColor = true;
            this.MarkRadioButton.CheckedChanged += new System.EventHandler(this.MarkRadioButton_CheckedChanged);
            // 
            // AutoModelList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.MarkRadioButton);
            this.Controls.Add(this.StatusToolStrip);
            this.Controls.Add(this.autoListTable);
            this.Controls.Add(this.CategoryRadioButton);
            this.Controls.Add(this.ModelRadioButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(SearchButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AutoModelList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каталог автомобилей";
            this.Activated += new System.EventHandler(this.AutoModelList_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AutoList_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.autoListTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AutoPhotoBox)).EndInit();
            this.AutoButtonsTable.ResumeLayout(false);
            this.AutoInfoTable.ResumeLayout(false);
            this.AutoInfoTable.PerformLayout();
            this.StatusToolStrip.ResumeLayout(false);
            this.StatusToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton CategoryRadioButton;
        private System.Windows.Forms.RadioButton ModelRadioButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem RegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientListToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem FormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LeaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReturnToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel autoListTable;
        private System.Windows.Forms.PictureBox AutoPhotoBox;
        private System.Windows.Forms.TableLayoutPanel AutoInfoTable;
        private System.Windows.Forms.TextBox SumLeaseTextBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label SumLeaseLabel;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Label CountAutoLabel;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.TextBox CountAutoTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.TableLayoutPanel AutoButtonsTable;
        private System.Windows.Forms.Button OpenAllButton;
        private System.Windows.Forms.Button OpenInfoButton;
        private System.Windows.Forms.ToolStrip StatusToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox ClientsToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox AutoToolStripTextBox;
        private System.Windows.Forms.ToolStripTextBox DateToolStripTextBox;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.RadioButton MarkRadioButton;
        private System.Windows.Forms.ToolStripMenuItem AutoListToolStripMenuItem;
    }
}