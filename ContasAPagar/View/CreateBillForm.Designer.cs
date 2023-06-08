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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
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
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            TitleRegister.Font = new Font("Reem Kufi", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            TitleRegister.ForeColor = Color.DarkOliveGreen;
            TitleRegister.Location = new Point(198, 8);
            TitleRegister.Name = "TitleRegister";
            TitleRegister.Size = new Size(422, 51);
            TitleRegister.TabIndex = 1;
            TitleRegister.Text = "CADASTRO DE NOVA CONTA";
            // 
            // BillName
            // 
            BillName.AutoSize = true;
            BillName.BackColor = SystemColors.InactiveBorder;
            BillName.Font = new Font("Reem Kufi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BillName.Location = new Point(172, 125);
            BillName.Name = "BillName";
            BillName.Size = new Size(186, 46);
            BillName.TabIndex = 2;
            BillName.Text = "Nome da Conta";
            // 
            // CodeBillLabel
            // 
            CodeBillLabel.AutoSize = true;
            CodeBillLabel.Font = new Font("Reem Kufi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CodeBillLabel.Location = new Point(173, 181);
            CodeBillLabel.Name = "CodeBillLabel";
            CodeBillLabel.Size = new Size(201, 46);
            CodeBillLabel.TabIndex = 3;
            CodeBillLabel.Text = "Código de Barras";
            // 
            // ValueBill
            // 
            ValueBill.AutoSize = true;
            ValueBill.Font = new Font("Reem Kufi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ValueBill.Location = new Point(174, 237);
            ValueBill.Name = "ValueBill";
            ValueBill.Size = new Size(176, 46);
            ValueBill.TabIndex = 4;
            ValueBill.Text = "Valor da Conta";
            // 
            // ExpirationAccount
            // 
            ExpirationAccount.AutoSize = true;
            ExpirationAccount.Font = new Font("Reem Kufi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ExpirationAccount.Location = new Point(172, 292);
            ExpirationAccount.Name = "ExpirationAccount";
            ExpirationAccount.Size = new Size(145, 46);
            ExpirationAccount.TabIndex = 5;
            ExpirationAccount.Text = "Vencimento";
            // 
            // textBoxNameBill
            // 
            textBoxNameBill.BackColor = Color.Honeydew;
            textBoxNameBill.Font = new Font("Reem Kufi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNameBill.Location = new Point(400, 125);
            textBoxNameBill.Multiline = true;
            textBoxNameBill.Name = "textBoxNameBill";
            textBoxNameBill.Size = new Size(244, 48);
            textBoxNameBill.TabIndex = 6;
            textBoxNameBill.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCodeBill
            // 
            textBoxCodeBill.BackColor = Color.Honeydew;
            textBoxCodeBill.Font = new Font("Reem Kufi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCodeBill.Location = new Point(400, 179);
            textBoxCodeBill.Multiline = true;
            textBoxCodeBill.Name = "textBoxCodeBill";
            textBoxCodeBill.Size = new Size(244, 51);
            textBoxCodeBill.TabIndex = 7;
            // 
            // textBoxValueBill
            // 
            textBoxValueBill.BackColor = Color.Honeydew;
            textBoxValueBill.Font = new Font("Reem Kufi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxValueBill.Location = new Point(400, 232);
            textBoxValueBill.Name = "textBoxValueBill";
            textBoxValueBill.Size = new Size(155, 53);
            textBoxValueBill.TabIndex = 8;
            textBoxValueBill.TextAlign = HorizontalAlignment.Center;
            // 
            // textExpirationBill
            // 
            textExpirationBill.BackColor = Color.Honeydew;
            textExpirationBill.Font = new Font("Reem Kufi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textExpirationBill.Location = new Point(400, 292);
            textExpirationBill.Name = "textExpirationBill";
            textExpirationBill.Size = new Size(169, 53);
            textExpirationBill.TabIndex = 9;
            // 
            // ButtonCreateBill
            // 
            ButtonCreateBill.BackColor = Color.DarkOliveGreen;
            ButtonCreateBill.FlatAppearance.BorderSize = 0;
            ButtonCreateBill.FlatStyle = FlatStyle.Flat;
            ButtonCreateBill.Font = new Font("Reem Kufi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonCreateBill.ForeColor = SystemColors.ControlLight;
            ButtonCreateBill.Location = new Point(299, 360);
            ButtonCreateBill.Name = "ButtonCreateBill";
            ButtonCreateBill.Size = new Size(178, 54);
            ButtonCreateBill.TabIndex = 10;
            ButtonCreateBill.Text = "Cadastrar Conta";
            ButtonCreateBill.UseVisualStyleBackColor = false;
            ButtonCreateBill.Click += buttonCreateBill_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._9049302a132dd7448288de6480539da1;
            pictureBox2.Location = new Point(115, 63);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(566, 368);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 74);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(688, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(63, 76);
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
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
            Controls.Add(pictureBox2);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            Name = "RegistrationForm";
            Text = "Formulário de Cadastro";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
    }
}