namespace ContasAPagar
{
    partial class SearchForm
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
            textBox1 = new TextBox();
            LabelTitle = new Label();
            buttonSearch = new Button();
            labelInfo = new Label();
            dataGridViewSearch = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearch).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(299, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(263, 23);
            textBox1.TabIndex = 0;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelTitle.Location = new Point(349, 27);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(137, 37);
            LabelTitle.TabIndex = 1;
            LabelTitle.Text = "PESQUISA";
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(328, 173);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(158, 23);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Pesquisar Conta";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(328, 133);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(165, 15);
            labelInfo.TabIndex = 3;
            labelInfo.Text = "Digite aqui o código da Conta";
            // 
            // dataGridViewSearch
            // 
            dataGridViewSearch.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewSearch.BorderStyle = BorderStyle.None;
            dataGridViewSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSearch.Location = new Point(151, 212);
            dataGridViewSearch.Name = "dataGridViewSearch";
            dataGridViewSearch.RowTemplate.Height = 25;
            dataGridViewSearch.Size = new Size(535, 226);
            dataGridViewSearch.TabIndex = 4;
            dataGridViewSearch.CellContentClick += dataGridViewSearch_CellContentClick;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewSearch);
            Controls.Add(labelInfo);
            Controls.Add(buttonSearch);
            Controls.Add(LabelTitle);
            Controls.Add(textBox1);
            Name = "SearchForm";
            Text = "SearchForm";
            Load += SearchForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label LabelTitle;
        private Button buttonSearch;
        private Label labelInfo;
        private DataGridView dataGridViewSearch;
    }
}