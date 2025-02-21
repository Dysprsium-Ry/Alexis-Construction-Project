namespace AlexisConstructionProject.Forms
{
    partial class MainBoardUserClient
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
            this.tabControlMainBoardUserClient = new System.Windows.Forms.TabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.tabPageServices = new System.Windows.Forms.TabPage();
            this.tabPageTransactionLogs = new System.Windows.Forms.TabPage();
            this.tabPageUserAccountSettings = new System.Windows.Forms.TabPage();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.tabControlMainBoardUserClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(931, 72);
            this.panelTop.TabIndex = 0;
            // 
            // tabControlMainBoardUserClient
            // 
            this.tabControlMainBoardUserClient.Controls.Add(this.tabPageHome);
            this.tabControlMainBoardUserClient.Controls.Add(this.tabPageServices);
            this.tabControlMainBoardUserClient.Controls.Add(this.tabPageTransactionLogs);
            this.tabControlMainBoardUserClient.Controls.Add(this.tabPageUserAccountSettings);
            this.tabControlMainBoardUserClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMainBoardUserClient.Location = new System.Drawing.Point(0, 72);
            this.tabControlMainBoardUserClient.Name = "tabControlMainBoardUserClient";
            this.tabControlMainBoardUserClient.SelectedIndex = 0;
            this.tabControlMainBoardUserClient.Size = new System.Drawing.Size(931, 495);
            this.tabControlMainBoardUserClient.TabIndex = 1;
            // 
            // tabPageHome
            // 
            this.tabPageHome.Location = new System.Drawing.Point(4, 22);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHome.Size = new System.Drawing.Size(923, 469);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "Home";
            this.tabPageHome.UseVisualStyleBackColor = true;
            // 
            // tabPageServices
            // 
            this.tabPageServices.Location = new System.Drawing.Point(4, 22);
            this.tabPageServices.Name = "tabPageServices";
            this.tabPageServices.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageServices.Size = new System.Drawing.Size(923, 469);
            this.tabPageServices.TabIndex = 1;
            this.tabPageServices.Text = "Services";
            this.tabPageServices.UseVisualStyleBackColor = true;
            // 
            // tabPageTransactionLogs
            // 
            this.tabPageTransactionLogs.Location = new System.Drawing.Point(4, 22);
            this.tabPageTransactionLogs.Name = "tabPageTransactionLogs";
            this.tabPageTransactionLogs.Size = new System.Drawing.Size(923, 469);
            this.tabPageTransactionLogs.TabIndex = 2;
            this.tabPageTransactionLogs.Text = "Transactions";
            this.tabPageTransactionLogs.UseVisualStyleBackColor = true;
            // 
            // tabPageUserAccountSettings
            // 
            this.tabPageUserAccountSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageUserAccountSettings.Name = "tabPageUserAccountSettings";
            this.tabPageUserAccountSettings.Size = new System.Drawing.Size(923, 469);
            this.tabPageUserAccountSettings.TabIndex = 3;
            this.tabPageUserAccountSettings.Text = "Account Settings";
            this.tabPageUserAccountSettings.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Calisto MT", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 22);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(383, 35);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Alexis Construction Services";
            // 
            // MainBoardUserClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 567);
            this.Controls.Add(this.tabControlMainBoardUserClient);
            this.Controls.Add(this.panelTop);
            this.Name = "MainBoardUserClient";
            this.Text = "Alexis Constuction Services";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.tabControlMainBoardUserClient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TabControl tabControlMainBoardUserClient;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.TabPage tabPageServices;
        private System.Windows.Forms.TabPage tabPageTransactionLogs;
        private System.Windows.Forms.TabPage tabPageUserAccountSettings;
        private System.Windows.Forms.Label labelTitle;
    }
}