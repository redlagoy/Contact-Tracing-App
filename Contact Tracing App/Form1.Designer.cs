
namespace Contact_Tracing_App
{
    partial class Form1
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.contactNumber = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.emailAddress = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtName.Location = new System.Drawing.Point(12, 124);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(403, 32);
            this.txtName.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExport.Location = new System.Drawing.Point(443, 252);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(166, 32);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export Info";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnImport.Location = new System.Drawing.Point(622, 252);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(166, 32);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import Info";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtAddress.Location = new System.Drawing.Point(12, 188);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(403, 32);
            this.txtAddress.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtAge.Location = new System.Drawing.Point(12, 252);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 32);
            this.txtAge.TabIndex = 4;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.title.Location = new System.Drawing.Point(162, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(485, 55);
            this.title.TabIndex = 6;
            this.title.Text = "CONTACT TRACING";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.address.Location = new System.Drawing.Point(13, 159);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(98, 26);
            this.address.TabIndex = 7;
            this.address.Text = "Address:";
            // 
            // contactNumber
            // 
            this.contactNumber.AutoSize = true;
            this.contactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.contactNumber.Location = new System.Drawing.Point(119, 223);
            this.contactNumber.Name = "contactNumber";
            this.contactNumber.Size = new System.Drawing.Size(177, 26);
            this.contactNumber.TabIndex = 9;
            this.contactNumber.Text = "Contact Number:";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.firstName.Location = new System.Drawing.Point(13, 95);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(183, 26);
            this.firstName.TabIndex = 10;
            this.firstName.Text = "Enter First Name:";
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtNumber.Location = new System.Drawing.Point(123, 253);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(292, 32);
            this.txtNumber.TabIndex = 11;
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lastName.Location = new System.Drawing.Point(438, 95);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(182, 26);
            this.lastName.TabIndex = 12;
            this.lastName.Text = "Enter Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtLastName.Location = new System.Drawing.Point(443, 124);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(345, 32);
            this.txtLastName.TabIndex = 13;
            // 
            // emailAddress
            // 
            this.emailAddress.AutoSize = true;
            this.emailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.emailAddress.Location = new System.Drawing.Point(438, 159);
            this.emailAddress.Name = "emailAddress";
            this.emailAddress.Size = new System.Drawing.Size(160, 26);
            this.emailAddress.TabIndex = 14;
            this.emailAddress.Text = "Email Address:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtEmail.Location = new System.Drawing.Point(443, 188);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(345, 32);
            this.txtEmail.TabIndex = 15;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.age.Location = new System.Drawing.Point(13, 223);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(57, 26);
            this.age.TabIndex = 16;
            this.age.Text = "Age:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 312);
            this.Controls.Add(this.age);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.emailAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.contactNumber);
            this.Controls.Add(this.address);
            this.Controls.Add(this.title);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label contactNumber;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label emailAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

