
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.dateOfBirth = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(580, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
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
            this.title.Location = new System.Drawing.Point(170, 9);
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
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.age.Location = new System.Drawing.Point(15, 223);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(57, 26);
            this.age.TabIndex = 8;
            this.age.Text = "Age:";
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.AutoSize = true;
            this.dateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dateOfBirth.Location = new System.Drawing.Point(118, 223);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(139, 26);
            this.dateOfBirth.TabIndex = 9;
            this.dateOfBirth.Text = "Date of Birth:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.name.Location = new System.Drawing.Point(13, 95);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(135, 26);
            this.name.TabIndex = 10;
            this.name.Text = "Enter Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.name);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.age);
            this.Controls.Add(this.address);
            this.Controls.Add(this.title);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label dateOfBirth;
        private System.Windows.Forms.Label name;
    }
}

