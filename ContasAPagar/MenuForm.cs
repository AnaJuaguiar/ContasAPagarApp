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
    }
}
