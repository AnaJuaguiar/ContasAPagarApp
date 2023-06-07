using ContasAPagar.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasAPagar.Controller
{
    internal class BillController
    {
        public void Insert(Bill NewBill, AllBills allBills)
        {
            NewBill.ReadBillData();
            allBills.InsertNewBill(NewBill);
        }

        public void Update(string codeBill, Bill alterBill, AllBills allBills)
        {
            try
            {
                Bill currentBill = allBills.SearchBill(codeBill);

                if (currentBill != null)
                {
                    currentBill.WriteBillData();
                    currentBill.BillCode = alterBill.BillCode;
                    allBills.UpdateBill(currentBill, alterBill);
                }
                else
                {
                    throw new Exception("Conta não encontrada");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
        }

        public void Delete(string codeBill, AllBills allBills)
        {
            Bill currentBill = allBills.SearchBill(codeBill);
            try
            {
                currentBill.WriteBillData();

                allBills.DeleteBill(currentBill);

                Console.Write("Aluno excluído!");
                Console.ReadKey();
                
               
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);

            }
            
        }

        public void Search (string codeBill, AllBills allBills)
        {
            Bill currentBill = allBills.SearchBill(codeBill);

            if (currentBill != null)
            {
                currentBill.WriteBillData();
            }
            else
            {
                Console.Write("\n Conta não encontrada no Cadastro de Contas!");
            }

            Console.ReadKey();
        }
        /*
        public void ShowAllBills(AllBills allBills)
        {
            ArrayList ListOfBills;

            //ListOfBills = allBills.ListAllBills();

            foreach (Bill x in ListOfBills)
            {
                x.WriteBillData();
            }

            Console.ReadKey();
        }

        */
    }
}
