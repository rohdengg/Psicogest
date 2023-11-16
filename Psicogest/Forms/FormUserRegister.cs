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

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "" || textBoxUserPassword.Text.Length < 7)
            {
                MessageBox.Show("É necessário preencher um nome de usuário e uma senha de no minimo 7 caracteres");
                return;
            }
            if (!(textBoxUserPassword.Text == textBoxUserConfirmPassword.Text))
            {
                MessageBox.Show("As senhas digitadas são diferentes, tente novamente.");
                textBoxUserConfirmPassword.Text = "";
                textBoxUserConfirmPassword.Focus();
                return;
            }
            if (UserData.GetUserByName(textBoxUserName.Text) != null)
            {
                MessageBox.Show("Esse nome de usuário não está disponível");
                textBoxUserName.Text = "";
                textBoxUserName.Focus();
                return;
            }

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
