using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSV_Converter
{
    public partial class CSVConverter : Form
    {

        private OpenFileDialog openFile;
        private List<List<string>> csv = new List<List<string>>();

        public CSVConverter()
        {
            InitializeComponent();

            L_InputFilename.Text = "";
            L_OutputFileName.Text = "";
        }

        private void BTN_InputFileSelect_Click(object sender, EventArgs e)
        {
            openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                List<string> str = openFile.FileName.Split('.').ToList();
                str.Insert(1, "(converted).");
                
                L_InputFilename.Text = openFile.FileName;
                L_OutputFileName.Text = String.Join("", str);
            }
        }

        private void BTN_Convert_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(openFile.FileName))
            {
                int index = 0;

                string str = sr.ReadToEnd();
                str = str.Replace("\"", "");

                List<string> lst = str.Split('\n').ToList();
                lst.RemoveRange(0, 4);
                
                foreach (string l in lst)
                {
                    csv.Add(l.Split(',').ToList());
                }

                foreach (string l in csv[0])
                {
                    switch (l)
                    {
                        case "Customer Order Number":
                            csv[0][index] = "Order Number";
                            break;
                        case "Subtotal":
                            csv[0][index] = "Subtotal Incl. Tax";
                            break;
                        case "Shipping Code":
                            csv[0][index] = "Requested Service";
                            break;
                        case "Shipping":
                            csv[0][index] = "Shipping Cost";
                            break;
                        case "Customer Name":
                            csv[0][index] = "Full Name";
                            break;
                        case "Customer Name1":
                            csv[0][index] = "First Name";
                            break;
                        case "Customer Name2":
                            csv[0][index] = "Last Name";
                            break;
                        case "Customer Address1":
                            csv[0][index] = "Address Line 1";
                            break;
                        case "Customer Address2":
                            csv[0][index] = "Address Line 2";
                            break;
                        case "Customer City":
                            csv[0][index] = "City";
                            break;
                        case "Customer State":
                            csv[0][index] = "State";
                            break;
                        case "Customer Postal Code":
                            csv[0][index] = "Zip";
                            break;
                        case "Customer Country":
                            csv[0][index] = "Country";
                            break;
                        case "Customer Company Name":
                            csv[0][index] = "Company";
                            break;
                        case "Customer Email":
                            csv[0][index] = "Email";
                            break;
                        case "Customer Night Phone":
                            csv[0][index] = "Phone";
                            break;
                    }

                    index++;
                }

            }

            using (StreamWriter sw = new StreamWriter(L_OutputFileName.Text))
            {
                foreach (List<string> l in csv)
                    sw.Write(String.Join(",", l) + "\n");
            }
        }
    }
}
