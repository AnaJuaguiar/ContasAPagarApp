using System;
using System.Collections.Generic;
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

        public Bill(string billName, string billCode, double billValue, DateTime billExpiration)
        {
            BillName = billName;
            BillCode = billCode;
            BillValue = billValue;
            BillExpiration = billExpiration;
        }

        public void ReadBillData()
        {

        }
        public void WriteBillData() { 

        
        
        }
    }
}
