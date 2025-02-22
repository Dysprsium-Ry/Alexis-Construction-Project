﻿using AlexisConstructionProject.Classes;
using AlexisConstructionProject.Classes.functionsLogIn;
using AlexisConstructionProject.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlexisConstructionProject.Forms
{
    public partial class FormAlexis : Form
    {
        public FormAlexis()
        {
            InitializeComponent();
            List<char> genderList = new List<char>();
            genderList.Add('M'); genderList.Add('F');
            comboBoxGender.DataSource = genderList;

            DataGrids.transactionLogs(dataGridViewTransactionLogs);
            DataGrids.AvailableServices(dataGridViewServicesOffered);
            DataGrids.clientLists(dataGridViewCustomerLists);
            DataGrids.transactionBilling(dataGridViewBilling);
        }

        private void FormAlexis_Load(object sender, EventArgs e)
        {
            DataProvider.Services();
            comboBoxServices.DataSource = Items.services;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            CreateUser.username = textboxUsername.Text;
            CreateUser.password = textBoxPassword.Text;
            CreateUser.fname = textBoxFirstname.Text;
            CreateUser.lname = textBoxLastname.Text;
            CreateUser.age = Convert.ToInt32(textBoxAge.Text);
            CreateUser.gender = Convert.ToChar(comboBoxGender.Text);

            UserCreation.createUser();
            
            if(!Validities.isPresent)MessageBox.Show("Account Created Successfully", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonRegisterBooking_Click(object sender, EventArgs e)
        {
            selectedItem.service = comboBoxServices.Text;
            selectedItem.DateBooked = dateTimePickerBookingDate.Value;
            selectedItem.duration = Convert.ToInt32(textBoxDuration.Text);
            selectedItem.TotalFee = Convert.ToInt32(textBoxTotalFee.Text);

            booking.registerBooking();
            DataGrids.transactionLogs(dataGridViewTransactionLogs);
            DataGrids.AvailableServices(dataGridViewServicesOffered);
        }

        private void dataGridViewTransactionLogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFee.Text))
            {
                switch (comboBoxServices.Text)
                {
                    case "Plumbing":
                        Items.price = 150;
                        break;
                    case "Electrical":
                        Items.price = 300;
                        break;
                    case "Masonry":
                        Items.price = 250;
                        break;
                    case "Carpentry Works":
                        Items.price = 200;
                        break;
                }
                textBoxFee.Text = Items.price.ToString();
            }

            if (string.IsNullOrEmpty(textBoxDuration.Text))
            {
                switch (comboBoxServices.Text)
                {
                    case "Plumbing":
                        selectedItem.duration = 12;
                        break;
                    case "Electrical":
                        selectedItem.duration = 12;
                        break;
                    case "Masonry":
                        selectedItem.duration = 24;
                        break;
                    case "Carpentry Works":
                        selectedItem.duration = 6;
                        break;
                }
                textBoxDuration.Text = selectedItem.duration.ToString();
            }


            int duration = string.IsNullOrWhiteSpace(textBoxDuration.Text) ? 0 : Convert.ToInt32(textBoxDuration.Text);
            //int? fee = string.IsNullOrWhiteSpace(textBoxFee.Text) ? 0 : Convert.ToInt32(textboxUsername.Text);

            int? total = Convert.ToInt32(textBoxFee.Text) * duration;
            textBoxTotalFee.Text = total.ToString();

            if (!string.IsNullOrEmpty(textBoxFee.Text))
            {
                Items.price = Convert.ToInt32(textBoxFee.Text);
            }
        }

        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {
            UserCreation.deleteUser(dataGridViewCustomerLists);
            DataGrids.clientLists(dataGridViewCustomerLists);
        }

        private void buttonTransactionDelete_Click(object sender, EventArgs e)
        {
             DataGrids.transactionBilling(dataGridViewCustomerLists);
        }

        private void buttonAcceptBooking_Click(object sender, EventArgs e)
        {
            //booking.AcceptBooking(dataGridViewBilling);
            DataGrids.transactionBilling(dataGridViewBilling);
        }

        private void buttonEditTools_Click(object sender, EventArgs e)
        {

        }
    }
}
