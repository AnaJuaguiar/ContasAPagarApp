﻿using ContasAPagar.Model;
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
    public partial class SearchForm : Form
    {
        private AllBills allBillsList;

        public SearchForm()
        {
            InitializeComponent();
            allBillsList = AllBills.Instance;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchCode = textBoxSearch.Text;

                var resultSearch = allBillsList.SearchBill(searchCode);

                if (resultSearch != null)
                {
                    MessageBox.Show(
                        $"Resultados encontrados! \n {resultSearch.Show()}",
                        "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nenhuma conta com esse código foi cadastrada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao pesquisar a conta: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
