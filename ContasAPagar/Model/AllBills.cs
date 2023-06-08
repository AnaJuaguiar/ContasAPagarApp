using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

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

        public void UpdateBill(Bill oldBill, Bill newBill)
        {
            int oldBillPosition = AllBillsList.IndexOf(oldBill);
            AllBillsList[oldBillPosition] = newBill;
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

        private Bill[] CreateArray()
        {
            Bill[] billArray = new Bill[AllBillsList.Count];

            for (int i = 0; i < AllBillsList.Count; i++)
            {
                billArray[i] = AllBillsList[i];
            }

            return billArray;
        }

        public int SaveXml()
        {
            try
            {
                string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string filePath = Path.Combine(appDataFolder, "ContasAPagar.xml");

                using (TextWriter allBillsWriter = new StreamWriter(filePath))
                {
                    Bill[] billArray = CreateArray();

                    XmlSerializer serializerBills = new XmlSerializer(billArray.GetType());
                    serializerBills.Serialize(allBillsWriter, billArray);
                }

                return AllBillsList.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o arquivo XML: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public int ReadXml()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Arquivos XML (*.xml)|*.xml";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    using (FileStream arquivo = new FileStream(filePath, FileMode.Open))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(Bill[]));

                        Bill[] billArray = (Bill[])serializer.Deserialize(arquivo);

                        AllBillsList.Clear();
                        AllBillsList.AddRange(billArray);

                        return AllBillsList.Count;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao ler o arquivo XML: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}
