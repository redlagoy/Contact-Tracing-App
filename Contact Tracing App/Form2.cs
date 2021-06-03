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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            mainText.Clear();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader inputFile;

                inputFile = File.OpenText(openFileDialog1.FileName);
                string line;
                while ((line = inputFile.ReadLine()) != null)
                {
                    string newLine = "\r\n";
                    mainText.Text = mainText.Text + line + newLine;
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Form1 export = new Form1();
            this.Hide();
            export.ShowDialog();
            this.Close();
        }
    }
}
