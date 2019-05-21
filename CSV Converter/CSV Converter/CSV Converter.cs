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
        }

        private void BTN_InputFileSelect_Click(object sender, EventArgs e)
        {
            openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openFile.FileName);

                    L_InputFilename.Text = sr.ReadToEnd();
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\nDetails:\n\n{ex.StackTrace}");
                }
            }
        }

        private void BTN_Convert_Click(object sender, EventArgs e)
        {

        }
    }
}
