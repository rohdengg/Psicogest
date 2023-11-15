namespace Psicogest.Forms
{
    partial class FormAnamnese
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            dateTimePickerBirthDay = new DateTimePicker();
            textBoxGender = new TextBox();
            textBoxEmergencyContact = new TextBox();
            textBoxMainComplaint = new TextBox();
            textBoxSymptoms = new TextBox();
            textBoxJob = new TextBox();
            textBoxMedicines = new TextBox();
            textBoxMaritalStatus = new TextBox();
            textBoxSchooling = new TextBox();
            buttonSave = new Button();
            labelBirthDay = new Label();
            buttonEdit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 72);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 0;
            label1.Text = "Data de nascimento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 143);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Gênero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 210);
            label3.Name = "label3";
            label3.Size = new Size(134, 15);
            label3.TabIndex = 2;
            label3.Text = "Contato de emergência:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 271);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 3;
            label4.Text = "Principal queixa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 341);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 4;
            label5.Text = "Sintomas:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 410);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 5;
            label6.Text = "Ocupação:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(70, 476);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 6;
            label7.Text = "Medicamentos:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(70, 538);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 7;
            label8.Text = "Estado civil:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(70, 596);
            label9.Name = "label9";
            label9.Size = new Size(76, 15);
            label9.TabIndex = 8;
            label9.Text = "Escolaridade:";
            // 
            // dateTimePickerBirthDay
            // 
            dateTimePickerBirthDay.Enabled = false;
            dateTimePickerBirthDay.Location = new Point(70, 90);
            dateTimePickerBirthDay.Name = "dateTimePickerBirthDay";
            dateTimePickerBirthDay.Size = new Size(253, 23);
            dateTimePickerBirthDay.TabIndex = 9;
            dateTimePickerBirthDay.Visible = false;
            // 
            // textBoxGender
            // 
            textBoxGender.Location = new Point(70, 161);
            textBoxGender.Name = "textBoxGender";
            textBoxGender.ReadOnly = true;
            textBoxGender.Size = new Size(253, 23);
            textBoxGender.TabIndex = 10;
            // 
            // textBoxEmergencyContact
            // 
            textBoxEmergencyContact.Location = new Point(70, 228);
            textBoxEmergencyContact.Name = "textBoxEmergencyContact";
            textBoxEmergencyContact.ReadOnly = true;
            textBoxEmergencyContact.Size = new Size(253, 23);
            textBoxEmergencyContact.TabIndex = 11;
            textBoxEmergencyContact.KeyPress += textBoxEmergencyContact_KeyPress;
            // 
            // textBoxMainComplaint
            // 
            textBoxMainComplaint.Location = new Point(70, 289);
            textBoxMainComplaint.Name = "textBoxMainComplaint";
            textBoxMainComplaint.ReadOnly = true;
            textBoxMainComplaint.Size = new Size(253, 23);
            textBoxMainComplaint.TabIndex = 12;
            // 
            // textBoxSymptoms
            // 
            textBoxSymptoms.Location = new Point(70, 359);
            textBoxSymptoms.Name = "textBoxSymptoms";
            textBoxSymptoms.ReadOnly = true;
            textBoxSymptoms.Size = new Size(253, 23);
            textBoxSymptoms.TabIndex = 13;
            // 
            // textBoxJob
            // 
            textBoxJob.Location = new Point(70, 428);
            textBoxJob.Name = "textBoxJob";
            textBoxJob.ReadOnly = true;
            textBoxJob.Size = new Size(253, 23);
            textBoxJob.TabIndex = 14;
            // 
            // textBoxMedicines
            // 
            textBoxMedicines.Location = new Point(70, 494);
            textBoxMedicines.Name = "textBoxMedicines";
            textBoxMedicines.ReadOnly = true;
            textBoxMedicines.Size = new Size(253, 23);
            textBoxMedicines.TabIndex = 15;
            // 
            // textBoxMaritalStatus
            // 
            textBoxMaritalStatus.Location = new Point(70, 556);
            textBoxMaritalStatus.Name = "textBoxMaritalStatus";
            textBoxMaritalStatus.ReadOnly = true;
            textBoxMaritalStatus.Size = new Size(253, 23);
            textBoxMaritalStatus.TabIndex = 16;
            // 
            // textBoxSchooling
            // 
            textBoxSchooling.Location = new Point(70, 614);
            textBoxSchooling.Name = "textBoxSchooling";
            textBoxSchooling.ReadOnly = true;
            textBoxSchooling.Size = new Size(253, 23);
            textBoxSchooling.TabIndex = 17;
            // 
            // buttonSave
            // 
            buttonSave.Enabled = false;
            buttonSave.Location = new Point(145, 665);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 18;
            buttonSave.Text = "Salvar";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Visible = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelBirthDay
            // 
            labelBirthDay.Enabled = false;
            labelBirthDay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelBirthDay.Location = new Point(70, 87);
            labelBirthDay.Name = "labelBirthDay";
            labelBirthDay.Size = new Size(242, 27);
            labelBirthDay.TabIndex = 19;
            labelBirthDay.Text = "data de nascimento";
            labelBirthDay.TextAlign = ContentAlignment.MiddleLeft;
            labelBirthDay.Visible = false;
            // 
            // buttonEdit
            // 
            buttonEdit.Enabled = false;
            buttonEdit.Location = new Point(145, 665);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 20;
            buttonEdit.Text = "Editar";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Visible = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // FormAnamnese
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 702);
            Controls.Add(buttonEdit);
            Controls.Add(labelBirthDay);
            Controls.Add(buttonSave);
            Controls.Add(textBoxSchooling);
            Controls.Add(textBoxMaritalStatus);
            Controls.Add(textBoxMedicines);
            Controls.Add(textBoxJob);
            Controls.Add(textBoxSymptoms);
            Controls.Add(textBoxMainComplaint);
            Controls.Add(textBoxEmergencyContact);
            Controls.Add(textBoxGender);
            Controls.Add(dateTimePickerBirthDay);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAnamnese";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAnamnese";
            Load += FormAnamnese_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private DateTimePicker dateTimePickerBirthDay;
        private TextBox textBoxGender;
        private TextBox textBoxEmergencyContact;
        private TextBox textBoxMainComplaint;
        private TextBox textBoxSymptoms;
        private TextBox textBoxJob;
        private TextBox textBoxMedicines;
        private TextBox textBoxMaritalStatus;
        private TextBox textBoxSchooling;
        private Button buttonSave;
        private Label labelBirthDay;
        private Button buttonEdit;
    }
}