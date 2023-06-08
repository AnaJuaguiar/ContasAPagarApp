using ContasAPagar.Model;

namespace ContasAPagar
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            Title = new Label();
            InsertButton = new Button();
            AlterButton = new Button();
            DeleteButton = new Button();
            SearchButton = new Button();
            ShowButton = new Button();
            SaveXMLButton = new Button();
            ReadButton = new Button();
            SairButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Reem Kufi", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Title.Location = new Point(233, 12);
            Title.Name = "Title";
            Title.Size = new Size(361, 51);
            Title.TabIndex = 0;
            Title.Text = "MENU CONTAS A PAGAR";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InsertButton
            // 
            InsertButton.BackColor = SystemColors.Window;
            InsertButton.FlatAppearance.BorderSize = 0;
            InsertButton.FlatStyle = FlatStyle.Flat;
            InsertButton.Image = (Image)resources.GetObject("InsertButton.Image");
            InsertButton.Location = new Point(549, 159);
            InsertButton.Name = "InsertButton";
            InsertButton.Size = new Size(68, 82);
            InsertButton.TabIndex = 1;
            InsertButton.UseVisualStyleBackColor = false;
            InsertButton.Click += InsertButton_Click;
            // 
            // AlterButton
            // 
            AlterButton.BackColor = SystemColors.ButtonHighlight;
            AlterButton.FlatAppearance.BorderSize = 0;
            AlterButton.FlatStyle = FlatStyle.Flat;
            AlterButton.ForeColor = SystemColors.Control;
            AlterButton.Image = (Image)resources.GetObject("AlterButton.Image");
            AlterButton.Location = new Point(193, 162);
            AlterButton.Name = "AlterButton";
            AlterButton.Size = new Size(116, 82);
            AlterButton.TabIndex = 2;
            AlterButton.UseCompatibleTextRendering = true;
            AlterButton.UseVisualStyleBackColor = false;
            AlterButton.Click += AlterButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = SystemColors.Window;
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Image = (Image)resources.GetObject("DeleteButton.Image");
            DeleteButton.Location = new Point(355, 159);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(89, 85);
            DeleteButton.TabIndex = 3;
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = SystemColors.Window;
            SearchButton.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 128);
            SearchButton.FlatAppearance.BorderSize = 0;
            SearchButton.FlatAppearance.MouseDownBackColor = Color.Honeydew;
            SearchButton.FlatAppearance.MouseOverBackColor = Color.Thistle;
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.ForeColor = SystemColors.Control;
            SearchButton.Image = (Image)resources.GetObject("SearchButton.Image");
            SearchButton.Location = new Point(75, 170);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(67, 67);
            SearchButton.TabIndex = 4;
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // ShowButton
            // 
            ShowButton.BackColor = SystemColors.Window;
            ShowButton.FlatAppearance.BorderSize = 0;
            ShowButton.FlatStyle = FlatStyle.Flat;
            ShowButton.Image = (Image)resources.GetObject("ShowButton.Image");
            ShowButton.Location = new Point(709, 163);
            ShowButton.Name = "ShowButton";
            ShowButton.Size = new Size(69, 76);
            ShowButton.TabIndex = 5;
            ShowButton.UseVisualStyleBackColor = false;
            ShowButton.Click += ShowButton_Click;
            // 
            // SaveXMLButton
            // 
            SaveXMLButton.BackColor = SystemColors.Window;
            SaveXMLButton.FlatAppearance.BorderSize = 0;
            SaveXMLButton.FlatStyle = FlatStyle.Flat;
            SaveXMLButton.Image = (Image)resources.GetObject("SaveXMLButton.Image");
            SaveXMLButton.Location = new Point(375, 299);
            SaveXMLButton.Name = "SaveXMLButton";
            SaveXMLButton.Size = new Size(53, 72);
            SaveXMLButton.TabIndex = 7;
            SaveXMLButton.UseVisualStyleBackColor = false;
            SaveXMLButton.Click += SaveXMLButton_Click;
            // 
            // ReadButton
            // 
            ReadButton.FlatAppearance.BorderSize = 0;
            ReadButton.FlatStyle = FlatStyle.Flat;
            ReadButton.Image = (Image)resources.GetObject("ReadButton.Image");
            ReadButton.Location = new Point(517, 299);
            ReadButton.Name = "ReadButton";
            ReadButton.Size = new Size(67, 72);
            ReadButton.TabIndex = 8;
            ReadButton.UseVisualStyleBackColor = true;
            ReadButton.Click += ReadButton_Click;
            // 
            // SairButton
            // 
            SairButton.Location = new Point(22, 415);
            SairButton.Name = "SairButton";
            SairButton.Size = new Size(75, 23);
            SairButton.TabIndex = 9;
            SairButton.Text = "Sair";
            SairButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(103, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 73);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(690, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 76);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Reem Kufi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 240);
            label1.Name = "label1";
            label1.Size = new Size(136, 30);
            label1.TabIndex = 12;
            label1.Text = "Pesquisar Contas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Reem Kufi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(193, 240);
            label2.Name = "label2";
            label2.Size = new Size(116, 30);
            label2.TabIndex = 13;
            label2.Text = "Alterar Contas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Reem Kufi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(355, 239);
            label3.Name = "label3";
            label3.Size = new Size(119, 30);
            label3.TabIndex = 14;
            label3.Text = "Deletar Contas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Reem Kufi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(517, 239);
            label4.Name = "label4";
            label4.Size = new Size(137, 30);
            label4.TabIndex = 15;
            label4.Text = "Caadastrar conta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Reem Kufi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(679, 251);
            label5.Name = "label5";
            label5.Size = new Size(152, 30);
            label5.TabIndex = 16;
            label5.Text = "Ver Todas as Contas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Reem Kufi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(355, 372);
            label6.Name = "label6";
            label6.Size = new Size(96, 30);
            label6.TabIndex = 17;
            label6.Text = "Salvar XML";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Reem Kufi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(517, 372);
            label7.Name = "label7";
            label7.Size = new Size(75, 30);
            label7.TabIndex = 18;
            label7.Text = "Ler XML";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(884, 411);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(SairButton);
            Controls.Add(ReadButton);
            Controls.Add(SaveXMLButton);
            Controls.Add(ShowButton);
            Controls.Add(SearchButton);
            Controls.Add(DeleteButton);
            Controls.Add(AlterButton);
            Controls.Add(InsertButton);
            Controls.Add(Title);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menu";
            Text = "Contas A Pagar Menu";
            TransparencyKey = Color.FromArgb(255, 192, 192);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Button InsertButton;
        private Button AlterButton;
        private Button DeleteButton;
        private Button SearchButton;
        private Button ShowButton;
        private Button SaveXMLButton;
        private Button ReadButton;
        private Button SairButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}