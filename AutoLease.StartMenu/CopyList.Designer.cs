namespace AutoLease.StartMenu
{
    partial class CopyList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyList));
            this.copyListTable = new System.Windows.Forms.TableLayoutPanel();
            this.AddButton1 = new System.Windows.Forms.Button();
            this.copyInfoTable = new System.Windows.Forms.TableLayoutPanel();
            this.YearLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.EnableLabel = new System.Windows.Forms.Label();
            this.MileageLabel = new System.Windows.Forms.Label();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.MileageTextBox = new System.Windows.Forms.TextBox();
            this.EnableCheckBox = new System.Windows.Forms.CheckBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
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
            this.списокКлиентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LeaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyListTable.SuspendLayout();
            this.copyInfoTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.StatusToolStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // copyListTable
            // 
            this.copyListTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copyListTable.BackColor = System.Drawing.Color.PapayaWhip;
            this.copyListTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.copyListTable.ColumnCount = 3;
            this.copyListTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.57997F));
            this.copyListTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.42004F));
            this.copyListTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.copyListTable.Controls.Add(this.AddButton1, 2, 0);
            this.copyListTable.Controls.Add(this.copyInfoTable, 1, 0);
            this.copyListTable.Controls.Add(this.PhotoPictureBox, 0, 0);
            this.copyListTable.Location = new System.Drawing.Point(12, 92);
            this.copyListTable.Name = "copyListTable";
            this.copyListTable.RowCount = 1;
            this.copyListTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.copyListTable.Size = new System.Drawing.Size(690, 174);
            this.copyListTable.TabIndex = 0;
            // 
            // AddButton1
            // 
            this.AddButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddButton1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AddButton1.Enabled = false;
            this.AddButton1.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AddButton1.FlatAppearance.BorderSize = 2;
            this.AddButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton1.Location = new System.Drawing.Point(556, 60);
            this.AddButton1.Name = "AddButton1";
            this.AddButton1.Size = new System.Drawing.Size(120, 53);
            this.AddButton1.TabIndex = 1;
            this.AddButton1.Text = "Оформить выдачу";
            this.AddButton1.UseVisualStyleBackColor = false;
            this.AddButton1.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // copyInfoTable
            // 
            this.copyInfoTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copyInfoTable.ColumnCount = 2;
            this.copyInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.copyInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.copyInfoTable.Controls.Add(this.YearLabel, 0, 0);
            this.copyInfoTable.Controls.Add(this.ColorLabel, 0, 1);
            this.copyInfoTable.Controls.Add(this.EnableLabel, 0, 2);
            this.copyInfoTable.Controls.Add(this.MileageLabel, 0, 3);
            this.copyInfoTable.Controls.Add(this.YearTextBox, 1, 0);
            this.copyInfoTable.Controls.Add(this.ColorTextBox, 1, 1);
            this.copyInfoTable.Controls.Add(this.MileageTextBox, 1, 3);
            this.copyInfoTable.Controls.Add(this.EnableCheckBox, 1, 2);
            this.copyInfoTable.Controls.Add(this.IDLabel, 0, 4);
            this.copyInfoTable.Controls.Add(this.IDTextBox, 1, 4);
            this.copyInfoTable.Location = new System.Drawing.Point(170, 4);
            this.copyInfoTable.Name = "copyInfoTable";
            this.copyInfoTable.RowCount = 5;
            this.copyInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.copyInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.copyInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.copyInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.copyInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.copyInfoTable.Size = new System.Drawing.Size(370, 166);
            this.copyInfoTable.TabIndex = 0;
            // 
            // YearLabel
            // 
            this.YearLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.YearLabel.AutoSize = true;
            this.YearLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearLabel.Location = new System.Drawing.Point(42, 6);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(101, 20);
            this.YearLabel.TabIndex = 0;
            this.YearLabel.Text = "Год выпуска";
            // 
            // ColorLabel
            // 
            this.ColorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorLabel.Location = new System.Drawing.Point(71, 39);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(43, 20);
            this.ColorLabel.TabIndex = 1;
            this.ColorLabel.Text = "Цвет";
            // 
            // EnableLabel
            // 
            this.EnableLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnableLabel.AutoSize = true;
            this.EnableLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnableLabel.Location = new System.Drawing.Point(51, 72);
            this.EnableLabel.Name = "EnableLabel";
            this.EnableLabel.Size = new System.Drawing.Size(82, 20);
            this.EnableLabel.TabIndex = 2;
            this.EnableLabel.Text = "Доступна";
            // 
            // MileageLabel
            // 
            this.MileageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MileageLabel.AutoSize = true;
            this.MileageLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MileageLabel.Location = new System.Drawing.Point(60, 105);
            this.MileageLabel.Name = "MileageLabel";
            this.MileageLabel.Size = new System.Drawing.Size(64, 20);
            this.MileageLabel.TabIndex = 3;
            this.MileageLabel.Text = "Пробег";
            // 
            // YearTextBox
            // 
            this.YearTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.YearTextBox.Enabled = false;
            this.YearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearTextBox.Location = new System.Drawing.Point(211, 5);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(132, 22);
            this.YearTextBox.TabIndex = 4;
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ColorTextBox.Enabled = false;
            this.ColorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorTextBox.Location = new System.Drawing.Point(211, 38);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(132, 22);
            this.ColorTextBox.TabIndex = 5;
            // 
            // MileageTextBox
            // 
            this.MileageTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MileageTextBox.Enabled = false;
            this.MileageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MileageTextBox.Location = new System.Drawing.Point(211, 104);
            this.MileageTextBox.Name = "MileageTextBox";
            this.MileageTextBox.Size = new System.Drawing.Size(132, 22);
            this.MileageTextBox.TabIndex = 7;
            // 
            // EnableCheckBox
            // 
            this.EnableCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnableCheckBox.AutoSize = true;
            this.EnableCheckBox.Enabled = false;
            this.EnableCheckBox.Location = new System.Drawing.Point(270, 75);
            this.EnableCheckBox.Name = "EnableCheckBox";
            this.EnableCheckBox.Size = new System.Drawing.Size(15, 14);
            this.EnableCheckBox.TabIndex = 8;
            this.EnableCheckBox.UseVisualStyleBackColor = true;
            // 
            // IDLabel
            // 
            this.IDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDLabel.Location = new System.Drawing.Point(80, 139);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(25, 20);
            this.IDLabel.TabIndex = 9;
            this.IDLabel.Text = "ID";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDTextBox.Enabled = false;
            this.IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDTextBox.Location = new System.Drawing.Point(211, 138);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(132, 22);
            this.IDTextBox.TabIndex = 10;
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PhotoPictureBox.Enabled = false;
            this.PhotoPictureBox.Location = new System.Drawing.Point(5, 24);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(156, 125);
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
            this.AddNewButton.Location = new System.Drawing.Point(502, 41);
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
            this.StatusToolStrip.Location = new System.Drawing.Point(0, 406);
            this.StatusToolStrip.Name = "StatusToolStrip";
            this.StatusToolStrip.Size = new System.Drawing.Size(714, 25);
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
            this.списокКлиентовToolStripMenuItem,
            this.RegistrationToolStripMenuItem,
            this.FormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.RegistrationToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(714, 38);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // списокКлиентовToolStripMenuItem
            // 
            this.списокКлиентовToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientListToolStripMenuItem1,
            this.AutoListToolStripMenuItem});
            this.списокКлиентовToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.списокКлиентовToolStripMenuItem.Name = "списокКлиентовToolStripMenuItem";
            this.списокКлиентовToolStripMenuItem.Size = new System.Drawing.Size(68, 34);
            this.списокКлиентовToolStripMenuItem.Text = "Открыть";
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
            this.LeaseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.LeaseToolStripMenuItem.Text = "Выдачу";
            this.LeaseToolStripMenuItem.Click += new System.EventHandler(this.LeaseToolStripMenuItem_Click);
            // 
            // ReturnToolStripMenuItem
            // 
            this.ReturnToolStripMenuItem.Name = "ReturnToolStripMenuItem";
            this.ReturnToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ReturnToolStripMenuItem.Text = "Возврат";
            this.ReturnToolStripMenuItem.Click += new System.EventHandler(this.ReturnToolStripMenuItem_Click);
            // 
            // CopyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(714, 431);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.StatusToolStrip);
            this.Controls.Add(this.AddNewButton);
            this.Controls.Add(this.copyListTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CopyList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список копий автомобиля";
            this.Activated += new System.EventHandler(this.CopyList_Activated);
            this.copyListTable.ResumeLayout(false);
            this.copyInfoTable.ResumeLayout(false);
            this.copyInfoTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.StatusToolStrip.ResumeLayout(false);
            this.StatusToolStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel copyListTable;
        private System.Windows.Forms.TableLayoutPanel copyInfoTable;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label EnableLabel;
        private System.Windows.Forms.Label MileageLabel;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.TextBox MileageTextBox;
        private System.Windows.Forms.CheckBox EnableCheckBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.PictureBox PhotoPictureBox;
        private System.Windows.Forms.Button AddButton1;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.ToolStrip StatusToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox ClientsToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox AutoToolStripTextBox;
        private System.Windows.Forms.ToolStripTextBox DateToolStripTextBox;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem списокКлиентовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientListToolStripMenuItem1;
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