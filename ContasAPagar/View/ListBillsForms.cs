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
    public partial class FormListBills : Form
    {
        private List<Bill> allBillsList = new List<Bill>();

        public FormListBills()
        {
            InitializeComponent();
            allBillsList = AllBills.Instance.GetAllBills();
            DataGridConfigs.ConfigureDataGridView(dataGridView1);
            DataGridConfigs.PreencherListaDados(dataGridView1, allBillsList);
            dataGridView1.DataSource = allBillsList;
        }

    }
}
