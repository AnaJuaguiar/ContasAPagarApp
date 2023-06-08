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
            Title = new Label();
            InsertButton = new Button();
            AlterButton = new Button();
            DeleteButton = new Button();
            SearchButton = new Button();
            ShowButton = new Button();
            SaveXMLButton = new Button();
            ReadButton = new Button();
            SairButton = new Button();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Title.Location = new Point(184, 36);
            Title.Name = "Title";
            Title.Size = new Size(401, 37);
            Title.TabIndex = 0;
            Title.Text = "FORMULÁRIO CONTAS A PAGAR";
            // 
            // InsertButton
            // 
            InsertButton.Location = new Point(139, 353);
            InsertButton.Name = "InsertButton";
            InsertButton.Size = new Size(120, 23);
            InsertButton.TabIndex = 1;
            InsertButton.Text = "Inserir Nova Conta";
            InsertButton.UseVisualStyleBackColor = true;
            InsertButton.Click += InsertButton_Click;
            // 
            // AlterButton
            // 
            AlterButton.Location = new Point(22, 353);
            AlterButton.Name = "AlterButton";
            AlterButton.Size = new Size(98, 23);
            AlterButton.TabIndex = 2;
            AlterButton.Text = "Alterar Contas";
            AlterButton.UseCompatibleTextRendering = true;
            AlterButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(561, 314);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(102, 23);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Deletar Contas";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(22, 314);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 4;
            SearchButton.Text = "Pesquisar Contas";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // ShowButton
            // 
            ShowButton.Location = new Point(370, 314);
            ShowButton.Name = "ShowButton";
            ShowButton.Size = new Size(174, 23);
            ShowButton.TabIndex = 5;
            ShowButton.Text = "Mostrar Contas Cadastradas";
            ShowButton.UseVisualStyleBackColor = true;
            ShowButton.Click += ShowButton_Click;
            // 
            // SaveXMLButton
            // 
            SaveXMLButton.Location = new Point(103, 314);
            SaveXMLButton.Name = "SaveXMLButton";
            SaveXMLButton.Size = new Size(114, 23);
            SaveXMLButton.TabIndex = 7;
            SaveXMLButton.Text = "Salvar em XML";
            SaveXMLButton.UseVisualStyleBackColor = true;
            // 
            // ReadButton
            // 
            ReadButton.Location = new Point(223, 314);
            ReadButton.Name = "ReadButton";
            ReadButton.Size = new Size(141, 23);
            ReadButton.TabIndex = 8;
            ReadButton.Text = "Ler Dados xml";
            ReadButton.UseVisualStyleBackColor = true;
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
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(SairButton);
            Controls.Add(ReadButton);
            Controls.Add(SaveXMLButton);
            Controls.Add(ShowButton);
            Controls.Add(SearchButton);
            Controls.Add(DeleteButton);
            Controls.Add(AlterButton);
            Controls.Add(InsertButton);
            Controls.Add(Title);
            Name = "Menu";
            Text = "Form1";
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
    }
}