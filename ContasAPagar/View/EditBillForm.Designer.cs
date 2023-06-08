namespace ContasAPagar
{
    partial class EditBillForm
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
            labelTitle = new Label();
            labelBillName = new Label();
            labelBillValue = new Label();
            labelCode = new Label();
            textBoxOldCode = new TextBox();
            textBoxBillName = new TextBox();
            textBoxBillValue = new TextBox();
            buttonEdit = new Button();
            textBoxCode = new TextBox();
            textBoxExpiration = new TextBox();
            labelBillCode = new Label();
            labelExpiration = new Label();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(236, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(340, 54);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "ALTERAR CONTAS";
            // 
            // labelBillName
            // 
            labelBillName.AutoSize = true;
            labelBillName.Location = new Point(101, 126);
            labelBillName.Name = "labelBillName";
            labelBillName.Size = new Size(169, 15);
            labelBillName.TabIndex = 1;
            labelBillName.Text = "Digite o Novo nome da conta: ";
            // 
            // labelBillValue
            // 
            labelBillValue.AutoSize = true;
            labelBillValue.Location = new Point(101, 223);
            labelBillValue.Name = "labelBillValue";
            labelBillValue.Size = new Size(156, 15);
            labelBillValue.TabIndex = 2;
            labelBillValue.Text = "Digite o novo valor da conta";
            // 
            // labelCode
            // 
            labelCode.AutoSize = true;
            labelCode.Location = new Point(101, 86);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(232, 15);
            labelCode.TabIndex = 3;
            labelCode.Text = "Digite o código da conta que deseja alterar";
            // 
            // textBoxOldCode
            // 
            textBoxOldCode.Location = new Point(476, 83);
            textBoxOldCode.Name = "textBoxOldCode";
            textBoxOldCode.Size = new Size(100, 23);
            textBoxOldCode.TabIndex = 4;
            // 
            // textBoxBillName
            // 
            textBoxBillName.Location = new Point(476, 135);
            textBoxBillName.Name = "textBoxBillName";
            textBoxBillName.Size = new Size(100, 23);
            textBoxBillName.TabIndex = 5;
            // 
            // textBoxBillValue
            // 
            textBoxBillValue.Location = new Point(476, 223);
            textBoxBillValue.Name = "textBoxBillValue";
            textBoxBillValue.Size = new Size(100, 23);
            textBoxBillValue.TabIndex = 6;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(352, 372);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(135, 46);
            buttonEdit.TabIndex = 7;
            buttonEdit.Text = "Alterar Conta";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // textBoxCode
            // 
            textBoxCode.Location = new Point(476, 178);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(100, 23);
            textBoxCode.TabIndex = 8;
            // 
            // textBoxExpiration
            // 
            textBoxExpiration.Location = new Point(476, 299);
            textBoxExpiration.Name = "textBoxExpiration";
            textBoxExpiration.Size = new Size(100, 23);
            textBoxExpiration.TabIndex = 9;
            // 
            // labelBillCode
            // 
            labelBillCode.AutoSize = true;
            labelBillCode.Location = new Point(103, 178);
            labelBillCode.Name = "labelBillCode";
            labelBillCode.Size = new Size(167, 15);
            labelBillCode.TabIndex = 10;
            labelBillCode.Text = "Digite o novo código da conta";
            // 
            // labelExpiration
            // 
            labelExpiration.AutoSize = true;
            labelExpiration.Location = new Point(121, 286);
            labelExpiration.Name = "labelExpiration";
            labelExpiration.Size = new Size(179, 15);
            labelExpiration.TabIndex = 11;
            labelExpiration.Text = "Digite a nova expiração da conta";
            // 
            // EditBillForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelExpiration);
            Controls.Add(labelBillCode);
            Controls.Add(textBoxExpiration);
            Controls.Add(textBoxCode);
            Controls.Add(buttonEdit);
            Controls.Add(textBoxBillValue);
            Controls.Add(textBoxBillName);
            Controls.Add(textBoxOldCode);
            Controls.Add(labelCode);
            Controls.Add(labelBillValue);
            Controls.Add(labelBillName);
            Controls.Add(labelTitle);
            Name = "EditBillForm";
            Text = "EditBillForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelBillName;
        private Label labelBillValue;
        private Label labelCode;
        private TextBox textBoxOldCode;
        private TextBox textBoxBillName;
        private TextBox textBoxBillValue;
        private Button buttonEdit;
        private TextBox textBoxCode;
        private TextBox textBoxExpiration;
        private Label labelBillCode;
        private Label labelExpiration;
    }
}