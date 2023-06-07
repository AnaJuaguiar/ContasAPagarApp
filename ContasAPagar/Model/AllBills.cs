using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContasAPagar.Model;

namespace ContasAPagar.Model
{
    internal class AllBills
    {
        private readonly ArrayList<Bill> AllBillsList;


        public AllBills()
        {
            AllBillsList = new ArrayList<Bill>();
        }

        public void InsertNewBill(Bill newBill)
        {
            AllBillsList.Add(newBill);

        }

        public void UpdateBill(Bill x, Bill y)
        {
            int OldBillPosition;

            OldBillPosition = AllBillsList.IndexOf(x);

            AllBillsList.Remove(x);
            AllBillsList.Insert(OldBillPosition, y);
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

        public ArrayList ListAllBills()
        {
            return AllBillsList;
        }
        /*
         * 
         * 
         /*  

        
        public int SalvarArquivo()
        {
            TextWriter MeuWriter = new StreamWriter(@"D:\Lixo\CadastroAlunos.xml");

            Aluno[] ListaAlunoVetor = (Aluno[])Cadastro.ToArray(typeof(Aluno));

            // Serialização
            XmlSerializer Serialização = new XmlSerializer(ListaAlunoVetor.GetType());

            //Serializa usando o TextWriter
            Serialização.Serialize(MeuWriter, ListaAlunoVetor);

            MeuWriter.Close();

            return Cadastro.Count;
        }

        public int LerArquivo()
        {
            int Reg;
            
            FileStream Arquivo = new FileStream(@"D:\Lixo\CadastroAlunos.xml", FileMode.Open);

            Aluno[] ListaAlunoVetor = (Aluno[])Cadastro.ToArray(typeof(Aluno));

            XmlSerializer Serialização = new XmlSerializer(ListaAlunoVetor.GetType());

            ListaAlunoVetor = (Aluno[])Serialização.Deserialize(Arquivo);              

            Cadastro.Clear();
                                                          
            Cadastro.AddRange(ListaAlunoVetor);

            Reg = Cadastro.Count;

            Arquivo.Close();

            return Reg;
        }

        public class MinhaOrdenação : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                return ((Aluno)x).Nome.CompareTo(((Aluno)y).Nome);
            }
        }
         * 
         * 
         */
    }
}
