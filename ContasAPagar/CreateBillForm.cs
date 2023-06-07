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
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void buttonCreateBill_Click(object sender, EventArgs e)
        {
            string billName = textBoxNameBill.Text;
            string billCode = textBoxCodeBill.Text;
            double billValue = double.Parse(textBoxValueBill.Text);
            DateTime billExpiration = DateTime.Parse(textExpirationBill.Text);


            // Realizar ações com o texto digitado
            // Exemplo: exibir o texto em uma caixa de diálogo
            // MessageBox.Show("Texto digitado: " + textoDigitado);
        }

     
    }
}
