namespace ContasAPagar
{
    partial class RegistrationForm
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
            linkLabel1 = new LinkLabel();
            TitleRegister = new Label();
            BillName = new Label();
            CodeBillLabel = new Label();
            ValueBill = new Label();
            ExpirationAccount = new Label();
            textBoxNameBill = new TextBox();
            textBoxCodeBill = new TextBox();
            textBoxValueBill = new TextBox();
            textExpirationBill = new TextBox();
            ButtonCreateBill = new Button();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(312, 34);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 0;
            // 
            // TitleRegister
            // 
            TitleRegister.AutoSize = true;
            TitleRegister.Font = new Font("Courier New", 22F, FontStyle.Regular, GraphicsUnit.Point);
            TitleRegister.Location = new Point(186, 16);
            TitleRegister.Name = "TitleRegister";
            TitleRegister.Size = new Size(411, 33);
            TitleRegister.TabIndex = 1;
            TitleRegister.Text = "CADASTRO DE NOVA CONTA";
            // 
            // BillName
            // 
            BillName.AutoSize = true;
            BillName.Font = new Font("Courier New", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BillName.Location = new Point(55, 121);
            BillName.Name = "BillName";
            BillName.Size = new Size(153, 21);
            BillName.TabIndex = 2;
            BillName.Text = "Nome da Conta";
            // 
            // CodeBillLabel
            // 
            CodeBillLabel.AutoSize = true;
            CodeBillLabel.Font = new Font("Courier New", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CodeBillLabel.Location = new Point(55, 171);
            CodeBillLabel.Name = "CodeBillLabel";
            CodeBillLabel.Size = new Size(186, 21);
            CodeBillLabel.TabIndex = 3;
            CodeBillLabel.Text = "Código de Barras";
            // 
            // ValueBill
            // 
            ValueBill.AutoSize = true;
            ValueBill.Font = new Font("Courier New", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ValueBill.Location = new Point(55, 216);
            ValueBill.Name = "ValueBill";
            ValueBill.Size = new Size(164, 21);
            ValueBill.TabIndex = 4;
            ValueBill.Text = "Valor da Conta";
            // 
            // ExpirationAccount
            // 
            ExpirationAccount.AutoSize = true;
            ExpirationAccount.Font = new Font("Courier New", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ExpirationAccount.Location = new Point(55, 262);
            ExpirationAccount.Name = "ExpirationAccount";
            ExpirationAccount.Size = new Size(120, 21);
            ExpirationAccount.TabIndex = 5;
            ExpirationAccount.Text = "Vencimento";
            // 
            // textBoxNameBill
            // 
            textBoxNameBill.Location = new Point(312, 121);
            textBoxNameBill.Name = "textBoxNameBill";
            textBoxNameBill.Size = new Size(211, 23);
            textBoxNameBill.TabIndex = 6;
            textBoxNameBill.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCodeBill
            // 
            textBoxCodeBill.Location = new Point(312, 159);
            textBoxCodeBill.Name = "textBoxCodeBill";
            textBoxCodeBill.Size = new Size(306, 23);
            textBoxCodeBill.TabIndex = 7;
            // 
            // textBoxValueBill
            // 
            textBoxValueBill.Location = new Point(312, 217);
            textBoxValueBill.Name = "textBoxValueBill";
            textBoxValueBill.Size = new Size(306, 23);
            textBoxValueBill.TabIndex = 8;
            // 
            // textExpirationBill
            // 
            textExpirationBill.Location = new Point(312, 262);
            textExpirationBill.Name = "textExpirationBill";
            textExpirationBill.Size = new Size(306, 23);
            textExpirationBill.TabIndex = 9;
            // 
            // ButtonCreateBill
            // 
            ButtonCreateBill.Location = new Point(263, 354);
            ButtonCreateBill.Name = "ButtonCreateBill";
            ButtonCreateBill.Size = new Size(178, 54);
            ButtonCreateBill.TabIndex = 10;
            ButtonCreateBill.Text = "Cadastrar Conta";
            ButtonCreateBill.UseVisualStyleBackColor = true;
            ButtonCreateBill.Click += buttonCreateBill_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonCreateBill);
            Controls.Add(textExpirationBill);
            Controls.Add(textBoxValueBill);
            Controls.Add(textBoxCodeBill);
            Controls.Add(textBoxNameBill);
            Controls.Add(ExpirationAccount);
            Controls.Add(ValueBill);
            Controls.Add(CodeBillLabel);
            Controls.Add(BillName);
            Controls.Add(TitleRegister);
            Controls.Add(linkLabel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            Name = "RegistrationForm";
            Text = "Formulário de Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Label TitleRegister;
        private Label BillName;
        private Label CodeBillLabel;
        private Label ValueBill;
        private Label ExpirationAccount;
        private TextBox textBoxNameBill;
        private TextBox textBoxCodeBill;
        private TextBox textBoxValueBill;
        private TextBox textExpirationBill;
        private Button ButtonCreateBill;
    }
}