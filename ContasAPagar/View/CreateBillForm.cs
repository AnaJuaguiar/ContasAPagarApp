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
    public partial class RegistrationForm : Form
    {
        private AllBills allBillsList;
        public RegistrationForm()
        {
            InitializeComponent();
            allBillsList = AllBills.Instance;

        }

        private void buttonCreateBill_Click(object sender, EventArgs e)
        {
            try
            {
                string billName = textBoxNameBill.Text;
                string billCode = textBoxCodeBill.Text;
                double billValue = double.Parse(textBoxValueBill.Text);
                DateTime billExpiration = DateTime.Parse(textExpirationBill.Text);

                Bill newBill = new Bill(billName, billCode, billValue, billExpiration);

                allBillsList.InsertNewBill(newBill);

                MessageBox.Show("Conta criada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar a conta: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
