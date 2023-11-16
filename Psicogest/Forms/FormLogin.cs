using Psicogest.Models;
using Psicogest.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Psicogest
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                User user = UserData.GetUserByName(textBoxUser.Text);
                if (user != null && textBoxPassword.Text.Equals(user.Password))
                {
                    var home = new FormHome(user);
                    home.Show();

                    this.Hide();

                    home.FormClosed += new FormClosedEventHandler(onHomeClose);
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos",
                                    "Desculpe.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxUser.Focus();
                    textBoxPassword.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                    "Desculpe.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void onHomeClose(object? sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var userRegister = new FormUserRegister();
            userRegister.Show();
        }
    }
}
