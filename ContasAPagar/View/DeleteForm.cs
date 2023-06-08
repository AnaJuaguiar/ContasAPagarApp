using ContasAPagar.Logic;
using ContasAPagar.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContasAPagar
{
    public partial class DeleteForm : Form
    {
        public List<Bill> allBillsList = new List<Bill>();
        public AllBills allBills;
        public DeleteForm()
        {
            InitializeComponent();
            allBills = AllBills.Instance;
            allBillsList = allBills.GetAllBills();
            DataGridConfigs.ConfigureDataGridView(dataGridView1);
            DataGridConfigs.PreencherListaDados(dataGridView1, allBillsList);
            dataGridView1.DataSource = allBillsList;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDeleteAccount_Click(object sender, EventArgs e)
        {
            string billCodeReference = textBoxDelete.Text;
            Bill billToDelete = allBills.SearchBill(billCodeReference);
            if (billToDelete != null)
            {
                allBills.DeleteBill(billToDelete);
                MessageBox.Show(
                   $"A conta:  \n {billToDelete.Show()} \n foi deletada com sucesso!",
                   $"Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                   );
            }
            else
            {
                MessageBox.Show("Nenhuma conta com esse código foi cadastrada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            allBillsList.Clear();
            MessageBox.Show("Contas apagadas com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
