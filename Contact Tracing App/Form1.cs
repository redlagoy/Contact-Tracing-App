using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Contact_Tracing_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            String[] file = Directory.GetFiles(".", "trace-*");
            int highestFile = 0;
            for (int i = 0; i < file.Length; i++)
            {
                string filename = file[i];
                filename = filename.Replace(".\\trace-", "");
                filename = filename.Replace(".txt", "");
                int fileCount = int.Parse(filename);

                if (fileCount > highestFile)
                {
                    highestFile = fileCount;
                }
            }

            highestFile++;
            StreamWriter outputFile;

            outputFile = File.AppendText("trace-" + highestFile + ".txt");
            outputFile.WriteLine(txtName.Text);
            outputFile.WriteLine(txtLastName.Text);
            outputFile.WriteLine(txtAddress.Text);
            outputFile.WriteLine(txtEmail.Text);
            outputFile.WriteLine(txtNumber.Text);
            outputFile.WriteLine(txtAge.Text);
            outputFile.Close();

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            Form2 import = new Form2();
            this.Hide();
            import.ShowDialog();
            this.Close();
        }
    }
}
