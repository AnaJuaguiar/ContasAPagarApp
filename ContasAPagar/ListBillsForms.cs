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
        private List<Bill> allBillsList =  new List<Bill>(); 

        public FormListBills()
        {
            InitializeComponent();
            ConfigureDataGridView();
            allBillsList = AllBills.Instance.GetAllBills();
            PreencherListaDados(dataGridView1);
            dataGridView1.DataSource = allBillsList;
        }
        private void PreencherListaDados(DataGridView dataGridView1)
        { 
            foreach (Bill bill in allBillsList)
            {
                dataGridView1.Rows.Add(bill.BillName, bill.BillCode, bill.BillValue, bill.BillExpiration);
            }
        }
        private void ConfigureDataGridView()
        {
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
    }
}
