using AlexisConstructionProject.Classes;
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
    }
}
