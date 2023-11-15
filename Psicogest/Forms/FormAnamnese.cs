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
                editModeOn();
            }
            else
            {
                buttonEdit.Enabled = true;
                buttonEdit.Visible = true;
                labelBirthDay.Enabled = true;
                labelBirthDay.Visible = true;

                dateTimePickerBirthDay.Value = (DateTime)anamnese.BirthDay;
                labelBirthDay.Text = dateTimePickerBirthDay.Value.ToString("dd/MM/yyyy");

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
            if (anamnese == null)
            {
                Anamnese newAnamnese = new Anamnese
                {
                    PatientId = patientId,

                    BirthDay = dateTimePickerBirthDay.Value,
                    Gender = textBoxGender.Text,
                    MainComplaint = textBoxMainComplaint.Text,
                    Symptoms = textBoxSymptoms.Text,
                    Job = textBoxJob.Text,
                    Medicines = textBoxMedicines.Text,
                    MaritalStatus = textBoxMaritalStatus.Text,
                    Schooling = textBoxSchooling.Text,
                };

                if (textBoxEmergencyContact.Text != "")
                {
                    newAnamnese.EmergencyContact = long.Parse(textBoxEmergencyContact.Text);
                }

                try
                {
                    AnamneseData.AddAnamneseToDb(newAnamnese);
                    MessageBox.Show("Anamnese salva com sucesso!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                anamnese.BirthDay = dateTimePickerBirthDay.Value;
                anamnese.Gender = textBoxGender.Text;
                anamnese.MainComplaint = textBoxMainComplaint.Text;
                anamnese.Symptoms = textBoxSymptoms.Text;
                anamnese.Job = textBoxJob.Text;
                anamnese.Medicines = textBoxMedicines.Text;
                anamnese.MaritalStatus = textBoxMaritalStatus.Text;
                anamnese.Schooling = textBoxSchooling.Text;

                if (textBoxEmergencyContact.Text != "")
                {
                    anamnese.EmergencyContact = long.Parse(textBoxEmergencyContact.Text);
                }

                try
                {
                    AnamneseData.UpdateAnamnese(anamnese);
                    MessageBox.Show("Alterações salvas com sucesso!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            

        }

        private void textBoxEmergencyContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = (int)e.KeyChar;
            if (!char.IsDigit(e.KeyChar) && key != 8)
            {
                e.Handled = true;
                MessageBox.Show("O campo telefone aceita apenas números");
                textBoxEmergencyContact.Focus();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            editModeOn();
        }

        private void editModeOn()
        {
            labelBirthDay.Enabled = false;
            labelBirthDay.Visible = false;
            dateTimePickerBirthDay.Enabled = true;
            dateTimePickerBirthDay.Visible = true;

            textBoxGender.ReadOnly = false;
            textBoxEmergencyContact.ReadOnly = false;
            textBoxMainComplaint.ReadOnly = false;
            textBoxSymptoms.ReadOnly = false;
            textBoxJob.ReadOnly = false;
            textBoxMedicines.ReadOnly = false;
            textBoxMaritalStatus.ReadOnly = false;
            textBoxSchooling.ReadOnly = false;

            buttonEdit.Enabled = false;
            buttonEdit.Visible = false;
            buttonSave.Enabled = true;
            buttonSave.Visible = true;
        }
    }
}
