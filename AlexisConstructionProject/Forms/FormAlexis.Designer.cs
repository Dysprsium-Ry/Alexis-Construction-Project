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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.tabPageServices = new System.Windows.Forms.TabPage();
            this.tabPageTransactionLogs = new System.Windows.Forms.TabPage();
            this.tabPageInventory = new System.Windows.Forms.TabPage();
            this.tabPageBilling = new System.Windows.Forms.TabPage();
            this.tabPageBookingsLog = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(937, 76);
            this.panelTop.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageHome);
            this.tabControl1.Controls.Add(this.tabPageServices);
            this.tabControl1.Controls.Add(this.tabPageTransactionLogs);
            this.tabControl1.Controls.Add(this.tabPageInventory);
            this.tabControl1.Controls.Add(this.tabPageBilling);
            this.tabControl1.Controls.Add(this.tabPageBookingsLog);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(937, 481);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageHome
            // 
            this.tabPageHome.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageHome.Location = new System.Drawing.Point(4, 22);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHome.Size = new System.Drawing.Size(929, 455);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "Home";
            this.tabPageHome.UseVisualStyleBackColor = true;
            // 
            // tabPageServices
            // 
            this.tabPageServices.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageServices.Location = new System.Drawing.Point(4, 22);
            this.tabPageServices.Name = "tabPageServices";
            this.tabPageServices.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageServices.Size = new System.Drawing.Size(929, 455);
            this.tabPageServices.TabIndex = 1;
            this.tabPageServices.Text = "Services";
            this.tabPageServices.UseVisualStyleBackColor = true;
            // 
            // tabPageTransactionLogs
            // 
            this.tabPageTransactionLogs.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageTransactionLogs.Location = new System.Drawing.Point(4, 22);
            this.tabPageTransactionLogs.Name = "tabPageTransactionLogs";
            this.tabPageTransactionLogs.Size = new System.Drawing.Size(929, 455);
            this.tabPageTransactionLogs.TabIndex = 2;
            this.tabPageTransactionLogs.Text = "Transaction Logs";
            this.tabPageTransactionLogs.UseVisualStyleBackColor = true;
            // 
            // tabPageInventory
            // 
            this.tabPageInventory.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageInventory.Location = new System.Drawing.Point(4, 22);
            this.tabPageInventory.Name = "tabPageInventory";
            this.tabPageInventory.Size = new System.Drawing.Size(929, 455);
            this.tabPageInventory.TabIndex = 3;
            this.tabPageInventory.Text = "Inventory";
            this.tabPageInventory.UseVisualStyleBackColor = true;
            // 
            // tabPageBilling
            // 
            this.tabPageBilling.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageBilling.Location = new System.Drawing.Point(4, 22);
            this.tabPageBilling.Name = "tabPageBilling";
            this.tabPageBilling.Size = new System.Drawing.Size(929, 455);
            this.tabPageBilling.TabIndex = 4;
            this.tabPageBilling.Text = "Billing";
            this.tabPageBilling.UseVisualStyleBackColor = true;
            // 
            // tabPageBookingsLog
            // 
            this.tabPageBookingsLog.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageBookingsLog.Location = new System.Drawing.Point(4, 22);
            this.tabPageBookingsLog.Name = "tabPageBookingsLog";
            this.tabPageBookingsLog.Size = new System.Drawing.Size(929, 455);
            this.tabPageBookingsLog.TabIndex = 5;
            this.tabPageBookingsLog.Text = "Booking Logs";
            this.tabPageBookingsLog.UseVisualStyleBackColor = true;
            // 
            // FormAlexis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 557);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelTop);
            this.Name = "FormAlexis";
            this.Text = "FormAlexis";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.TabPage tabPageServices;
        private System.Windows.Forms.TabPage tabPageTransactionLogs;
        private System.Windows.Forms.TabPage tabPageInventory;
        private System.Windows.Forms.TabPage tabPageBilling;
        private System.Windows.Forms.TabPage tabPageBookingsLog;
    }
}