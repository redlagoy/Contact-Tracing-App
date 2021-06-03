
namespace Contact_Tracing_App
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.mainText = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.title.Location = new System.Drawing.Point(155, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(485, 55);
            this.title.TabIndex = 0;
            this.title.Text = "CONTACT TRACING";
            // 
            // mainText
            // 
            this.mainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.mainText.Location = new System.Drawing.Point(12, 91);
            this.mainText.Multiline = true;
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(776, 277);
            this.mainText.TabIndex = 1;
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnImport.Location = new System.Drawing.Point(12, 374);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(372, 64);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import Info";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExport.Location = new System.Drawing.Point(416, 374);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(372, 64);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export Info";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.mainText);
            this.Controls.Add(this.title);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox mainText;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}