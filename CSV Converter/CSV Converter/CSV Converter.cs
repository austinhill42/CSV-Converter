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
                List<List<string>> csv = new List<List<string>>();

                string str = sr.ReadToEnd();
                str = str.Replace("\"", "");

                List<string> lst = str.Split('\n').ToList();
                lst.RemoveRange(0, 4);
                
                foreach (string l in lst)
                {
                    csv.Add(l.Split(',').ToList());
                }

            }
        }
    }
}
