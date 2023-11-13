using Psicogest.Data;
using Psicogest.Forms;
using Psicogest.Models;
using System.Collections.ObjectModel;

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

        private void FormHome_activated(object sender, EventArgs e)
        {
   
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

        private void patientPanel1_Load(object sender, EventArgs e)
        {

        }

        private void PatientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var patient = PatientList.SelectedItem as Patient;
            labelName.Text = "Nome: " + patient?.Name;
            labelPhone.Text = "Telefone: " + patient?.Phone;
            labelEmail.Text = "Email: " + patient?.Email;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void buttonAnamnese_Click(object sender, EventArgs e)
        {
            var patient = PatientList.SelectedItem as Patient;
            var formAnamnese = new FormAnamnese(patient.Id);
            formAnamnese.Show();

        }
    }
}