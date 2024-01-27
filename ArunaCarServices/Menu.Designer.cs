namespace ArunaCarServices
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.tab_bakımAraclar = new System.Windows.Forms.TabControl();
            this.tab_users = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.refreshbox_users = new System.Windows.Forms.PictureBox();
            this.filter_users = new System.Windows.Forms.Button();
            this.txtFilter_users = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataUser = new System.Windows.Forms.DataGridView();
            this.tab_owners = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.refreshbox_customer = new System.Windows.Forms.PictureBox();
            this.filter_customer = new System.Windows.Forms.Button();
            this.txtFilter_customer = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.data_customers = new System.Windows.Forms.DataGridView();
            this.tab_cars = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.refreshbox_car = new System.Windows.Forms.PictureBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.filter = new System.Windows.Forms.Button();
            this.dataCar = new System.Windows.Forms.DataGridView();
            this.tab_maintenance = new System.Windows.Forms.TabPage();
            this.menu_take_care = new System.Windows.Forms.Button();
            this.btnGetMaintenanceInfo = new System.Windows.Forms.Button();
            this.txtPlakaNumarasi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_maintenance = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataMaintenance = new System.Windows.Forms.DataGridView();
            this.tabBakımAraclar = new System.Windows.Forms.TabPage();
            this.refresh_maintenance = new System.Windows.Forms.PictureBox();
            this.maintenanceData = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.past_picturebox = new System.Windows.Forms.PictureBox();
            this.Final_search = new System.Windows.Forms.Button();
            this.txt_past_filter = new System.Windows.Forms.TextBox();
            this.past_datagridview = new System.Windows.Forms.DataGridView();
            this.tab_bakımAraclar.SuspendLayout();
            this.tab_users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshbox_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).BeginInit();
            this.tab_owners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshbox_customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_customers)).BeginInit();
            this.tab_cars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshbox_car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCar)).BeginInit();
            this.tab_maintenance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMaintenance)).BeginInit();
            this.tabBakımAraclar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh_maintenance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceData)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.past_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.past_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_bakımAraclar
            // 
            this.tab_bakımAraclar.Controls.Add(this.tab_users);
            this.tab_bakımAraclar.Controls.Add(this.tab_owners);
            this.tab_bakımAraclar.Controls.Add(this.tab_cars);
            this.tab_bakımAraclar.Controls.Add(this.tab_maintenance);
            this.tab_bakımAraclar.Controls.Add(this.tabBakımAraclar);
            this.tab_bakımAraclar.Controls.Add(this.tabPage1);
            this.tab_bakımAraclar.Location = new System.Drawing.Point(12, 12);
            this.tab_bakımAraclar.Name = "tab_bakımAraclar";
            this.tab_bakımAraclar.SelectedIndex = 0;
            this.tab_bakımAraclar.Size = new System.Drawing.Size(1673, 985);
            this.tab_bakımAraclar.TabIndex = 0;
            this.tab_bakımAraclar.Tag = "";
            // 
            // tab_users
            // 
            this.tab_users.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tab_users.Controls.Add(this.label3);
            this.tab_users.Controls.Add(this.refreshbox_users);
            this.tab_users.Controls.Add(this.filter_users);
            this.tab_users.Controls.Add(this.txtFilter_users);
            this.tab_users.Controls.Add(this.button1);
            this.tab_users.Controls.Add(this.dataUser);
            this.tab_users.Location = new System.Drawing.Point(4, 29);
            this.tab_users.Name = "tab_users";
            this.tab_users.Padding = new System.Windows.Forms.Padding(3);
            this.tab_users.Size = new System.Drawing.Size(1665, 952);
            this.tab_users.TabIndex = 0;
            this.tab_users.Text = "Kullanıcılar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kullanıcı Adı Giriniz :";
            // 
            // refreshbox_users
            // 
            this.refreshbox_users.Image = ((System.Drawing.Image)(resources.GetObject("refreshbox_users.Image")));
            this.refreshbox_users.Location = new System.Drawing.Point(427, 26);
            this.refreshbox_users.Name = "refreshbox_users";
            this.refreshbox_users.Size = new System.Drawing.Size(71, 69);
            this.refreshbox_users.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshbox_users.TabIndex = 8;
            this.refreshbox_users.TabStop = false;
            this.refreshbox_users.Click += new System.EventHandler(this.refreshbox_users_Click);
            // 
            // filter_users
            // 
            this.filter_users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.filter_users.Location = new System.Drawing.Point(241, 61);
            this.filter_users.Name = "filter_users";
            this.filter_users.Size = new System.Drawing.Size(180, 34);
            this.filter_users.TabIndex = 7;
            this.filter_users.Text = "Ara";
            this.filter_users.UseVisualStyleBackColor = false;
            this.filter_users.Click += new System.EventHandler(this.filter_users_Click);
            // 
            // txtFilter_users
            // 
            this.txtFilter_users.Location = new System.Drawing.Point(241, 26);
            this.txtFilter_users.Name = "txtFilter_users";
            this.txtFilter_users.Size = new System.Drawing.Size(180, 26);
            this.txtFilter_users.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(917, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Personel Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Add_Customer_Click);
            // 
            // dataUser
            // 
            this.dataUser.BackgroundColor = System.Drawing.Color.White;
            this.dataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUser.Location = new System.Drawing.Point(16, 118);
            this.dataUser.Name = "dataUser";
            this.dataUser.RowHeadersWidth = 62;
            this.dataUser.RowTemplate.Height = 28;
            this.dataUser.Size = new System.Drawing.Size(1643, 828);
            this.dataUser.TabIndex = 0;
            // 
            // tab_owners
            // 
            this.tab_owners.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tab_owners.Controls.Add(this.label5);
            this.tab_owners.Controls.Add(this.refreshbox_customer);
            this.tab_owners.Controls.Add(this.filter_customer);
            this.tab_owners.Controls.Add(this.txtFilter_customer);
            this.tab_owners.Controls.Add(this.button2);
            this.tab_owners.Controls.Add(this.data_customers);
            this.tab_owners.Location = new System.Drawing.Point(4, 29);
            this.tab_owners.Name = "tab_owners";
            this.tab_owners.Padding = new System.Windows.Forms.Padding(3);
            this.tab_owners.Size = new System.Drawing.Size(1665, 952);
            this.tab_owners.TabIndex = 1;
            this.tab_owners.Text = "Müşteriler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefon Numarası Giriniz :";
            // 
            // refreshbox_customer
            // 
            this.refreshbox_customer.Image = ((System.Drawing.Image)(resources.GetObject("refreshbox_customer.Image")));
            this.refreshbox_customer.Location = new System.Drawing.Point(448, 48);
            this.refreshbox_customer.Name = "refreshbox_customer";
            this.refreshbox_customer.Size = new System.Drawing.Size(71, 66);
            this.refreshbox_customer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshbox_customer.TabIndex = 9;
            this.refreshbox_customer.TabStop = false;
            this.refreshbox_customer.Click += new System.EventHandler(this.refreshbox_customer_Click);
            // 
            // filter_customer
            // 
            this.filter_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.filter_customer.Location = new System.Drawing.Point(229, 80);
            this.filter_customer.Name = "filter_customer";
            this.filter_customer.Size = new System.Drawing.Size(199, 34);
            this.filter_customer.TabIndex = 8;
            this.filter_customer.Text = "Ara";
            this.filter_customer.UseVisualStyleBackColor = false;
            this.filter_customer.Click += new System.EventHandler(this.filter_customer_Click);
            // 
            // txtFilter_customer
            // 
            this.txtFilter_customer.Location = new System.Drawing.Point(229, 48);
            this.txtFilter_customer.Name = "txtFilter_customer";
            this.txtFilter_customer.Size = new System.Drawing.Size(199, 26);
            this.txtFilter_customer.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(880, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Müşteri Ekle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // data_customers
            // 
            this.data_customers.BackgroundColor = System.Drawing.Color.White;
            this.data_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_customers.Location = new System.Drawing.Point(26, 143);
            this.data_customers.Name = "data_customers";
            this.data_customers.RowHeadersWidth = 62;
            this.data_customers.RowTemplate.Height = 28;
            this.data_customers.Size = new System.Drawing.Size(1633, 803);
            this.data_customers.TabIndex = 0;
            // 
            // tab_cars
            // 
            this.tab_cars.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tab_cars.Controls.Add(this.label4);
            this.tab_cars.Controls.Add(this.refreshbox_car);
            this.tab_cars.Controls.Add(this.txtFilter);
            this.tab_cars.Controls.Add(this.filter);
            this.tab_cars.Controls.Add(this.dataCar);
            this.tab_cars.Location = new System.Drawing.Point(4, 29);
            this.tab_cars.Name = "tab_cars";
            this.tab_cars.Padding = new System.Windows.Forms.Padding(3);
            this.tab_cars.Size = new System.Drawing.Size(1665, 952);
            this.tab_cars.TabIndex = 2;
            this.tab_cars.Text = "Arabalar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Plaka Giriniz :";
            // 
            // refreshbox_car
            // 
            this.refreshbox_car.Image = ((System.Drawing.Image)(resources.GetObject("refreshbox_car.Image")));
            this.refreshbox_car.Location = new System.Drawing.Point(323, 36);
            this.refreshbox_car.Name = "refreshbox_car";
            this.refreshbox_car.Size = new System.Drawing.Size(71, 66);
            this.refreshbox_car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshbox_car.TabIndex = 7;
            this.refreshbox_car.TabStop = false;
            this.refreshbox_car.Click += new System.EventHandler(this.refreshbox_car_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(137, 36);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(180, 26);
            this.txtFilter.TabIndex = 5;
            // 
            // filter
            // 
            this.filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.filter.Location = new System.Drawing.Point(137, 68);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(180, 34);
            this.filter.TabIndex = 4;
            this.filter.Text = "Ara";
            this.filter.UseVisualStyleBackColor = false;
            this.filter.Click += new System.EventHandler(this.filter_Click_1);
            // 
            // dataCar
            // 
            this.dataCar.BackgroundColor = System.Drawing.Color.White;
            this.dataCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCar.Location = new System.Drawing.Point(20, 122);
            this.dataCar.Name = "dataCar";
            this.dataCar.RowHeadersWidth = 62;
            this.dataCar.RowTemplate.Height = 28;
            this.dataCar.Size = new System.Drawing.Size(1639, 824);
            this.dataCar.TabIndex = 0;
            // 
            // tab_maintenance
            // 
            this.tab_maintenance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tab_maintenance.Controls.Add(this.menu_take_care);
            this.tab_maintenance.Controls.Add(this.btnGetMaintenanceInfo);
            this.tab_maintenance.Controls.Add(this.txtPlakaNumarasi);
            this.tab_maintenance.Controls.Add(this.label2);
            this.tab_maintenance.Controls.Add(this.comboBox_maintenance);
            this.tab_maintenance.Controls.Add(this.label1);
            this.tab_maintenance.Controls.Add(this.dataMaintenance);
            this.tab_maintenance.ForeColor = System.Drawing.Color.IndianRed;
            this.tab_maintenance.Location = new System.Drawing.Point(4, 29);
            this.tab_maintenance.Name = "tab_maintenance";
            this.tab_maintenance.Padding = new System.Windows.Forms.Padding(3);
            this.tab_maintenance.Size = new System.Drawing.Size(1665, 952);
            this.tab_maintenance.TabIndex = 3;
            this.tab_maintenance.Text = "Bakım Listeleri";
            // 
            // menu_take_care
            // 
            this.menu_take_care.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menu_take_care.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menu_take_care.ForeColor = System.Drawing.Color.Black;
            this.menu_take_care.Location = new System.Drawing.Point(1302, 878);
            this.menu_take_care.Name = "menu_take_care";
            this.menu_take_care.Size = new System.Drawing.Size(336, 53);
            this.menu_take_care.TabIndex = 7;
            this.menu_take_care.Text = "Aracı Bakıma Al";
            this.menu_take_care.UseVisualStyleBackColor = false;
            this.menu_take_care.Click += new System.EventHandler(this.menu_take_care_Click_1);
            // 
            // btnGetMaintenanceInfo
            // 
            this.btnGetMaintenanceInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnGetMaintenanceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetMaintenanceInfo.ForeColor = System.Drawing.Color.Black;
            this.btnGetMaintenanceInfo.Location = new System.Drawing.Point(883, 72);
            this.btnGetMaintenanceInfo.Name = "btnGetMaintenanceInfo";
            this.btnGetMaintenanceInfo.Size = new System.Drawing.Size(225, 40);
            this.btnGetMaintenanceInfo.TabIndex = 6;
            this.btnGetMaintenanceInfo.Text = "Bul";
            this.btnGetMaintenanceInfo.UseVisualStyleBackColor = false;
            this.btnGetMaintenanceInfo.Click += new System.EventHandler(this.btnGetMaintenanceInfo_Click);
            // 
            // txtPlakaNumarasi
            // 
            this.txtPlakaNumarasi.Location = new System.Drawing.Point(199, 79);
            this.txtPlakaNumarasi.Name = "txtPlakaNumarasi";
            this.txtPlakaNumarasi.Size = new System.Drawing.Size(213, 26);
            this.txtPlakaNumarasi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(444, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bakım Seçiniz :";
            // 
            // comboBox_maintenance
            // 
            this.comboBox_maintenance.FormattingEnabled = true;
            this.comboBox_maintenance.Location = new System.Drawing.Point(593, 77);
            this.comboBox_maintenance.Name = "comboBox_maintenance";
            this.comboBox_maintenance.Size = new System.Drawing.Size(225, 28);
            this.comboBox_maintenance.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(64, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plaka Giriniz :";
            // 
            // dataMaintenance
            // 
            this.dataMaintenance.BackgroundColor = System.Drawing.Color.White;
            this.dataMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMaintenance.Location = new System.Drawing.Point(38, 134);
            this.dataMaintenance.Name = "dataMaintenance";
            this.dataMaintenance.RowHeadersWidth = 62;
            this.dataMaintenance.RowTemplate.Height = 28;
            this.dataMaintenance.Size = new System.Drawing.Size(1600, 726);
            this.dataMaintenance.TabIndex = 0;
            // 
            // tabBakımAraclar
            // 
            this.tabBakımAraclar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabBakımAraclar.Controls.Add(this.refresh_maintenance);
            this.tabBakımAraclar.Controls.Add(this.maintenanceData);
            this.tabBakımAraclar.Location = new System.Drawing.Point(4, 29);
            this.tabBakımAraclar.Name = "tabBakımAraclar";
            this.tabBakımAraclar.Padding = new System.Windows.Forms.Padding(3);
            this.tabBakımAraclar.Size = new System.Drawing.Size(1665, 952);
            this.tabBakımAraclar.TabIndex = 4;
            this.tabBakımAraclar.Text = "Bakımda Olan Araçlar";
            // 
            // refresh_maintenance
            // 
            this.refresh_maintenance.Image = ((System.Drawing.Image)(resources.GetObject("refresh_maintenance.Image")));
            this.refresh_maintenance.Location = new System.Drawing.Point(1218, 27);
            this.refresh_maintenance.Name = "refresh_maintenance";
            this.refresh_maintenance.Size = new System.Drawing.Size(71, 66);
            this.refresh_maintenance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refresh_maintenance.TabIndex = 8;
            this.refresh_maintenance.TabStop = false;
            this.refresh_maintenance.Click += new System.EventHandler(this.refresh_maintenance_Click);
            // 
            // maintenanceData
            // 
            this.maintenanceData.BackgroundColor = System.Drawing.Color.White;
            this.maintenanceData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maintenanceData.Location = new System.Drawing.Point(6, 130);
            this.maintenanceData.Name = "maintenanceData";
            this.maintenanceData.RowHeadersWidth = 62;
            this.maintenanceData.RowTemplate.Height = 28;
            this.maintenanceData.Size = new System.Drawing.Size(1653, 816);
            this.maintenanceData.TabIndex = 0;
            this.maintenanceData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.maintenanceData_CellContentClick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.past_picturebox);
            this.tabPage1.Controls.Add(this.Final_search);
            this.tabPage1.Controls.Add(this.txt_past_filter);
            this.tabPage1.Controls.Add(this.past_datagridview);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1665, 952);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Bakım Yapılan Araçlar";
            // 
            // past_picturebox
            // 
            this.past_picturebox.Image = ((System.Drawing.Image)(resources.GetObject("past_picturebox.Image")));
            this.past_picturebox.Location = new System.Drawing.Point(370, 41);
            this.past_picturebox.Name = "past_picturebox";
            this.past_picturebox.Size = new System.Drawing.Size(71, 66);
            this.past_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.past_picturebox.TabIndex = 8;
            this.past_picturebox.TabStop = false;
            this.past_picturebox.Click += new System.EventHandler(this.past_picturebox_Click);
            // 
            // Final_search
            // 
            this.Final_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Final_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Final_search.Location = new System.Drawing.Point(131, 73);
            this.Final_search.Name = "Final_search";
            this.Final_search.Size = new System.Drawing.Size(219, 39);
            this.Final_search.TabIndex = 2;
            this.Final_search.Text = "ARA";
            this.Final_search.UseVisualStyleBackColor = false;
            this.Final_search.Click += new System.EventHandler(this.Final_search_Click);
            // 
            // txt_past_filter
            // 
            this.txt_past_filter.Location = new System.Drawing.Point(131, 41);
            this.txt_past_filter.Name = "txt_past_filter";
            this.txt_past_filter.Size = new System.Drawing.Size(219, 26);
            this.txt_past_filter.TabIndex = 1;
            // 
            // past_datagridview
            // 
            this.past_datagridview.BackgroundColor = System.Drawing.Color.White;
            this.past_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.past_datagridview.Location = new System.Drawing.Point(6, 131);
            this.past_datagridview.Name = "past_datagridview";
            this.past_datagridview.RowHeadersWidth = 62;
            this.past_datagridview.RowTemplate.Height = 28;
            this.past_datagridview.Size = new System.Drawing.Size(1653, 815);
            this.past_datagridview.TabIndex = 0;
            this.past_datagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Final_datagridview_CellContentClick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1697, 1009);
            this.Controls.Add(this.tab_bakımAraclar);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tab_bakımAraclar.ResumeLayout(false);
            this.tab_users.ResumeLayout(false);
            this.tab_users.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshbox_users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).EndInit();
            this.tab_owners.ResumeLayout(false);
            this.tab_owners.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshbox_customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_customers)).EndInit();
            this.tab_cars.ResumeLayout(false);
            this.tab_cars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshbox_car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCar)).EndInit();
            this.tab_maintenance.ResumeLayout(false);
            this.tab_maintenance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMaintenance)).EndInit();
            this.tabBakımAraclar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.refresh_maintenance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceData)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.past_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.past_datagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_bakımAraclar;
        private System.Windows.Forms.TabPage tab_users;
        private System.Windows.Forms.TabPage tab_owners;
        private System.Windows.Forms.TabPage tab_cars;
        private System.Windows.Forms.DataGridView dataUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tab_maintenance;
        private System.Windows.Forms.DataGridView data_customers;
        private System.Windows.Forms.DataGridView dataCar;
        private System.Windows.Forms.DataGridView dataMaintenance;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button filter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_maintenance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlakaNumarasi;
        private System.Windows.Forms.TabPage tabBakımAraclar;
        private System.Windows.Forms.PictureBox refreshbox_car;
        private System.Windows.Forms.PictureBox refreshbox_users;
        private System.Windows.Forms.Button filter_users;
        private System.Windows.Forms.TextBox txtFilter_users;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGetMaintenanceInfo;
        private System.Windows.Forms.Button menu_take_care;
        private System.Windows.Forms.PictureBox refreshbox_customer;
        private System.Windows.Forms.Button filter_customer;
        private System.Windows.Forms.TextBox txtFilter_customer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView maintenanceData;
        private System.Windows.Forms.PictureBox refresh_maintenance;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox past_picturebox;
        private System.Windows.Forms.Button Final_search;
        private System.Windows.Forms.TextBox txt_past_filter;
        private System.Windows.Forms.DataGridView past_datagridview;
    }
}