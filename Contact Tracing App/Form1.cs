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
            StreamWriter outputFile;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                outputFile = File.AppendText(saveFileDialog1.FileName + ".txt");
                outputFile.WriteLine(txtName.Text);
                outputFile.WriteLine(txtLastName.Text);
                outputFile.WriteLine(txtAddress.Text);
                outputFile.WriteLine(txtEmail.Text);
                outputFile.WriteLine(txtNumber.Text);
                outputFile.WriteLine(txtAge.Text);
                outputFile.Close();
            }
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
