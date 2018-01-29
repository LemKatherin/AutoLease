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
            System.Windows.Forms.Button SearchButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoList));
            this.OpenInfoButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LeaseSumTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SumLeaseLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.OpenAllButton = new System.Windows.Forms.Button();
            this.IDRadioButton = new System.Windows.Forms.RadioButton();
            this.CategoryRadioButton = new System.Windows.Forms.RadioButton();
            this.ModelRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.списокКлиентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокКлиентовToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.каталогАвтомобилейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрацияКлиентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.моделиАвтоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.категорииАвтоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оформитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выдачуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.возвратToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            SearchButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            SearchButton.Location = new System.Drawing.Point(453, 49);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new System.Drawing.Size(125, 30);
            SearchButton.TabIndex = 28;
            SearchButton.Text = "Поиск";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
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
            this.OpenInfoButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.43382F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.56618F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 101);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 120);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(19, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 99);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.PapayaWhip;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.LeaseSumTextBox, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SumLeaseLabel, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox6, 1, 2);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(204, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(430, 112);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // LeaseSumTextBox
            // 
            this.LeaseSumTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LeaseSumTextBox.Enabled = false;
            this.LeaseSumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeaseSumTextBox.Location = new System.Drawing.Point(325, 44);
            this.LeaseSumTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LeaseSumTextBox.Name = "LeaseSumTextBox";
            this.LeaseSumTextBox.Size = new System.Drawing.Size(101, 22);
            this.LeaseSumTextBox.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Модель";
            // 
            // SumLeaseLabel
            // 
            this.SumLeaseLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SumLeaseLabel.AutoSize = true;
            this.SumLeaseLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumLeaseLabel.Location = new System.Drawing.Point(237, 38);
            this.SumLeaseLabel.Name = "SumLeaseLabel";
            this.SumLeaseLabel.Size = new System.Drawing.Size(60, 34);
            this.SumLeaseLabel.TabIndex = 34;
            this.SumLeaseLabel.Text = "Сумма аренды";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Страна";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(225, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Кол-во авто";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(110, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(325, 7);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(110, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(16, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Категория";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(110, 82);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 11;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.OpenAllButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.OpenInfoButton, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(641, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(113, 112);
            this.tableLayoutPanel3.TabIndex = 2;
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
            // IDRadioButton
            // 
            this.IDRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IDRadioButton.AutoSize = true;
            this.IDRadioButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDRadioButton.Location = new System.Drawing.Point(292, 74);
            this.IDRadioButton.Name = "IDRadioButton";
            this.IDRadioButton.Size = new System.Drawing.Size(54, 20);
            this.IDRadioButton.TabIndex = 32;
            this.IDRadioButton.TabStop = true;
            this.IDRadioButton.Text = "по ID";
            this.IDRadioButton.UseVisualStyleBackColor = true;
            this.IDRadioButton.CheckedChanged += new System.EventHandler(this.IDRadioButton_CheckedChanged);
            // 
            // CategoryRadioButton
            // 
            this.CategoryRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CategoryRadioButton.AutoSize = true;
            this.CategoryRadioButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryRadioButton.Location = new System.Drawing.Point(170, 74);
            this.CategoryRadioButton.Name = "CategoryRadioButton";
            this.CategoryRadioButton.Size = new System.Drawing.Size(101, 20);
            this.CategoryRadioButton.TabIndex = 31;
            this.CategoryRadioButton.TabStop = true;
            this.CategoryRadioButton.Text = "по категории";
            this.CategoryRadioButton.UseVisualStyleBackColor = true;
            this.CategoryRadioButton.CheckedChanged += new System.EventHandler(this.CategoryRadioButton_CheckedChanged);
            // 
            // ModelRadioButton
            // 
            this.ModelRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ModelRadioButton.AutoSize = true;
            this.ModelRadioButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelRadioButton.Location = new System.Drawing.Point(67, 74);
            this.ModelRadioButton.Name = "ModelRadioButton";
            this.ModelRadioButton.Size = new System.Drawing.Size(87, 20);
            this.ModelRadioButton.TabIndex = 30;
            this.ModelRadioButton.TabStop = true;
            this.ModelRadioButton.Text = "по модели";
            this.ModelRadioButton.UseVisualStyleBackColor = true;
            this.ModelRadioButton.CheckedChanged += new System.EventHandler(this.ModelRadioButton_CheckedChanged);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchTextBox.Location = new System.Drawing.Point(24, 49);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(423, 20);
            this.SearchTextBox.TabIndex = 29;
            this.SearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTextBox_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокКлиентовToolStripMenuItem,
            this.регистрацияКлиентаToolStripMenuItem,
            this.оформитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.регистрацияКлиентаToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 38);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // списокКлиентовToolStripMenuItem
            // 
            this.списокКлиентовToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокКлиентовToolStripMenuItem1,
            this.каталогАвтомобилейToolStripMenuItem});
            this.списокКлиентовToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.списокКлиентовToolStripMenuItem.Name = "списокКлиентовToolStripMenuItem";
            this.списокКлиентовToolStripMenuItem.Size = new System.Drawing.Size(68, 34);
            this.списокКлиентовToolStripMenuItem.Text = "Открыть";
            // 
            // списокКлиентовToolStripMenuItem1
            // 
            this.списокКлиентовToolStripMenuItem1.Name = "списокКлиентовToolStripMenuItem1";
            this.списокКлиентовToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.списокКлиентовToolStripMenuItem1.Text = "Список клиентов";
            // 
            // каталогАвтомобилейToolStripMenuItem
            // 
            this.каталогАвтомобилейToolStripMenuItem.Name = "каталогАвтомобилейToolStripMenuItem";
            this.каталогАвтомобилейToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.каталогАвтомобилейToolStripMenuItem.Text = "Каталог автомобилей";
            // 
            // регистрацияКлиентаToolStripMenuItem
            // 
            this.регистрацияКлиентаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентаToolStripMenuItem,
            this.моделиАвтоToolStripMenuItem,
            this.категорииАвтоToolStripMenuItem});
            this.регистрацияКлиентаToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.регистрацияКлиентаToolStripMenuItem.Name = "регистрацияКлиентаToolStripMenuItem";
            this.регистрацияКлиентаToolStripMenuItem.Size = new System.Drawing.Size(96, 34);
            this.регистрацияКлиентаToolStripMenuItem.Text = "Регистрация";
            // 
            // клиентаToolStripMenuItem
            // 
            this.клиентаToolStripMenuItem.Name = "клиентаToolStripMenuItem";
            this.клиентаToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.клиентаToolStripMenuItem.Text = "Клиента";
            // 
            // моделиАвтоToolStripMenuItem
            // 
            this.моделиАвтоToolStripMenuItem.Name = "моделиАвтоToolStripMenuItem";
            this.моделиАвтоToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.моделиАвтоToolStripMenuItem.Text = "Модели авто";
            // 
            // категорииАвтоToolStripMenuItem
            // 
            this.категорииАвтоToolStripMenuItem.Name = "категорииАвтоToolStripMenuItem";
            this.категорииАвтоToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.категорииАвтоToolStripMenuItem.Text = "Категории авто";
            // 
            // оформитьToolStripMenuItem
            // 
            this.оформитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выдачуToolStripMenuItem,
            this.возвратToolStripMenuItem});
            this.оформитьToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.оформитьToolStripMenuItem.Name = "оформитьToolStripMenuItem";
            this.оформитьToolStripMenuItem.Size = new System.Drawing.Size(88, 34);
            this.оформитьToolStripMenuItem.Text = "Оформить";
            // 
            // выдачуToolStripMenuItem
            // 
            this.выдачуToolStripMenuItem.Name = "выдачуToolStripMenuItem";
            this.выдачуToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.выдачуToolStripMenuItem.Text = "Выдачу";
            // 
            // возвратToolStripMenuItem
            // 
            this.возвратToolStripMenuItem.Name = "возвратToolStripMenuItem";
            this.возвратToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.возвратToolStripMenuItem.Text = "Возврат";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.toolStripLabel2,
            this.toolStripTextBox2,
            this.toolStripTextBox3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 436);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(804, 25);
            this.toolStrip1.TabIndex = 43;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(58, 22);
            this.toolStripLabel1.Text = "Клиенты:";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Enabled = false;
            this.toolStripTextBox1.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(80, 22);
            this.toolStripLabel2.Text = "Автомобили:";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Enabled = false;
            this.toolStripTextBox2.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 23);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox3.Enabled = false;
            this.toolStripTextBox3.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 23);
            // 
            // AutoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(20, 20);
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.IDRadioButton);
            this.Controls.Add(this.CategoryRadioButton);
            this.Controls.Add(this.ModelRadioButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(SearchButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AutoList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каталог автомобилей";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AutoList_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenInfoButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.RadioButton IDRadioButton;
        private System.Windows.Forms.RadioButton CategoryRadioButton;
        private System.Windows.Forms.RadioButton ModelRadioButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button OpenAllButton;
        private System.Windows.Forms.TextBox LeaseSumTextBox;
        private System.Windows.Forms.Label SumLeaseLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem регистрацияКлиентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокКлиентовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem моделиАвтоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem категорииАвтоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокКлиентовToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem каталогАвтомобилейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оформитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выдачуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem возвратToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
    }
}