using Psicogest.Data;
using Psicogest.Models;

namespace Psicogest.Forms
{
    public partial class FormAnamnese : Form
    {
        private int patientId;
        private Anamnese anamnese;
        public FormAnamnese(int patientId)
        {
            InitializeComponent();
            this.patientId = patientId;
        }

        private void FormAnamnese_Load(object sender, EventArgs e)
        {
            anamnese = AnamneseData.GetAnamneseByPatientId(patientId);
            if (anamnese == null)
            {
                MessageBox.Show("O paciente ainda não tem uma anamnese");
            }
            else
            {
                dateTimePickerBirthDay.Value = (DateTime)anamnese.BirthDay;
                textBoxGender.Text = anamnese.Gender;
                textBoxEmergencyContact.Text = anamnese.EmergencyContact.ToString();
                textBoxMainComplaint.Text = anamnese.MainComplaint;
                textBoxSymptoms.Text = anamnese.Symptoms;
                textBoxJob.Text = anamnese.Job;
                textBoxMedicines.Text = anamnese.Medicines;
                textBoxMaritalStatus.Text = anamnese.MaritalStatus;
                textBoxSchooling.Text = anamnese.Schooling;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Anamnese anamnese = new Anamnese
            {
                PatientId = patientId,

                BirthDay = dateTimePickerBirthDay.Value,
                Gender = textBoxGender.Text,
                EmergencyContact = int.Parse(textBoxEmergencyContact.Text),
                MainComplaint = textBoxMainComplaint.Text,
                Symptoms = textBoxSymptoms.Text,
                Job = textBoxJob.Text,
                Medicines = textBoxMedicines.Text,
                MaritalStatus = textBoxMaritalStatus.Text,
                Schooling = textBoxSchooling.Text,
            };

            try
            {
                AnamneseData.AddAnamneseToDb(anamnese);
                MessageBox.Show("Anamnese salva com sucesso!");
                this.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
