using ContasAPagar.Model;
using System.Collections;
using System.Windows.Forms;
using System.Linq;

namespace ContasAPagar
{
    public partial class Menu : Form
    {
        private AllBills allBillsList;
        public Menu()
        {
            InitializeComponent();
            allBillsList = AllBills.Instance;
        }

        public void InsertButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        public void SearchButton_Click(object sender, EventArgs e)
        {

            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();

        }

        public void ShowButton_Click(object sender, EventArgs e)
        {

            FormListBills formListBills = new FormListBills();
            formListBills.ShowDialog();

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.ShowDialog();
        }

        private void AlterButton_Click(object sender, EventArgs e)
        {
            EditBillForm editBillForm = new EditBillForm();
            editBillForm.ShowDialog();
        }

        private void SaveXMLButton_Click(object sender, EventArgs e)
        {
            try
            {
                int result = allBillsList.SaveXml();

                MessageBox.Show("XML Salvo com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o XML: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            try
            {
                int result = allBillsList.ReadXml();

                if (result > 0)
                {
                    MessageBox.Show("Arquivo XML lido com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao ler o arquivo XML: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
