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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tabPageCustomerManagement = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textboxUsername = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPageCustomerList = new System.Windows.Forms.TabPage();
            this.dataGridViewCustomerLists = new System.Windows.Forms.DataGridView();
            this.tabPageBookingLog = new System.Windows.Forms.TabPage();
            this.dataGridViewBookingLogs = new System.Windows.Forms.DataGridView();
            this.tabPageBilling = new System.Windows.Forms.TabPage();
            this.dataGridViewBilling = new System.Windows.Forms.DataGridView();
            this.tabPageTransactionLogs = new System.Windows.Forms.TabPage();
            this.dataGridViewTransactionLogs = new System.Windows.Forms.DataGridView();
            this.tabPageServices = new System.Windows.Forms.TabPage();
            this.buttonRegisterBooking = new System.Windows.Forms.Button();
            this.textBoxTotalFee = new System.Windows.Forms.TextBox();
            this.textBoxFee = new System.Windows.Forms.TextBox();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.comboBoxServices = new System.Windows.Forms.ComboBox();
            this.labelTotalFee = new System.Windows.Forms.Label();
            this.labelFee = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelService = new System.Windows.Forms.Label();
            this.tabControMain = new System.Windows.Forms.TabControl();
            this.tabPageServicesOffered = new System.Windows.Forms.TabPage();
            this.dataGridViewServicesOffered = new System.Windows.Forms.DataGridView();
            this.labeldurationdesc = new System.Windows.Forms.Label();
            this.labelBookingDate = new System.Windows.Forms.Label();
            this.dateTimePickerBookingDate = new System.Windows.Forms.DateTimePicker();
            this.panelTop.SuspendLayout();
            this.tabPageCustomerManagement.SuspendLayout();
            this.tabPageCustomerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerLists)).BeginInit();
            this.tabPageBookingLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingLogs)).BeginInit();
            this.tabPageBilling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBilling)).BeginInit();
            this.tabPageTransactionLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactionLogs)).BeginInit();
            this.tabPageServices.SuspendLayout();
            this.tabControMain.SuspendLayout();
            this.tabPageServicesOffered.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServicesOffered)).BeginInit();
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
            // tabPageCustomerManagement
            // 
            this.tabPageCustomerManagement.Controls.Add(this.button1);
            this.tabPageCustomerManagement.Controls.Add(this.buttonRegister);
            this.tabPageCustomerManagement.Controls.Add(this.comboBoxGender);
            this.tabPageCustomerManagement.Controls.Add(this.label11);
            this.tabPageCustomerManagement.Controls.Add(this.textBoxAge);
            this.tabPageCustomerManagement.Controls.Add(this.textBoxLastname);
            this.tabPageCustomerManagement.Controls.Add(this.textBoxFirstname);
            this.tabPageCustomerManagement.Controls.Add(this.textBoxPassword);
            this.tabPageCustomerManagement.Controls.Add(this.textboxUsername);
            this.tabPageCustomerManagement.Controls.Add(this.label10);
            this.tabPageCustomerManagement.Controls.Add(this.label9);
            this.tabPageCustomerManagement.Controls.Add(this.label8);
            this.tabPageCustomerManagement.Controls.Add(this.label7);
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
            // textBoxLastname
            // 
            this.textBoxLastname.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastname.Location = new System.Drawing.Point(399, 235);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(243, 26);
            this.textBoxLastname.TabIndex = 16;
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstname.Location = new System.Drawing.Point(44, 235);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(243, 26);
            this.textBoxFirstname.TabIndex = 14;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(399, 113);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(243, 26);
            this.textBoxPassword.TabIndex = 12;
            // 
            // textboxUsername
            // 
            this.textboxUsername.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxUsername.Location = new System.Drawing.Point(44, 113);
            this.textboxUsername.Name = "textboxUsername";
            this.textboxUsername.Size = new System.Drawing.Size(243, 26);
            this.textboxUsername.TabIndex = 10;
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
            // tabPageCustomerList
            // 
            this.tabPageCustomerList.Controls.Add(this.dataGridViewCustomerLists);
            this.tabPageCustomerList.Location = new System.Drawing.Point(4, 24);
            this.tabPageCustomerList.Name = "tabPageCustomerList";
            this.tabPageCustomerList.Size = new System.Drawing.Size(929, 453);
            this.tabPageCustomerList.TabIndex = 7;
            this.tabPageCustomerList.Text = "Customer List";
            this.tabPageCustomerList.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCustomerLists
            // 
            this.dataGridViewCustomerLists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomerLists.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewCustomerLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomerLists.Location = new System.Drawing.Point(32, 30);
            this.dataGridViewCustomerLists.Name = "dataGridViewCustomerLists";
            this.dataGridViewCustomerLists.Size = new System.Drawing.Size(705, 395);
            this.dataGridViewCustomerLists.TabIndex = 2;
            // 
            // tabPageBookingLog
            // 
            this.tabPageBookingLog.Controls.Add(this.dataGridViewBookingLogs);
            this.tabPageBookingLog.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageBookingLog.Location = new System.Drawing.Point(4, 24);
            this.tabPageBookingLog.Name = "tabPageBookingLog";
            this.tabPageBookingLog.Size = new System.Drawing.Size(929, 453);
            this.tabPageBookingLog.TabIndex = 5;
            this.tabPageBookingLog.Text = "Booking Logs";
            this.tabPageBookingLog.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBookingLogs
            // 
            this.dataGridViewBookingLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBookingLogs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewBookingLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookingLogs.Location = new System.Drawing.Point(32, 30);
            this.dataGridViewBookingLogs.Name = "dataGridViewBookingLogs";
            this.dataGridViewBookingLogs.Size = new System.Drawing.Size(705, 395);
            this.dataGridViewBookingLogs.TabIndex = 1;
            // 
            // tabPageBilling
            // 
            this.tabPageBilling.Controls.Add(this.dataGridViewBilling);
            this.tabPageBilling.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageBilling.Location = new System.Drawing.Point(4, 24);
            this.tabPageBilling.Name = "tabPageBilling";
            this.tabPageBilling.Size = new System.Drawing.Size(929, 453);
            this.tabPageBilling.TabIndex = 4;
            this.tabPageBilling.Text = "Billing";
            this.tabPageBilling.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBilling
            // 
            this.dataGridViewBilling.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBilling.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBilling.Location = new System.Drawing.Point(32, 30);
            this.dataGridViewBilling.Name = "dataGridViewBilling";
            this.dataGridViewBilling.Size = new System.Drawing.Size(705, 395);
            this.dataGridViewBilling.TabIndex = 1;
            // 
            // tabPageTransactionLogs
            // 
            this.tabPageTransactionLogs.Controls.Add(this.dataGridViewTransactionLogs);
            this.tabPageTransactionLogs.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageTransactionLogs.Location = new System.Drawing.Point(4, 24);
            this.tabPageTransactionLogs.Name = "tabPageTransactionLogs";
            this.tabPageTransactionLogs.Size = new System.Drawing.Size(929, 453);
            this.tabPageTransactionLogs.TabIndex = 2;
            this.tabPageTransactionLogs.Text = "Transaction Logs";
            this.tabPageTransactionLogs.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTransactionLogs
            // 
            this.dataGridViewTransactionLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTransactionLogs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewTransactionLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransactionLogs.Location = new System.Drawing.Point(32, 30);
            this.dataGridViewTransactionLogs.Name = "dataGridViewTransactionLogs";
            this.dataGridViewTransactionLogs.Size = new System.Drawing.Size(705, 395);
            this.dataGridViewTransactionLogs.TabIndex = 0;
            this.dataGridViewTransactionLogs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTransactionLogs_CellContentClick);
            // 
            // tabPageServices
            // 
            this.tabPageServices.Controls.Add(this.dateTimePickerBookingDate);
            this.tabPageServices.Controls.Add(this.labelBookingDate);
            this.tabPageServices.Controls.Add(this.labeldurationdesc);
            this.tabPageServices.Controls.Add(this.buttonRegisterBooking);
            this.tabPageServices.Controls.Add(this.textBoxTotalFee);
            this.tabPageServices.Controls.Add(this.textBoxFee);
            this.tabPageServices.Controls.Add(this.textBoxDuration);
            this.tabPageServices.Controls.Add(this.comboBoxServices);
            this.tabPageServices.Controls.Add(this.labelTotalFee);
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
            this.tabPageServices.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // buttonRegisterBooking
            // 
            this.buttonRegisterBooking.Location = new System.Drawing.Point(619, 329);
            this.buttonRegisterBooking.Name = "buttonRegisterBooking";
            this.buttonRegisterBooking.Size = new System.Drawing.Size(160, 24);
            this.buttonRegisterBooking.TabIndex = 22;
            this.buttonRegisterBooking.Text = "Register";
            this.buttonRegisterBooking.UseVisualStyleBackColor = true;
            this.buttonRegisterBooking.Click += new System.EventHandler(this.buttonRegisterBooking_Click);
            // 
            // textBoxTotalFee
            // 
            this.textBoxTotalFee.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalFee.Location = new System.Drawing.Point(536, 200);
            this.textBoxTotalFee.Name = "textBoxTotalFee";
            this.textBoxTotalFee.ReadOnly = true;
            this.textBoxTotalFee.Size = new System.Drawing.Size(243, 26);
            this.textBoxTotalFee.TabIndex = 11;
            this.textBoxTotalFee.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxFee
            // 
            this.textBoxFee.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFee.Location = new System.Drawing.Point(76, 200);
            this.textBoxFee.Name = "textBoxFee";
            this.textBoxFee.ReadOnly = true;
            this.textBoxFee.Size = new System.Drawing.Size(243, 26);
            this.textBoxFee.TabIndex = 9;
            this.textBoxFee.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDuration.Location = new System.Drawing.Point(536, 85);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(243, 26);
            this.textBoxDuration.TabIndex = 8;
            this.textBoxDuration.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // comboBoxServices
            // 
            this.comboBoxServices.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxServices.FormattingEnabled = true;
            this.comboBoxServices.Location = new System.Drawing.Point(76, 83);
            this.comboBoxServices.Name = "comboBoxServices";
            this.comboBoxServices.Size = new System.Drawing.Size(243, 27);
            this.comboBoxServices.TabIndex = 7;
            // 
            // labelTotalFee
            // 
            this.labelTotalFee.AutoSize = true;
            this.labelTotalFee.Font = new System.Drawing.Font("Calisto MT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalFee.Location = new System.Drawing.Point(530, 146);
            this.labelTotalFee.Name = "labelTotalFee";
            this.labelTotalFee.Size = new System.Drawing.Size(138, 35);
            this.labelTotalFee.TabIndex = 6;
            this.labelTotalFee.Text = "Total Fee";
            // 
            // labelFee
            // 
            this.labelFee.AutoSize = true;
            this.labelFee.Font = new System.Drawing.Font("Calisto MT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFee.Location = new System.Drawing.Point(70, 150);
            this.labelFee.Name = "labelFee";
            this.labelFee.Size = new System.Drawing.Size(62, 35);
            this.labelFee.TabIndex = 4;
            this.labelFee.Text = "Fee";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("Calisto MT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuration.Location = new System.Drawing.Point(530, 31);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(132, 35);
            this.labelDuration.TabIndex = 3;
            this.labelDuration.Text = "Duration";
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Font = new System.Drawing.Font("Calisto MT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelService.Location = new System.Drawing.Point(70, 31);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(107, 35);
            this.labelService.TabIndex = 2;
            this.labelService.Text = "Service";
            // 
            // tabControMain
            // 
            this.tabControMain.Controls.Add(this.tabPageServicesOffered);
            this.tabControMain.Controls.Add(this.tabPageServices);
            this.tabControMain.Controls.Add(this.tabPageTransactionLogs);
            this.tabControMain.Controls.Add(this.tabPageBilling);
            this.tabControMain.Controls.Add(this.tabPageBookingLog);
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
            // tabPageServicesOffered
            // 
            this.tabPageServicesOffered.Controls.Add(this.dataGridViewServicesOffered);
            this.tabPageServicesOffered.Location = new System.Drawing.Point(4, 24);
            this.tabPageServicesOffered.Name = "tabPageServicesOffered";
            this.tabPageServicesOffered.Size = new System.Drawing.Size(929, 453);
            this.tabPageServicesOffered.TabIndex = 8;
            this.tabPageServicesOffered.Text = "Services Offered";
            this.tabPageServicesOffered.UseVisualStyleBackColor = true;
            // 
            // dataGridViewServicesOffered
            // 
            this.dataGridViewServicesOffered.AllowUserToAddRows = false;
            this.dataGridViewServicesOffered.AllowUserToDeleteRows = false;
            this.dataGridViewServicesOffered.AllowUserToResizeColumns = false;
            this.dataGridViewServicesOffered.AllowUserToResizeRows = false;
            this.dataGridViewServicesOffered.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewServicesOffered.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServicesOffered.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewServicesOffered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServicesOffered.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewServicesOffered.Location = new System.Drawing.Point(32, 30);
            this.dataGridViewServicesOffered.MultiSelect = false;
            this.dataGridViewServicesOffered.Name = "dataGridViewServicesOffered";
            this.dataGridViewServicesOffered.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServicesOffered.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewServicesOffered.RowTemplate.ReadOnly = true;
            this.dataGridViewServicesOffered.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewServicesOffered.ShowEditingIcon = false;
            this.dataGridViewServicesOffered.Size = new System.Drawing.Size(705, 395);
            this.dataGridViewServicesOffered.TabIndex = 1;
            // 
            // labeldurationdesc
            // 
            this.labeldurationdesc.AutoSize = true;
            this.labeldurationdesc.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldurationdesc.Location = new System.Drawing.Point(659, 43);
            this.labeldurationdesc.Name = "labeldurationdesc";
            this.labeldurationdesc.Size = new System.Drawing.Size(70, 19);
            this.labeldurationdesc.TabIndex = 23;
            this.labeldurationdesc.Text = "in Hours";
            // 
            // labelBookingDate
            // 
            this.labelBookingDate.AutoSize = true;
            this.labelBookingDate.Font = new System.Drawing.Font("Calisto MT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookingDate.Location = new System.Drawing.Point(70, 275);
            this.labelBookingDate.Name = "labelBookingDate";
            this.labelBookingDate.Size = new System.Drawing.Size(191, 35);
            this.labelBookingDate.TabIndex = 24;
            this.labelBookingDate.Text = "Booking Date";
            // 
            // dateTimePickerBookingDate
            // 
            this.dateTimePickerBookingDate.CalendarFont = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBookingDate.Font = new System.Drawing.Font("Calisto MT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBookingDate.Location = new System.Drawing.Point(76, 329);
            this.dateTimePickerBookingDate.MinDate = new System.DateTime(2025, 2, 22, 0, 35, 36, 0);
            this.dateTimePickerBookingDate.Name = "dateTimePickerBookingDate";
            this.dateTimePickerBookingDate.Size = new System.Drawing.Size(243, 24);
            this.dateTimePickerBookingDate.TabIndex = 25;
            this.dateTimePickerBookingDate.Value = new System.DateTime(2025, 2, 22, 0, 35, 36, 0);
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
            this.Load += new System.EventHandler(this.FormAlexis_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.tabPageCustomerManagement.ResumeLayout(false);
            this.tabPageCustomerManagement.PerformLayout();
            this.tabPageCustomerList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerLists)).EndInit();
            this.tabPageBookingLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingLogs)).EndInit();
            this.tabPageBilling.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBilling)).EndInit();
            this.tabPageTransactionLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactionLogs)).EndInit();
            this.tabPageServices.ResumeLayout(false);
            this.tabPageServices.PerformLayout();
            this.tabControMain.ResumeLayout(false);
            this.tabPageServicesOffered.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServicesOffered)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TabPage tabPageCustomerManagement;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textboxUsername;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPageCustomerList;
        private System.Windows.Forms.DataGridView dataGridViewCustomerLists;
        private System.Windows.Forms.TabPage tabPageBookingLog;
        private System.Windows.Forms.DataGridView dataGridViewBookingLogs;
        private System.Windows.Forms.TabPage tabPageBilling;
        private System.Windows.Forms.DataGridView dataGridViewBilling;
        private System.Windows.Forms.TabPage tabPageTransactionLogs;
        private System.Windows.Forms.DataGridView dataGridViewTransactionLogs;
        private System.Windows.Forms.TabPage tabPageServices;
        private System.Windows.Forms.Button buttonRegisterBooking;
        private System.Windows.Forms.TextBox textBoxTotalFee;
        private System.Windows.Forms.TextBox textBoxFee;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.ComboBox comboBoxServices;
        private System.Windows.Forms.Label labelTotalFee;
        private System.Windows.Forms.Label labelFee;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.TabControl tabControMain;
        private System.Windows.Forms.TabPage tabPageServicesOffered;
        private System.Windows.Forms.DataGridView dataGridViewServicesOffered;
        private System.Windows.Forms.Label labeldurationdesc;
        private System.Windows.Forms.DateTimePicker dateTimePickerBookingDate;
        private System.Windows.Forms.Label labelBookingDate;
    }
}