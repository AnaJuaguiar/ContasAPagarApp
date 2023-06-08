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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            labelTitle = new Label();
            labelHelper = new Label();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
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
            labelTitle.BackColor = SystemColors.Window;
            labelTitle.Font = new Font("Reem Kufi", 35F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.DarkMagenta;
            labelTitle.Location = new Point(271, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(284, 89);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "PESQUISA";
            // 
            // labelHelper
            // 
            labelHelper.AutoSize = true;
            labelHelper.Font = new Font("Reem Kufi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelHelper.ForeColor = Color.DarkMagenta;
            labelHelper.Location = new Point(235, 224);
            labelHelper.Name = "labelHelper";
            labelHelper.Size = new Size(365, 30);
            labelHelper.TabIndex = 1;
            labelHelper.Text = "Digite aqui o código da conta que deseja pesquisar";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Reem Kufi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(313, 140);
            textBoxSearch.Multiline = true;
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(287, 67);
            textBoxSearch.TabIndex = 2;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.Purple;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Reem Kufi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSearch.ForeColor = SystemColors.ControlLightLight;
            buttonSearch.Location = new Point(310, 319);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(185, 83);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "PESQUISAR";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bill__5_;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 67);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bill__5_;
            pictureBox2.Location = new Point(688, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 67);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(235, 140);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(72, 67);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(labelHelper);
            Controls.Add(labelTitle);
            Name = "SearchForm";
            Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelHelper;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}