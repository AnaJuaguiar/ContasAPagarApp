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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {

        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void ConfigureDataGridView()
        {
            // Configurar as colunas do DataGridView
            dataGridViewSearch.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colunaCodigo = new DataGridViewTextBoxColumn();
            colunaCodigo.Name = "Codigo";
            colunaCodigo.DataPropertyName = "Codigo";
            colunaCodigo.HeaderText = "Código";

            DataGridViewTextBoxColumn colunaDescricao = new DataGridViewTextBoxColumn();
            colunaDescricao.Name = "Descricao";
            colunaDescricao.DataPropertyName = "Descricao";
            colunaDescricao.HeaderText = "Descrição";

            DataGridViewTextBoxColumn colunaValor = new DataGridViewTextBoxColumn();
            colunaValor.Name = "Valor";
            colunaValor.DataPropertyName = "Valor";
            colunaValor.HeaderText = "Valor";

            dataGridViewSearch.Columns.Add(colunaCodigo);
            dataGridViewSearch.Columns.Add(colunaDescricao);
            dataGridViewSearch.Columns.Add(colunaValor);
        }
    }
}
