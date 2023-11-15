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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Psicogest.Forms
{
    public partial class FormEditPatient : Form
    {
        private Patient patient;
        public FormEditPatient(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
        }

        private void FormEditPatient_Load(object sender, EventArgs e)
        {
            textBoxName.Text = patient.Name;
            textBoxPhone.Text = patient.Phone.ToString();
            textBoxEmail.Text = patient.Email;

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxPhone.Text == "")
            {
                MessageBox.Show("Por favor, preencha um número de telefone");
                return;
            }
            patient.Name = textBoxName.Text;
            patient.Phone = long.Parse(textBoxPhone.Text);
            patient.Email = textBoxEmail.Text;

            try
            {
                PatientData.UpdatePatient(patient);
                MessageBox.Show("Alterações salvas com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
    }
}
