namespace ElxBillingSystem.Forms
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.first_name_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.last_name_textBox = new System.Windows.Forms.TextBox();
            this.address_textBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.city_textBox = new System.Windows.Forms.TextBox();
            this.state_comboBox = new System.Windows.Forms.ComboBox();
            this.postal_code_textBox = new System.Windows.Forms.TextBox();
            this.ssn_textBox = new System.Windows.Forms.TextBox();
            this.cell_phone_textBox = new System.Windows.Forms.TextBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.uname_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.return_main_button = new System.Windows.Forms.Button();
            this.custIdText = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.country_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(529, 55);
            this.title.TabIndex = 1;
            this.title.Text = "Electrical Billing System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Address";
            // 
            // first_name_textBox
            // 
            this.first_name_textBox.Location = new System.Drawing.Point(113, 108);
            this.first_name_textBox.Name = "first_name_textBox";
            this.first_name_textBox.Size = new System.Drawing.Size(141, 20);
            this.first_name_textBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "State";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Postal Code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Country";
            // 
            // last_name_textBox
            // 
            this.last_name_textBox.Location = new System.Drawing.Point(113, 135);
            this.last_name_textBox.Name = "last_name_textBox";
            this.last_name_textBox.Size = new System.Drawing.Size(141, 20);
            this.last_name_textBox.TabIndex = 16;
            // 
            // address_textBox
            // 
            this.address_textBox.Location = new System.Drawing.Point(113, 161);
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(141, 20);
            this.address_textBox.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(444, 246);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(444, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Username";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(444, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(444, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Cell Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(444, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "SSN";
            // 
            // city_textBox
            // 
            this.city_textBox.Location = new System.Drawing.Point(113, 189);
            this.city_textBox.Name = "city_textBox";
            this.city_textBox.Size = new System.Drawing.Size(141, 20);
            this.city_textBox.TabIndex = 23;
            // 
            // state_comboBox
            // 
            this.state_comboBox.FormattingEnabled = true;
            this.state_comboBox.Location = new System.Drawing.Point(113, 217);
            this.state_comboBox.Name = "state_comboBox";
            this.state_comboBox.Size = new System.Drawing.Size(141, 21);
            this.state_comboBox.TabIndex = 24;
            // 
            // postal_code_textBox
            // 
            this.postal_code_textBox.Location = new System.Drawing.Point(113, 246);
            this.postal_code_textBox.Name = "postal_code_textBox";
            this.postal_code_textBox.Size = new System.Drawing.Size(141, 20);
            this.postal_code_textBox.TabIndex = 25;
            // 
            // ssn_textBox
            // 
            this.ssn_textBox.Location = new System.Drawing.Point(516, 135);
            this.ssn_textBox.Name = "ssn_textBox";
            this.ssn_textBox.Size = new System.Drawing.Size(200, 20);
            this.ssn_textBox.TabIndex = 27;
            // 
            // cell_phone_textBox
            // 
            this.cell_phone_textBox.Location = new System.Drawing.Point(516, 163);
            this.cell_phone_textBox.Name = "cell_phone_textBox";
            this.cell_phone_textBox.Size = new System.Drawing.Size(200, 20);
            this.cell_phone_textBox.TabIndex = 28;
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(516, 190);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(200, 20);
            this.email_textBox.TabIndex = 29;
            // 
            // uname_textBox
            // 
            this.uname_textBox.Location = new System.Drawing.Point(516, 216);
            this.uname_textBox.Name = "uname_textBox";
            this.uname_textBox.Size = new System.Drawing.Size(200, 20);
            this.uname_textBox.TabIndex = 30;
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(516, 243);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(200, 20);
            this.password_textBox.TabIndex = 31;
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(267, 348);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(75, 23);
            this.submit_button.TabIndex = 32;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(357, 348);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 23);
            this.clear_button.TabIndex = 33;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // return_main_button
            // 
            this.return_main_button.Location = new System.Drawing.Point(447, 348);
            this.return_main_button.Name = "return_main_button";
            this.return_main_button.Size = new System.Drawing.Size(103, 23);
            this.return_main_button.TabIndex = 34;
            this.return_main_button.Text = "Return Main Menu";
            this.return_main_button.UseVisualStyleBackColor = true;
            this.return_main_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // custIdText
            // 
            this.custIdText.AutoSize = true;
            this.custIdText.Location = new System.Drawing.Point(110, 87);
            this.custIdText.Name = "custIdText";
            this.custIdText.Size = new System.Drawing.Size(70, 13);
            this.custIdText.TabIndex = 35;
            this.custIdText.Text = "Not Available";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(444, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Date of Birth";
            // 
            // dobPicker
            // 
            this.dobPicker.Location = new System.Drawing.Point(516, 111);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(200, 20);
            this.dobPicker.TabIndex = 37;
            // 
            // country_comboBox
            // 
            this.country_comboBox.FormattingEnabled = true;
            this.country_comboBox.Location = new System.Drawing.Point(113, 272);
            this.country_comboBox.Name = "country_comboBox";
            this.country_comboBox.Size = new System.Drawing.Size(141, 21);
            this.country_comboBox.TabIndex = 38;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 395);
            this.Controls.Add(this.country_comboBox);
            this.Controls.Add(this.dobPicker);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.custIdText);
            this.Controls.Add(this.return_main_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.uname_textBox);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.cell_phone_textBox);
            this.Controls.Add(this.ssn_textBox);
            this.Controls.Add(this.postal_code_textBox);
            this.Controls.Add(this.state_comboBox);
            this.Controls.Add(this.city_textBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.address_textBox);
            this.Controls.Add(this.last_name_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.first_name_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox first_name_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox last_name_textBox;
        private System.Windows.Forms.TextBox address_textBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox city_textBox;
        private System.Windows.Forms.ComboBox state_comboBox;
        private System.Windows.Forms.TextBox postal_code_textBox;
        private System.Windows.Forms.TextBox ssn_textBox;
        private System.Windows.Forms.TextBox cell_phone_textBox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.TextBox uname_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button return_main_button;
        private System.Windows.Forms.Label custIdText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.ComboBox country_comboBox;
    }
}