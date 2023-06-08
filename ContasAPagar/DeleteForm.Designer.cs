namespace ContasAPagar
{
    partial class DeleteForm
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
            dataGridView1 = new DataGridView();
            labelHelper = new Label();
            buttonDeleteAccount = new Button();
            buttonDeleteAll = new Button();
            textBoxDelete = new TextBox();
            labelHelper2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(288, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(269, 54);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Excluir Contas";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(228, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(383, 195);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // labelHelper
            // 
            labelHelper.AutoSize = true;
            labelHelper.Location = new Point(305, 78);
            labelHelper.Name = "labelHelper";
            labelHelper.Size = new Size(222, 15);
            labelHelper.TabIndex = 2;
            labelHelper.Text = "Listagem de todas as contas Cadastradas";
            labelHelper.Click += label2_Click;
            // 
            // buttonDeleteAccount
            // 
            buttonDeleteAccount.Location = new Point(68, 399);
            buttonDeleteAccount.Name = "buttonDeleteAccount";
            buttonDeleteAccount.Size = new Size(115, 23);
            buttonDeleteAccount.TabIndex = 3;
            buttonDeleteAccount.Text = "Deletar Conta";
            buttonDeleteAccount.UseVisualStyleBackColor = true;
            buttonDeleteAccount.Click += buttonDeleteAccount_Click;
            // 
            // buttonDeleteAll
            // 
            buttonDeleteAll.Location = new Point(636, 368);
            buttonDeleteAll.Name = "buttonDeleteAll";
            buttonDeleteAll.Size = new Size(97, 41);
            buttonDeleteAll.TabIndex = 4;
            buttonDeleteAll.Text = "Deletar Tudo";
            buttonDeleteAll.UseVisualStyleBackColor = true;
            buttonDeleteAll.Click += buttonDeleteAll_Click;
            // 
            // textBoxDelete
            // 
            textBoxDelete.Location = new Point(83, 344);
            textBoxDelete.Name = "textBoxDelete";
            textBoxDelete.Size = new Size(100, 23);
            textBoxDelete.TabIndex = 5;
            // 
            // labelHelper2
            // 
            labelHelper2.AutoSize = true;
            labelHelper2.Location = new Point(22, 309);
            labelHelper2.Name = "labelHelper2";
            labelHelper2.Size = new Size(235, 15);
            labelHelper2.TabIndex = 6;
            labelHelper2.Text = "Digite o código da conta que deseja deletar";
            // 
            // EditAndDeleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelHelper2);
            Controls.Add(textBoxDelete);
            Controls.Add(buttonDeleteAll);
            Controls.Add(buttonDeleteAccount);
            Controls.Add(labelHelper);
            Controls.Add(dataGridView1);
            Controls.Add(labelTitle);
            Name = "EditAndDeleteForm";
            Text = "EditAndDeleteForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private DataGridView dataGridView1;
        private Label labelHelper;
        private Button buttonDeleteAccount;
        private Button buttonDeleteAll;
        private TextBox textBoxDelete;
        private Label labelHelper2;
    }
}