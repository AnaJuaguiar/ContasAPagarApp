
using ContasAPagar.Model;
using System.Collections;
using System.Windows.Forms;
using System.Linq;

namespace ContasAPagar
{
    public partial class Menu : Form
    {
        //private ArrayList listaDados;
        private List<Bill> listaDados;
        public Menu()
        {
            InitializeComponent();
            ConfigureDataGridView();

            // Preencher o ArrayList com dados
            PreencherListaDados(dataGridView1);

            // Associar o ArrayList ao DataGridView
            dataGridView1.DataSource = listaDados;

        }
        private void PreencherListaDados(DataGridView dataGridView1)
        {
            /*
            // Simulação de preenchimento do ArrayList
            listaDados = new ArrayList();
            listaDados.Add("Item 555551");
            listaDados.Add("Item 2");
            listaDados.Add("Item 3");
            
            */
            List<Bill> listaDados = new List<Bill>();

            Bill bill1 = new Bill("Conta de Luz", "001", 23.80, new DateTime(2023 - 05 - 22));
            Bill bill2 = new Bill("Conta de Agua", "002", 23.80, new DateTime(2023 - 05 - 22));
            Bill bill3 = new Bill("Conta de Telefone", "003", 23.80, new DateTime(2023 - 05 - 22));



            listaDados.Add(bill1);
            listaDados.Add(bill2);
            listaDados.Add(bill3);

            foreach (Bill bill in listaDados)
            {
                dataGridView1.Rows.Add(bill.BillName, bill.BillCode, bill.BillValue, bill.BillExpiration);
            }


        }
        private void ConfigureDataGridView()
        {
            // Configurar as colunas do DataGridView
            dataGridView1.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colunaBillName = new DataGridViewTextBoxColumn();
            colunaBillName.Name = "BillName";
            colunaBillName.DataPropertyName = "BillName";
            colunaBillName.HeaderText = "Nome da Conta";

            DataGridViewTextBoxColumn colunaBillCode = new DataGridViewTextBoxColumn();
            colunaBillCode.Name = "BillCode";
            colunaBillCode.DataPropertyName = "BillCode";
            colunaBillCode.HeaderText = "Código da Conta";

            DataGridViewTextBoxColumn colunaBillValue = new DataGridViewTextBoxColumn();
            colunaBillValue.Name = "BillValue";
            colunaBillValue.DataPropertyName = "BillValue";
            colunaBillValue.HeaderText = "Valor";

            DataGridViewTextBoxColumn colunaBillExpiration = new DataGridViewTextBoxColumn();
            colunaBillExpiration.Name = "BillExpiration";
            colunaBillExpiration.DataPropertyName = "BillExpiration";
            colunaBillExpiration.HeaderText = "Data de Vencimento";

            dataGridView1.Columns.Add(colunaBillName);
            dataGridView1.Columns.Add(colunaBillCode);
            dataGridView1.Columns.Add(colunaBillValue);
            dataGridView1.Columns.Add(colunaBillExpiration);


        }


        private void InsertButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            FormListBills formListBills = new FormListBills();
            formListBills.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}