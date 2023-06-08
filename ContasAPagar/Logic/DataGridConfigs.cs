using ContasAPagar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContasAPagar.Logic
{
    class DataGridConfigs
    {
        public static void PreencherListaDados(DataGridView dataGridView1, List<Bill> allBillsList)
        {
            foreach (Bill bill in allBillsList)
            {
                dataGridView1.Rows.Add(bill.BillName, bill.BillCode, bill.BillValue, bill.BillExpiration);
            }
        }
        public static void ConfigureDataGridView(DataGridView dataGridView1)
        {
            dataGridView1.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colunaBillName = new DataGridViewTextBoxColumn();
            colunaBillName.Name = "BillName";
            colunaBillName.DataPropertyName = "BillName";
            colunaBillName.HeaderText = "Nome";

            DataGridViewTextBoxColumn colunaBillCode = new DataGridViewTextBoxColumn();
            colunaBillCode.Name = "BillCode";
            colunaBillCode.DataPropertyName = "BillCode";
            colunaBillCode.HeaderText = "Código";

            DataGridViewTextBoxColumn colunaBillValue = new DataGridViewTextBoxColumn();
            colunaBillValue.Name = "BillValue";
            colunaBillValue.DataPropertyName = "BillValue";
            colunaBillValue.HeaderText = "Valor";

            DataGridViewTextBoxColumn colunaBillExpiration = new DataGridViewTextBoxColumn();
            colunaBillExpiration.Name = "BillExpiration";
            colunaBillExpiration.DataPropertyName = "BillExpiration";
            colunaBillExpiration.HeaderText = "Data";

            dataGridView1.Columns.Add(colunaBillName);
            dataGridView1.Columns.Add(colunaBillCode);
            dataGridView1.Columns.Add(colunaBillValue);
            dataGridView1.Columns.Add(colunaBillExpiration);
        }
    }
}
