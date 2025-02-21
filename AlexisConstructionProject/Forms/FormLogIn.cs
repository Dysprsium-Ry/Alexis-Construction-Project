using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AlexisConstructionProject.Classes;
using AlexisConstructionProject.Classes.functionsLogIn;
using AlexisConstructionProject.Objects;

namespace AlexisConstructionProject.Forms
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            UserCredentials.Username = textBoxUsername.Text;
            UserCredentials.Password = textBoxPassword.Text;
            ClassLogIn.signin();
            if (UserCredentials.ID != 0)
            {
                this.Hide();
                MainBoardUserClient logGrant = new MainBoardUserClient();
                logGrant.Show();

                if (UserCredentials.ID == 1)
                {
                    this.Hide();
                    FormAlexis adminform = new FormAlexis();
                    adminform.Show();
                }
            }
        }
    }
}
