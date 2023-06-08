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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Reem Kufi", 30F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.DarkRed;
            labelTitle.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            labelTitle.Location = new Point(264, 2);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(299, 76);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Excluir Contas";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Linen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(145, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(540, 191);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // labelHelper
            // 
            labelHelper.AutoSize = true;
            labelHelper.Font = new Font("Reem Kufi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelHelper.ForeColor = Color.DarkRed;
            labelHelper.Location = new Point(258, 67);
            labelHelper.Name = "labelHelper";
            labelHelper.Size = new Size(305, 30);
            labelHelper.TabIndex = 2;
            labelHelper.Text = "Listagem de todas as contas Cadastradas";
            labelHelper.Click += label2_Click;
            // 
            // buttonDeleteAccount
            // 
            buttonDeleteAccount.BackColor = Color.Firebrick;
            buttonDeleteAccount.FlatStyle = FlatStyle.Flat;
            buttonDeleteAccount.Font = new Font("Reem Kufi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDeleteAccount.ForeColor = SystemColors.ButtonHighlight;
            buttonDeleteAccount.Location = new Point(145, 335);
            buttonDeleteAccount.Name = "buttonDeleteAccount";
            buttonDeleteAccount.Size = new Size(179, 59);
            buttonDeleteAccount.TabIndex = 3;
            buttonDeleteAccount.Text = "Deletar Conta";
            buttonDeleteAccount.UseVisualStyleBackColor = false;
            buttonDeleteAccount.Click += buttonDeleteAccount_Click;
            // 
            // buttonDeleteAll
            // 
            buttonDeleteAll.BackColor = Color.DarkRed;
            buttonDeleteAll.FlatStyle = FlatStyle.Flat;
            buttonDeleteAll.Font = new Font("Reem Kufi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDeleteAll.ForeColor = SystemColors.ControlLightLight;
            buttonDeleteAll.Location = new Point(599, 335);
            buttonDeleteAll.Name = "buttonDeleteAll";
            buttonDeleteAll.Size = new Size(189, 59);
            buttonDeleteAll.TabIndex = 4;
            buttonDeleteAll.Text = "Deletar Tudo";
            buttonDeleteAll.UseVisualStyleBackColor = false;
            buttonDeleteAll.Click += buttonDeleteAll_Click;
            // 
            // textBoxDelete
            // 
            textBoxDelete.Font = new Font("Reem Kufi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDelete.Location = new Point(12, 335);
            textBoxDelete.Multiline = true;
            textBoxDelete.Name = "textBoxDelete";
            textBoxDelete.Size = new Size(127, 59);
            textBoxDelete.TabIndex = 5;
            // 
            // labelHelper2
            // 
            labelHelper2.AutoSize = true;
            labelHelper2.Font = new Font("Reem Kufi", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelHelper2.ForeColor = Color.DarkRed;
            labelHelper2.Location = new Point(12, 294);
            labelHelper2.Name = "labelHelper2";
            labelHelper2.Size = new Size(397, 38);
            labelHelper2.TabIndex = 6;
            labelHelper2.Text = "Digite o código da conta que deseja deletar";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bill__5_;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 66);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bill__5_;
            pictureBox2.Location = new Point(688, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 66);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // DeleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(labelHelper2);
            Controls.Add(textBoxDelete);
            Controls.Add(buttonDeleteAll);
            Controls.Add(buttonDeleteAccount);
            Controls.Add(labelHelper);
            Controls.Add(dataGridView1);
            Controls.Add(labelTitle);
            Name = "DeleteForm";
            Text = "EditAndDeleteForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}