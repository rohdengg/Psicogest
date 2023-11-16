namespace Psicogest
{
    partial class FormHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            patientBindingSource = new BindingSource(components);
            form1BindingSource = new BindingSource(components);
            form1BindingSource1 = new BindingSource(components);
            form1BindingSource2 = new BindingSource(components);
            PatientList = new ListBox();
            buttonNewPatient = new Button();
            panelPatient = new Panel();
            buttonAnamnese = new Button();
            groupBoxPatientData = new GroupBox();
            buttonDelete = new Button();
            buttonEdit = new Button();
            labelEmail = new Label();
            labelPhone = new Label();
            labelName = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource2).BeginInit();
            panelPatient.SuspendLayout();
            groupBoxPatientData.SuspendLayout();
            SuspendLayout();
            // 
            // patientBindingSource
            // 
            patientBindingSource.DataSource = typeof(Models.Patient);
            // 
            // form1BindingSource
            // 
            form1BindingSource.DataSource = typeof(FormHome);
            // 
            // form1BindingSource1
            // 
            form1BindingSource1.DataSource = typeof(FormHome);
            // 
            // form1BindingSource2
            // 
            form1BindingSource2.DataSource = typeof(FormHome);
            // 
            // PatientList
            // 
            PatientList.FormattingEnabled = true;
            PatientList.ItemHeight = 15;
            PatientList.Location = new Point(1, 57);
            PatientList.Name = "PatientList";
            PatientList.Size = new Size(173, 394);
            PatientList.TabIndex = 5;
            PatientList.SelectedIndexChanged += PatientList_SelectedIndexChanged;
            // 
            // buttonNewPatient
            // 
            buttonNewPatient.Location = new Point(180, 25);
            buttonNewPatient.Name = "buttonNewPatient";
            buttonNewPatient.Size = new Size(92, 27);
            buttonNewPatient.TabIndex = 6;
            buttonNewPatient.Text = "Novo Paciente";
            buttonNewPatient.UseVisualStyleBackColor = true;
            buttonNewPatient.Click += buttonNewPatient_Click;
            // 
            // panelPatient
            // 
            panelPatient.Controls.Add(buttonAnamnese);
            panelPatient.Controls.Add(groupBoxPatientData);
            panelPatient.Location = new Point(180, 58);
            panelPatient.Name = "panelPatient";
            panelPatient.Size = new Size(608, 380);
            panelPatient.TabIndex = 7;
            // 
            // buttonAnamnese
            // 
            buttonAnamnese.Location = new Point(35, 130);
            buttonAnamnese.Name = "buttonAnamnese";
            buttonAnamnese.Size = new Size(75, 23);
            buttonAnamnese.TabIndex = 4;
            buttonAnamnese.Text = "Anamnese";
            buttonAnamnese.UseVisualStyleBackColor = true;
            buttonAnamnese.Click += buttonAnamnese_Click;
            // 
            // groupBoxPatientData
            // 
            groupBoxPatientData.Controls.Add(buttonDelete);
            groupBoxPatientData.Controls.Add(buttonEdit);
            groupBoxPatientData.Controls.Add(labelEmail);
            groupBoxPatientData.Controls.Add(labelPhone);
            groupBoxPatientData.Controls.Add(labelName);
            groupBoxPatientData.Location = new Point(3, 3);
            groupBoxPatientData.Name = "groupBoxPatientData";
            groupBoxPatientData.Size = new Size(602, 100);
            groupBoxPatientData.TabIndex = 0;
            groupBoxPatientData.TabStop = false;
            groupBoxPatientData.Text = "Dados do paciente";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(513, 71);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Deletar";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(432, 71);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 3;
            buttonEdit.Text = "Editar";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(399, 36);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(42, 15);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email: ";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(211, 36);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(57, 15);
            labelPhone.TabIndex = 1;
            labelPhone.Text = "Telefone: ";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(32, 36);
            labelName.Name = "labelName";
            labelName.Size = new Size(46, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Nome: ";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1, 12);
            label1.Name = "label1";
            label1.Size = new Size(173, 42);
            label1.TabIndex = 8;
            label1.Text = "Pacientes";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panelPatient);
            Controls.Add(buttonNewPatient);
            Controls.Add(PatientList);
            Name = "FormHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Psicogest";
            Load += FormHome_Load;
            ((System.ComponentModel.ISupportInitialize)patientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource2).EndInit();
            panelPatient.ResumeLayout(false);
            groupBoxPatientData.ResumeLayout(false);
            groupBoxPatientData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource form1BindingSource;
        private BindingSource form1BindingSource1;
        private BindingSource patientBindingSource;
        private BindingSource form1BindingSource2;
        private ListBox PatientList;
        private Button buttonNewPatient;
        private Panel panelPatient;
        private GroupBox groupBoxPatientData;
        private Label labelName;
        private Label labelPhone;
        private Label labelEmail;
        private Button buttonEdit;
        private Button buttonAnamnese;
        private Button buttonDelete;
        private Label label1;
    }
}