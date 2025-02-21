using AlexisConstructionProject.Classes.functionsLogIn;
using AlexisConstructionProject.Objects;
using System;
using System.Windows.Forms;

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
            //ClassLogIn.ReferenceEquals(this, (FormLogIn)sender);
            ClassLogIn.isAccountExist();

            if (Validities.isValid) { ClassLogIn.signin(); } else { MessageBox.Show("Account does not Exist", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

            if (UserCredentials.ID != 0)
            {
                if (UserCredentials.ID != 1)
                {
                    this.Hide();
                    MainBoardUserClient logGrant = new MainBoardUserClient();
                    logGrant.Show();
                }

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
