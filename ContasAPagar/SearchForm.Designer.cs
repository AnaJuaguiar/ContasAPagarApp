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
            labelTitle = new Label();
            labelHelper = new Label();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(328, 28);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(201, 54);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "PESQUISA";
            // 
            // labelHelper
            // 
            labelHelper.AutoSize = true;
            labelHelper.Location = new Point(344, 164);
            labelHelper.Name = "labelHelper";
            labelHelper.Size = new Size(134, 15);
            labelHelper.TabIndex = 1;
            labelHelper.Text = "Digite aqui sua pesquisa";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(307, 113);
            textBoxSearch.Multiline = true;
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(222, 38);
            textBoxSearch.TabIndex = 2;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(337, 278);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(141, 69);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "PESQUISAR";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(labelHelper);
            Controls.Add(labelTitle);
            Name = "SearchForm";
            Text = "SearchForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelHelper;
        private TextBox textBoxSearch;
        private Button buttonSearch;
    }
}