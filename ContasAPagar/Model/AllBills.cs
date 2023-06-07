using System;
using System.Collections.Generic;

namespace ContasAPagar.Model
{
    public class AllBills
    {
        private static AllBills instance;
        public static AllBills Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AllBills();
                }
                return instance;
            }
        }

        public List<Bill> AllBillsList { get; private set; }

        private AllBills()
        {
            AllBillsList = new List<Bill>();
        }

        public void InsertNewBill(Bill newBill)
        {
            AllBillsList.Add(newBill);
        }

        public void UpdateBill(Bill x, Bill y)
        {
            int oldBillPosition = AllBillsList.IndexOf(x);
            AllBillsList[oldBillPosition] = y;
        }

        public void DeleteBill(Bill x)
        {
            AllBillsList.Remove(x);
        }

        public Bill SearchBill(string billCode)
        {
            foreach (Bill x in AllBillsList)
            {
                if (x.BillCode.ToUpper() == billCode.ToUpper())
                {
                    return x;
                }
            }
            return null;
        }

        public List<Bill> GetAllBills()
        {
            return AllBillsList;
        }
    }
}
