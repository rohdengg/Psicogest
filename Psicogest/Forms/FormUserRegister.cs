using Psicogest.Data;
using Psicogest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psicogest
{
    public partial class FormUserRegister : Form
    {
        public FormUserRegister()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormUserRegister_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                UserName = textBoxUserName.Text,
                Password = textBoxUserPassword.Text,
            };

            if (!(user.Password == textBoxUserConfirmPassword.Text))
            {
                MessageBox.Show("As senhas digitadas são diferentes, tente novamente.");
                textBoxUserConfirmPassword.Text = "";
                textBoxUserConfirmPassword.Focus();
                return;
            }

            try
            {
                UserData.AddUserToDb(user);
                MessageBox.Show("Usuário cadastrado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
