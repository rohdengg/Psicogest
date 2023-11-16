namespace Psicogest
{
    partial class FormUserRegister
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
            groupBoxUserRegister = new GroupBox();
            buttonRegister = new Button();
            label3 = new Label();
            textBoxUserPassword = new TextBox();
            label2 = new Label();
            textBoxUserConfirmPassword = new TextBox();
            textBoxUserName = new TextBox();
            label1 = new Label();
            groupBoxUserRegister.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUserRegister
            // 
            groupBoxUserRegister.Controls.Add(buttonRegister);
            groupBoxUserRegister.Controls.Add(label3);
            groupBoxUserRegister.Controls.Add(textBoxUserPassword);
            groupBoxUserRegister.Controls.Add(label2);
            groupBoxUserRegister.Controls.Add(textBoxUserConfirmPassword);
            groupBoxUserRegister.Controls.Add(textBoxUserName);
            groupBoxUserRegister.Controls.Add(label1);
            groupBoxUserRegister.Location = new Point(24, 48);
            groupBoxUserRegister.Name = "groupBoxUserRegister";
            groupBoxUserRegister.Size = new Size(303, 260);
            groupBoxUserRegister.TabIndex = 0;
            groupBoxUserRegister.TabStop = false;
            groupBoxUserRegister.Text = "Novo usuário";
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(19, 211);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(95, 29);
            buttonRegister.TabIndex = 7;
            buttonRegister.Text = "Cadastrar";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 152);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 6;
            label3.Text = "Confirmar senha";
            // 
            // textBoxUserPassword
            // 
            textBoxUserPassword.Location = new Point(19, 110);
            textBoxUserPassword.Name = "textBoxUserPassword";
            textBoxUserPassword.Size = new Size(215, 23);
            textBoxUserPassword.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 92);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // textBoxUserConfirmPassword
            // 
            textBoxUserConfirmPassword.Location = new Point(19, 170);
            textBoxUserConfirmPassword.Name = "textBoxUserConfirmPassword";
            textBoxUserConfirmPassword.Size = new Size(215, 23);
            textBoxUserConfirmPassword.TabIndex = 3;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(19, 52);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(215, 23);
            textBoxUserName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 34);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome de usuário";
            // 
            // FormUserRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 341);
            Controls.Add(groupBoxUserRegister);
            MaximizeBox = false;
            Name = "FormUserRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUserRegister";
            groupBoxUserRegister.ResumeLayout(false);
            groupBoxUserRegister.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUserRegister;
        private Label label1;
        private TextBox textBoxUserConfirmPassword;
        private TextBox textBoxUserName;
        private Label label3;
        private TextBox textBoxUserPassword;
        private Label label2;
        private Button buttonRegister;
    }
}