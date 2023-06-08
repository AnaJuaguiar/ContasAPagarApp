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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBillForm));
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Reem Kufi", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.DarkCyan;
            labelTitle.Location = new Point(274, 11);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(277, 51);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "ALTERAR CONTAS";
            // 
            // labelBillName
            // 
            labelBillName.AutoSize = true;
            labelBillName.Font = new Font("Reem Kufi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelBillName.Location = new Point(144, 162);
            labelBillName.Name = "labelBillName";
            labelBillName.Size = new Size(218, 30);
            labelBillName.TabIndex = 1;
            labelBillName.Text = "Digite o Novo nome da conta: ";
            // 
            // labelBillValue
            // 
            labelBillValue.AutoSize = true;
            labelBillValue.Font = new Font("Reem Kufi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelBillValue.Location = new Point(145, 263);
            labelBillValue.Name = "labelBillValue";
            labelBillValue.Size = new Size(206, 30);
            labelBillValue.TabIndex = 2;
            labelBillValue.Text = "Digite o novo valor da conta";
            // 
            // labelCode
            // 
            labelCode.AutoSize = true;
            labelCode.Font = new Font("Reem Kufi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCode.Location = new Point(144, 96);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(309, 30);
            labelCode.TabIndex = 3;
            labelCode.Text = "Digite o código da conta que deseja alterar";
            // 
            // textBoxOldCode
            // 
            textBoxOldCode.Font = new Font("Reem Kufi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxOldCode.Location = new Point(497, 96);
            textBoxOldCode.Multiline = true;
            textBoxOldCode.Name = "textBoxOldCode";
            textBoxOldCode.Size = new Size(147, 30);
            textBoxOldCode.TabIndex = 4;
            // 
            // textBoxBillName
            // 
            textBoxBillName.Location = new Point(466, 162);
            textBoxBillName.Multiline = true;
            textBoxBillName.Name = "textBoxBillName";
            textBoxBillName.Size = new Size(178, 30);
            textBoxBillName.TabIndex = 5;
            // 
            // textBoxBillValue
            // 
            textBoxBillValue.Location = new Point(466, 263);
            textBoxBillValue.Multiline = true;
            textBoxBillValue.Name = "textBoxBillValue";
            textBoxBillValue.Size = new Size(178, 30);
            textBoxBillValue.TabIndex = 6;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.DarkCyan;
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Reem Kufi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.ForeColor = Color.MintCream;
            buttonEdit.Location = new Point(313, 353);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(213, 65);
            buttonEdit.TabIndex = 7;
            buttonEdit.Text = "Alterar Conta";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // textBoxCode
            // 
            textBoxCode.Location = new Point(466, 216);
            textBoxCode.Multiline = true;
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(178, 30);
            textBoxCode.TabIndex = 8;
            // 
            // textBoxExpiration
            // 
            textBoxExpiration.Location = new Point(466, 317);
            textBoxExpiration.Multiline = true;
            textBoxExpiration.Name = "textBoxExpiration";
            textBoxExpiration.Size = new Size(178, 30);
            textBoxExpiration.TabIndex = 9;
            // 
            // labelBillCode
            // 
            labelBillCode.AutoSize = true;
            labelBillCode.Font = new Font("Reem Kufi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelBillCode.Location = new Point(144, 216);
            labelBillCode.Name = "labelBillCode";
            labelBillCode.Size = new Size(219, 30);
            labelBillCode.TabIndex = 10;
            labelBillCode.Text = "Digite o novo código da conta";
            // 
            // labelExpiration
            // 
            labelExpiration.AutoSize = true;
            labelExpiration.Font = new Font("Reem Kufi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelExpiration.Location = new Point(144, 317);
            labelExpiration.Name = "labelExpiration";
            labelExpiration.Size = new Size(240, 30);
            labelExpiration.TabIndex = 11;
            labelExpiration.Text = "Digite a nova expiração da conta";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 68);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(688, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 68);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(117, 65);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(566, 361);
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // EditBillForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
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
            Controls.Add(pictureBox3);
            Name = "EditBillForm";
            Text = "EditBillForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}