using ContasAPagar.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContasAPagar
{
    public partial class EditBillForm : Form
    {
        public List<Bill> allBillsList = new List<Bill>();
        public AllBills allBills;

        public EditBillForm()
        {
            InitializeComponent();
            allBills = AllBills.Instance;
            allBillsList = allBills.GetAllBills();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string searchBillToEdit = textBoxOldCode.Text;
            Bill oldBill = allBills.SearchBill(searchBillToEdit);
            try
            {
                if (oldBill != null)
                {
                    string newBillName = textBoxBillName.Text;
                    string newBillCode = textBoxCode.Text;
                    double newBillValue;
                    DateTime newBillExpiration;

                    if (!double.TryParse(textBoxBillValue.Text, out newBillValue))
                    {
                        MessageBox.Show("O valor da conta não é válido. Certifique-se de inserir um valor numérico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!DateTime.TryParse(textBoxExpiration.Text, out newBillExpiration))
                    {
                        MessageBox.Show("A data de vencimento da conta não é válida. Certifique-se de inserir uma data no formato correto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Bill newBill = new Bill(newBillName, newBillCode, newBillValue, newBillExpiration);

                    allBills.UpdateBill(oldBill, newBill);
                    MessageBox.Show("Alteração realizada com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("A conta que você deseja alterar não foi encontrada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao editar a conta: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
