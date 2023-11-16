namespace Psicogest.Forms
{
    partial class FormEditPatient
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
            buttonSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxName = new TextBox();
            textBoxPhone = new TextBox();
            textBoxEmail = new TextBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(19, 238);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(198, 26);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Salvar";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 42);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 98);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 2;
            label2.Text = "Telefone de contato:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 153);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Email:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(19, 60);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(198, 23);
            textBoxName.TabIndex = 4;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(19, 116);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(198, 23);
            textBoxPhone.TabIndex = 5;
            textBoxPhone.KeyPress += textBoxPhone_KeyPress;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(16, 171);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(201, 23);
            textBoxEmail.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(buttonSave);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxPhone);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(247, 315);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Editar paciente";
            // 
            // FormEditPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 342);
            Controls.Add(groupBox1);
            Name = "FormEditPatient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEditPatient";
            Load += FormEditPatient_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxName;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private GroupBox groupBox1;
    }
}