namespace AlexisConstructionProject.Forms
{
    partial class FormAlexis
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tabControMain = new System.Windows.Forms.TabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.tabPageServices = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxTotalFee = new System.Windows.Forms.TextBox();
            this.textBoxRateperHour = new System.Windows.Forms.TextBox();
            this.textBoxFee = new System.Windows.Forms.TextBox();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.comboBoxServices = new System.Windows.Forms.ComboBox();
            this.labelTotalFee = new System.Windows.Forms.Label();
            this.labelRateperHour = new System.Windows.Forms.Label();
            this.labelFee = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelService = new System.Windows.Forms.Label();
            this.tabPageTransactionLogs = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPageInventory = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPageBilling = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPageBookingsLog = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabPageCustomerList = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.tabPageCustomerManagement = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textboxUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.tabControMain.SuspendLayout();
            this.tabPageServices.SuspendLayout();
            this.tabPageTransactionLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPageBilling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPageBookingsLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPageCustomerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.tabPageCustomerManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(937, 76);
            this.panelTop.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Calisto MT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(51, 24);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(383, 35);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Alexis Construction Services";
            // 
            // tabControMain
            // 
            this.tabControMain.Controls.Add(this.tabPageHome);
            this.tabControMain.Controls.Add(this.tabPageServices);
            this.tabControMain.Controls.Add(this.tabPageTransactionLogs);
            this.tabControMain.Controls.Add(this.tabPageInventory);
            this.tabControMain.Controls.Add(this.tabPageBilling);
            this.tabControMain.Controls.Add(this.tabPageBookingsLog);
            this.tabControMain.Controls.Add(this.tabPageCustomerList);
            this.tabControMain.Controls.Add(this.tabPageCustomerManagement);
            this.tabControMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControMain.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControMain.Location = new System.Drawing.Point(0, 76);
            this.tabControMain.Name = "tabControMain";
            this.tabControMain.SelectedIndex = 0;
            this.tabControMain.Size = new System.Drawing.Size(937, 481);
            this.tabControMain.TabIndex = 1;
            // 
            // tabPageHome
            // 
            this.tabPageHome.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageHome.Location = new System.Drawing.Point(4, 24);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHome.Size = new System.Drawing.Size(929, 453);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "Home";
            this.tabPageHome.UseVisualStyleBackColor = true;
            // 
            // tabPageServices
            // 
            this.tabPageServices.Controls.Add(this.button2);
            this.tabPageServices.Controls.Add(this.textBoxTotalFee);
            this.tabPageServices.Controls.Add(this.textBoxRateperHour);
            this.tabPageServices.Controls.Add(this.textBoxFee);
            this.tabPageServices.Controls.Add(this.textBoxDuration);
            this.tabPageServices.Controls.Add(this.comboBoxServices);
            this.tabPageServices.Controls.Add(this.labelTotalFee);
            this.tabPageServices.Controls.Add(this.labelRateperHour);
            this.tabPageServices.Controls.Add(this.labelFee);
            this.tabPageServices.Controls.Add(this.labelDuration);
            this.tabPageServices.Controls.Add(this.labelService);
            this.tabPageServices.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageServices.Location = new System.Drawing.Point(4, 24);
            this.tabPageServices.Name = "tabPageServices";
            this.tabPageServices.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageServices.Size = new System.Drawing.Size(929, 453);
            this.tabPageServices.TabIndex = 1;
            this.tabPageServices.Text = "Services";
            this.tabPageServices.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(613, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 27);
            this.button2.TabIndex = 22;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBoxTotalFee
            // 
            this.textBoxTotalFee.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalFee.Location = new System.Drawing.Point(530, 245);
            this.textBoxTotalFee.Name = "textBoxTotalFee";
            this.textBoxTotalFee.Size = new System.Drawing.Size(243, 26);
            this.textBoxTotalFee.TabIndex = 11;
            // 
            // textBoxRateperHour
            // 
            this.textBoxRateperHour.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRateperHour.Location = new System.Drawing.Point(530, 114);
            this.textBoxRateperHour.Name = "textBoxRateperHour";
            this.textBoxRateperHour.Size = new System.Drawing.Size(243, 26);
            this.textBoxRateperHour.TabIndex = 10;
            // 
            // textBoxFee
            // 
            this.textBoxFee.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFee.Location = new System.Drawing.Point(76, 368);
            this.textBoxFee.Name = "textBoxFee";
            this.textBoxFee.Size = new System.Drawing.Size(243, 26);
            this.textBoxFee.TabIndex = 9;
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDuration.Location = new System.Drawing.Point(76, 245);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(243, 26);
            this.textBoxDuration.TabIndex = 8;
            // 
            // comboBoxServices
            // 
            this.comboBoxServices.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxServices.FormattingEnabled = true;
            this.comboBoxServices.Location = new System.Drawing.Point(76, 113);
            this.comboBoxServices.Name = "comboBoxServices";
            this.comboBoxServices.Size = new System.Drawing.Size(243, 27);
            this.comboBoxServices.TabIndex = 7;
            // 
            // labelTotalFee
            // 
            this.labelTotalFee.AutoSize = true;
            this.labelTotalFee.Font = new System.Drawing.Font("Calisto MT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalFee.Location = new System.Drawing.Point(524, 191);
            this.labelTotalFee.Name = "labelTotalFee";
            this.labelTotalFee.Size = new System.Drawing.Size(138, 35);
            this.labelTotalFee.TabIndex = 6;
            this.labelTotalFee.Text = "Total Fee";
            // 
            // labelRateperHour
            // 
            this.labelRateperHour.AutoSize = true;
            this.labelRateperHour.Font = new System.Drawing.Font("Calisto MT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRateperHour.Location = new System.Drawing.Point(524, 61);
            this.labelRateperHour.Name = "labelRateperHour";
            this.labelRateperHour.Size = new System.Drawing.Size(200, 35);
            this.labelRateperHour.TabIndex = 5;
            this.labelRateperHour.Text = "Rate per Hour";
            // 
            // labelFee
            // 
            this.labelFee.AutoSize = true;
            this.labelFee.Font = new System.Drawing.Font("Calisto MT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFee.Location = new System.Drawing.Point(70, 318);
            this.labelFee.Name = "labelFee";
            this.labelFee.Size = new System.Drawing.Size(62, 35);
            this.labelFee.TabIndex = 4;
            this.labelFee.Text = "Fee";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("Calisto MT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuration.Location = new System.Drawing.Point(70, 191);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(132, 35);
            this.labelDuration.TabIndex = 3;
            this.labelDuration.Text = "Duration";
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Font = new System.Drawing.Font("Calisto MT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelService.Location = new System.Drawing.Point(70, 61);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(107, 35);
            this.labelService.TabIndex = 2;
            this.labelService.Text = "Service";
            // 
            // tabPageTransactionLogs
            // 
            this.tabPageTransactionLogs.Controls.Add(this.dataGridView1);
            this.tabPageTransactionLogs.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageTransactionLogs.Location = new System.Drawing.Point(4, 24);
            this.tabPageTransactionLogs.Name = "tabPageTransactionLogs";
            this.tabPageTransactionLogs.Size = new System.Drawing.Size(929, 453);
            this.tabPageTransactionLogs.TabIndex = 2;
            this.tabPageTransactionLogs.Text = "Transaction Logs";
            this.tabPageTransactionLogs.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 395);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPageInventory
            // 
            this.tabPageInventory.Controls.Add(this.dataGridView2);
            this.tabPageInventory.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageInventory.Location = new System.Drawing.Point(4, 24);
            this.tabPageInventory.Name = "tabPageInventory";
            this.tabPageInventory.Size = new System.Drawing.Size(929, 453);
            this.tabPageInventory.TabIndex = 3;
            this.tabPageInventory.Text = "Inventory";
            this.tabPageInventory.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(32, 30);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(705, 395);
            this.dataGridView2.TabIndex = 1;
            // 
            // tabPageBilling
            // 
            this.tabPageBilling.Controls.Add(this.dataGridView3);
            this.tabPageBilling.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageBilling.Location = new System.Drawing.Point(4, 24);
            this.tabPageBilling.Name = "tabPageBilling";
            this.tabPageBilling.Size = new System.Drawing.Size(929, 453);
            this.tabPageBilling.TabIndex = 4;
            this.tabPageBilling.Text = "Billing";
            this.tabPageBilling.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(32, 30);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(705, 395);
            this.dataGridView3.TabIndex = 1;
            // 
            // tabPageBookingsLog
            // 
            this.tabPageBookingsLog.Controls.Add(this.dataGridView4);
            this.tabPageBookingsLog.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageBookingsLog.Location = new System.Drawing.Point(4, 24);
            this.tabPageBookingsLog.Name = "tabPageBookingsLog";
            this.tabPageBookingsLog.Size = new System.Drawing.Size(929, 453);
            this.tabPageBookingsLog.TabIndex = 5;
            this.tabPageBookingsLog.Text = "Booking Logs";
            this.tabPageBookingsLog.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(32, 30);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(705, 395);
            this.dataGridView4.TabIndex = 1;
            // 
            // tabPageCustomerList
            // 
            this.tabPageCustomerList.Controls.Add(this.dataGridView5);
            this.tabPageCustomerList.Location = new System.Drawing.Point(4, 24);
            this.tabPageCustomerList.Name = "tabPageCustomerList";
            this.tabPageCustomerList.Size = new System.Drawing.Size(929, 453);
            this.tabPageCustomerList.TabIndex = 7;
            this.tabPageCustomerList.Text = "Customer List";
            this.tabPageCustomerList.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(32, 30);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(705, 395);
            this.dataGridView5.TabIndex = 2;
            // 
            // tabPageCustomerManagement
            // 
            this.tabPageCustomerManagement.Controls.Add(this.button1);
            this.tabPageCustomerManagement.Controls.Add(this.buttonRegister);
            this.tabPageCustomerManagement.Controls.Add(this.comboBoxGender);
            this.tabPageCustomerManagement.Controls.Add(this.label11);
            this.tabPageCustomerManagement.Controls.Add(this.textBoxAge);
            this.tabPageCustomerManagement.Controls.Add(this.label10);
            this.tabPageCustomerManagement.Controls.Add(this.textBoxLastname);
            this.tabPageCustomerManagement.Controls.Add(this.label9);
            this.tabPageCustomerManagement.Controls.Add(this.textBoxFirstname);
            this.tabPageCustomerManagement.Controls.Add(this.label8);
            this.tabPageCustomerManagement.Controls.Add(this.textBoxPassword);
            this.tabPageCustomerManagement.Controls.Add(this.label7);
            this.tabPageCustomerManagement.Controls.Add(this.textboxUsername);
            this.tabPageCustomerManagement.Controls.Add(this.label6);
            this.tabPageCustomerManagement.Location = new System.Drawing.Point(4, 24);
            this.tabPageCustomerManagement.Name = "tabPageCustomerManagement";
            this.tabPageCustomerManagement.Size = new System.Drawing.Size(929, 453);
            this.tabPageCustomerManagement.TabIndex = 6;
            this.tabPageCustomerManagement.Text = "Customer Management";
            this.tabPageCustomerManagement.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(715, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 27);
            this.button1.TabIndex = 22;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(715, 368);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(160, 27);
            this.buttonRegister.TabIndex = 21;
            this.buttonRegister.Text = "Add";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(399, 368);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(243, 27);
            this.comboBoxGender.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calisto MT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(394, 329);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 25);
            this.label11.TabIndex = 19;
            this.label11.Text = "Gender";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAge.Location = new System.Drawing.Point(44, 368);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(243, 26);
            this.textBoxAge.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calisto MT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(39, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "Age";
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastname.Location = new System.Drawing.Point(399, 235);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(243, 26);
            this.textBoxLastname.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calisto MT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(394, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Last Name";
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstname.Location = new System.Drawing.Point(44, 235);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(243, 26);
            this.textBoxFirstname.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calisto MT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "First Name";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(399, 113);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(243, 26);
            this.textBoxPassword.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calisto MT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(394, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Password";
            // 
            // textboxUsername
            // 
            this.textboxUsername.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxUsername.Location = new System.Drawing.Point(44, 113);
            this.textboxUsername.Name = "textboxUsername";
            this.textboxUsername.Size = new System.Drawing.Size(243, 26);
            this.textboxUsername.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Username";
            // 
            // FormAlexis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 557);
            this.Controls.Add(this.tabControMain);
            this.Controls.Add(this.panelTop);
            this.Name = "FormAlexis";
            this.Text = "FormAlexis";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.tabControMain.ResumeLayout(false);
            this.tabPageServices.ResumeLayout(false);
            this.tabPageServices.PerformLayout();
            this.tabPageTransactionLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPageBilling.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPageBookingsLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPageCustomerList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.tabPageCustomerManagement.ResumeLayout(false);
            this.tabPageCustomerManagement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TabControl tabControMain;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.TabPage tabPageServices;
        private System.Windows.Forms.TabPage tabPageTransactionLogs;
        private System.Windows.Forms.TabPage tabPageInventory;
        private System.Windows.Forms.TabPage tabPageBilling;
        private System.Windows.Forms.TabPage tabPageBookingsLog;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTotalFee;
        private System.Windows.Forms.Label labelRateperHour;
        private System.Windows.Forms.Label labelFee;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.TextBox textBoxTotalFee;
        private System.Windows.Forms.TextBox textBoxRateperHour;
        private System.Windows.Forms.TextBox textBoxFee;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.ComboBox comboBoxServices;
        private System.Windows.Forms.TabPage tabPageCustomerManagement;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textboxUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TabPage tabPageCustomerList;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}