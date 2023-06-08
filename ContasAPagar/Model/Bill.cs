using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasAPagar.Model
{
    public class Bill
    {
        public string BillName { get; set; }
        public string BillCode { get; set; }
        public double BillValue { get; set; }
       
        public DateTime BillExpiration { get; set; }

        public Bill()
        {
            
        }
        public Bill(string billName, string billCode, double billValue, DateTime billExpiration)
        {
            BillName = billName;
            BillCode = billCode;
            BillValue = billValue;
            BillExpiration = billExpiration;
        }

        public string Show()
        {
            return (
                $"Conta: {this.BillName} -" +
                $" Valor: {this.BillValue} \n " +
                $" Vencimento{this.BillExpiration} - " +
                $" Código {this.BillCode}"
                );
            
        }
    }
}
