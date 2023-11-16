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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Psicogest.Forms
{
    public partial class FormPatientRegister : Form
    {
        private int userId;
        public FormPatientRegister(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxPhone.Text == "")
            {
                MessageBox.Show("Por favor, preencha um número de telefone");
                return;
            }
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Por favor, preencha um nome para o paciente");
                return;
            }

            Patient patient = new Patient
            {
                Name = textBoxName.Text,
                Phone = long.Parse(textBoxPhone.Text),
                Email = textBoxEmail.Text,

                UserId = userId,
            };

            try
            {
                PatientData.AddPatientToDb(patient);
                MessageBox.Show("Paciente cadastrado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = (int)e.KeyChar;
            if (!char.IsDigit(e.KeyChar) && key != 8)
            {
                e.Handled = true;
                MessageBox.Show("O campo telefone aceita apenas números");
                textBoxPhone.Focus();
            }
        }

        private void FormPatientRegister_Load(object sender, EventArgs e)
        {

        }

        private void FormPatientRegister_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
