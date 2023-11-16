using Psicogest.Data;
using Psicogest.Forms;
using Psicogest.Models;
using System.Collections.ObjectModel;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace Psicogest
{
    public partial class FormHome : Form
    {
        private User user;

        public FormHome(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            PatientList.DataSource = PatientData.GetAllPatients(user.Id);
        }

        protected virtual void OnFormClose(FormClosedEventArgs e)
        {
        }

        private void buttonNewPatient_Click(object sender, EventArgs e)
        {
            var formPatientRegister = new FormPatientRegister(user.Id);
            formPatientRegister.ShowDialog();
            formPatientRegister.FormClosed += new FormClosedEventHandler(onRegisterClose);
            PatientList.DataSource = PatientData.GetAllPatients(user.Id);
        }

        private void onRegisterClose(object sender, FormClosedEventArgs e)
        {
            this.BringToFront();
            this.Focus();
        }

        private void PatientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var patient = PatientList.SelectedItem as Patient;
            labelName.Text = "Nome: " + patient?.Name;
            labelPhone.Text = "Telefone: " + patient?.Phone;
            labelEmail.Text = "Email: " + patient?.Email;

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var patient = PatientList.SelectedItem as Patient;
            var formEditPatient = new FormEditPatient(patient);
            formEditPatient.ShowDialog();
            PatientList.DataSource = PatientData.GetAllPatients(user.Id);
        }

        private void buttonAnamnese_Click(object sender, EventArgs e)
        {
            var patient = PatientList.SelectedItem as Patient;
            var formAnamnese = new FormAnamnese(patient.Id);
            formAnamnese.Show();

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja excluir permanentemente todos os dados desse paciente?", "Atenção!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var patient = PatientList.SelectedItem as Patient;
                try
                {
                    PatientData.DeletePatient(patient.Id);
                    var patientAnamnese = AnamneseData.GetAnamneseByPatientId(patient.Id);
                    if (patientAnamnese != null ) {
                        AnamneseData.DeleteAnamnese(patientAnamnese.Id);
                    }
                    MessageBox.Show("Paciente deletado com sucesso!");
                    PatientList.DataSource = PatientData.GetAllPatients(user.Id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}