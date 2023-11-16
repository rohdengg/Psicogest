namespace Psicogest.Forms
{
    partial class FormPatientRegister
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
            groupBoxNewPatient = new GroupBox();
            buttonRegister = new Button();
            textBoxEmail = new TextBox();
            label3 = new Label();
            textBoxPhone = new TextBox();
            label2 = new Label();
            textBoxName = new TextBox();
            label1 = new Label();
            groupBoxNewPatient.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxNewPatient
            // 
            groupBoxNewPatient.Controls.Add(buttonRegister);
            groupBoxNewPatient.Controls.Add(textBoxEmail);
            groupBoxNewPatient.Controls.Add(label3);
            groupBoxNewPatient.Controls.Add(textBoxPhone);
            groupBoxNewPatient.Controls.Add(label2);
            groupBoxNewPatient.Controls.Add(textBoxName);
            groupBoxNewPatient.Controls.Add(label1);
            groupBoxNewPatient.Location = new Point(12, 12);
            groupBoxNewPatient.Name = "groupBoxNewPatient";
            groupBoxNewPatient.Size = new Size(254, 269);
            groupBoxNewPatient.TabIndex = 0;
            groupBoxNewPatient.TabStop = false;
            groupBoxNewPatient.Text = "Novo paciente";
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(12, 212);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(200, 28);
            buttonRegister.TabIndex = 7;
            buttonRegister.Text = "Cadastrar";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(12, 155);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(200, 23);
            textBoxEmail.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 137);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(12, 102);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(200, 23);
            textBoxPhone.TabIndex = 4;
            textBoxPhone.KeyPress += textBoxPhone_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 3;
            label2.Text = "Telefone de contato";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 46);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(200, 23);
            textBoxName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome completo";
            // 
            // FormPatientRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 297);
            Controls.Add(groupBoxNewPatient);
            Name = "FormPatientRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo paciente";
            groupBoxNewPatient.ResumeLayout(false);
            groupBoxNewPatient.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxNewPatient;
        private Label label1;
        private TextBox textBoxName;
        private Label label2;
        private Label label3;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private Button buttonRegister;
    }
}