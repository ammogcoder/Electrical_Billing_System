namespace ElxBillingSystem.Forms
{
    partial class AdminBoard
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.compareReportButton = new System.Windows.Forms.Button();
            this.editBilling_button = new System.Windows.Forms.Button();
            this.editCustomer_button = new System.Windows.Forms.Button();
            this.editCustomerPanel = new System.Windows.Forms.Panel();
            this.load_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.editCustomerLabel = new System.Windows.Forms.Label();
            this.custId_textBox = new System.Windows.Forms.TextBox();
            this.country_comboBox = new System.Windows.Forms.ComboBox();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.uname_textBox = new System.Windows.Forms.TextBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.cell_phone_textBox = new System.Windows.Forms.TextBox();
            this.ssn_textBox = new System.Windows.Forms.TextBox();
            this.postal_code_textBox = new System.Windows.Forms.TextBox();
            this.state_comboBox = new System.Windows.Forms.ComboBox();
            this.city_textBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.address_textBox = new System.Windows.Forms.TextBox();
            this.last_name_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.first_name_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adminTab = new System.Windows.Forms.TabControl();
            this.editCustomer_tabPage = new System.Windows.Forms.TabPage();
            this.editBilling_tabPage = new System.Windows.Forms.TabPage();
            this.updBilling_button = new System.Windows.Forms.Button();
            this.paidNo_radioButton = new System.Windows.Forms.RadioButton();
            this.paidYes_radioButton = new System.Windows.Forms.RadioButton();
            this.yearBilling_comboBox = new System.Windows.Forms.ComboBox();
            this.monthBilling_comboBox = new System.Windows.Forms.ComboBox();
            this.mailDate_picker = new System.Windows.Forms.DateTimePicker();
            this.billingId_textBox = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.insertBilling_button = new System.Windows.Forms.Button();
            this.loadBilling_button = new System.Windows.Forms.Button();
            this.cancelBilling_Button = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.paidDate_picker = new System.Windows.Forms.DateTimePicker();
            this.amtToPay_textBox = new System.Windows.Forms.TextBox();
            this.meterReading_textBox = new System.Windows.Forms.TextBox();
            this.meterNumber_textBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.custBilling_textBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.editCustomerPanel.SuspendLayout();
            this.adminTab.SuspendLayout();
            this.editCustomer_tabPage.SuspendLayout();
            this.editBilling_tabPage.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exitButton);
            this.groupBox1.Controls.Add(this.mainMenuButton);
            this.groupBox1.Controls.Add(this.compareReportButton);
            this.groupBox1.Controls.Add(this.editBilling_button);
            this.groupBox1.Controls.Add(this.editCustomer_button);
            this.groupBox1.Location = new System.Drawing.Point(22, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 438);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dashboard";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(7, 290);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(109, 61);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Location = new System.Drawing.Point(6, 223);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(109, 61);
            this.mainMenuButton.TabIndex = 6;
            this.mainMenuButton.Text = "Logout";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // compareReportButton
            // 
            this.compareReportButton.Location = new System.Drawing.Point(6, 154);
            this.compareReportButton.Name = "compareReportButton";
            this.compareReportButton.Size = new System.Drawing.Size(109, 61);
            this.compareReportButton.TabIndex = 5;
            this.compareReportButton.Text = "Compare Report";
            this.compareReportButton.UseVisualStyleBackColor = true;
            // 
            // editBilling_button
            // 
            this.editBilling_button.Location = new System.Drawing.Point(6, 86);
            this.editBilling_button.Name = "editBilling_button";
            this.editBilling_button.Size = new System.Drawing.Size(109, 61);
            this.editBilling_button.TabIndex = 4;
            this.editBilling_button.Text = "Edit Billing";
            this.editBilling_button.UseVisualStyleBackColor = true;
            this.editBilling_button.Click += new System.EventHandler(this.editBilling_button_Click);
            // 
            // editCustomer_button
            // 
            this.editCustomer_button.Location = new System.Drawing.Point(6, 19);
            this.editCustomer_button.Name = "editCustomer_button";
            this.editCustomer_button.Size = new System.Drawing.Size(109, 61);
            this.editCustomer_button.TabIndex = 3;
            this.editCustomer_button.Text = "Edit Customer";
            this.editCustomer_button.UseVisualStyleBackColor = true;
            this.editCustomer_button.Click += new System.EventHandler(this.editCustomer_button_Click);
            // 
            // editCustomerPanel
            // 
            this.editCustomerPanel.Controls.Add(this.load_button);
            this.editCustomerPanel.Controls.Add(this.cancel_button);
            this.editCustomerPanel.Controls.Add(this.update_button);
            this.editCustomerPanel.Controls.Add(this.editCustomerLabel);
            this.editCustomerPanel.Controls.Add(this.custId_textBox);
            this.editCustomerPanel.Controls.Add(this.country_comboBox);
            this.editCustomerPanel.Controls.Add(this.dobPicker);
            this.editCustomerPanel.Controls.Add(this.label14);
            this.editCustomerPanel.Controls.Add(this.password_textBox);
            this.editCustomerPanel.Controls.Add(this.uname_textBox);
            this.editCustomerPanel.Controls.Add(this.email_textBox);
            this.editCustomerPanel.Controls.Add(this.cell_phone_textBox);
            this.editCustomerPanel.Controls.Add(this.ssn_textBox);
            this.editCustomerPanel.Controls.Add(this.postal_code_textBox);
            this.editCustomerPanel.Controls.Add(this.state_comboBox);
            this.editCustomerPanel.Controls.Add(this.city_textBox);
            this.editCustomerPanel.Controls.Add(this.label13);
            this.editCustomerPanel.Controls.Add(this.label12);
            this.editCustomerPanel.Controls.Add(this.label11);
            this.editCustomerPanel.Controls.Add(this.label10);
            this.editCustomerPanel.Controls.Add(this.label9);
            this.editCustomerPanel.Controls.Add(this.address_textBox);
            this.editCustomerPanel.Controls.Add(this.last_name_textBox);
            this.editCustomerPanel.Controls.Add(this.label8);
            this.editCustomerPanel.Controls.Add(this.label7);
            this.editCustomerPanel.Controls.Add(this.label6);
            this.editCustomerPanel.Controls.Add(this.label5);
            this.editCustomerPanel.Controls.Add(this.first_name_textBox);
            this.editCustomerPanel.Controls.Add(this.label4);
            this.editCustomerPanel.Controls.Add(this.label3);
            this.editCustomerPanel.Controls.Add(this.label2);
            this.editCustomerPanel.Controls.Add(this.label1);
            this.editCustomerPanel.Location = new System.Drawing.Point(0, 0);
            this.editCustomerPanel.Name = "editCustomerPanel";
            this.editCustomerPanel.Size = new System.Drawing.Size(709, 410);
            this.editCustomerPanel.TabIndex = 6;
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(328, 301);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(94, 32);
            this.load_button.TabIndex = 70;
            this.load_button.Text = "Load";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(528, 299);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(94, 32);
            this.cancel_button.TabIndex = 69;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(428, 301);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(94, 32);
            this.update_button.TabIndex = 68;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // editCustomerLabel
            // 
            this.editCustomerLabel.AutoSize = true;
            this.editCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCustomerLabel.Location = new System.Drawing.Point(28, 10);
            this.editCustomerLabel.Name = "editCustomerLabel";
            this.editCustomerLabel.Size = new System.Drawing.Size(220, 37);
            this.editCustomerLabel.TabIndex = 67;
            this.editCustomerLabel.Text = "Edit Customer";
            // 
            // custId_textBox
            // 
            this.custId_textBox.Location = new System.Drawing.Point(126, 68);
            this.custId_textBox.Name = "custId_textBox";
            this.custId_textBox.Size = new System.Drawing.Size(141, 20);
            this.custId_textBox.TabIndex = 66;
            // 
            // country_comboBox
            // 
            this.country_comboBox.FormattingEnabled = true;
            this.country_comboBox.Location = new System.Drawing.Point(126, 256);
            this.country_comboBox.Name = "country_comboBox";
            this.country_comboBox.Size = new System.Drawing.Size(141, 21);
            this.country_comboBox.TabIndex = 65;
            // 
            // dobPicker
            // 
            this.dobPicker.Location = new System.Drawing.Point(422, 71);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(200, 20);
            this.dobPicker.TabIndex = 64;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(350, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 63;
            this.label14.Text = "Date of Birth";
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(422, 203);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(200, 20);
            this.password_textBox.TabIndex = 62;
            // 
            // uname_textBox
            // 
            this.uname_textBox.Location = new System.Drawing.Point(422, 176);
            this.uname_textBox.Name = "uname_textBox";
            this.uname_textBox.Size = new System.Drawing.Size(200, 20);
            this.uname_textBox.TabIndex = 61;
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(422, 150);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(200, 20);
            this.email_textBox.TabIndex = 60;
            // 
            // cell_phone_textBox
            // 
            this.cell_phone_textBox.Location = new System.Drawing.Point(422, 123);
            this.cell_phone_textBox.Name = "cell_phone_textBox";
            this.cell_phone_textBox.Size = new System.Drawing.Size(200, 20);
            this.cell_phone_textBox.TabIndex = 59;
            // 
            // ssn_textBox
            // 
            this.ssn_textBox.Location = new System.Drawing.Point(422, 95);
            this.ssn_textBox.Name = "ssn_textBox";
            this.ssn_textBox.Size = new System.Drawing.Size(200, 20);
            this.ssn_textBox.TabIndex = 58;
            // 
            // postal_code_textBox
            // 
            this.postal_code_textBox.Location = new System.Drawing.Point(126, 230);
            this.postal_code_textBox.Name = "postal_code_textBox";
            this.postal_code_textBox.Size = new System.Drawing.Size(141, 20);
            this.postal_code_textBox.TabIndex = 57;
            // 
            // state_comboBox
            // 
            this.state_comboBox.FormattingEnabled = true;
            this.state_comboBox.Location = new System.Drawing.Point(126, 201);
            this.state_comboBox.Name = "state_comboBox";
            this.state_comboBox.Size = new System.Drawing.Size(141, 21);
            this.state_comboBox.TabIndex = 56;
            // 
            // city_textBox
            // 
            this.city_textBox.Location = new System.Drawing.Point(126, 173);
            this.city_textBox.Name = "city_textBox";
            this.city_textBox.Size = new System.Drawing.Size(141, 20);
            this.city_textBox.TabIndex = 55;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(350, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "Password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(350, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Username";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(350, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(350, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Cell Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(350, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "SSN";
            // 
            // address_textBox
            // 
            this.address_textBox.Location = new System.Drawing.Point(126, 145);
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(141, 20);
            this.address_textBox.TabIndex = 49;
            // 
            // last_name_textBox
            // 
            this.last_name_textBox.Location = new System.Drawing.Point(126, 119);
            this.last_name_textBox.Name = "last_name_textBox";
            this.last_name_textBox.Size = new System.Drawing.Size(141, 20);
            this.last_name_textBox.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Country";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Postal Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "City";
            // 
            // first_name_textBox
            // 
            this.first_name_textBox.Location = new System.Drawing.Point(126, 92);
            this.first_name_textBox.Name = "first_name_textBox";
            this.first_name_textBox.Size = new System.Drawing.Size(141, 20);
            this.first_name_textBox.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Customer ID";
            // 
            // adminTab
            // 
            this.adminTab.Controls.Add(this.editCustomer_tabPage);
            this.adminTab.Controls.Add(this.editBilling_tabPage);
            this.adminTab.Location = new System.Drawing.Point(150, 77);
            this.adminTab.Name = "adminTab";
            this.adminTab.SelectedIndex = 0;
            this.adminTab.Size = new System.Drawing.Size(723, 442);
            this.adminTab.TabIndex = 7;
            this.adminTab.SelectedIndexChanged += new System.EventHandler(this.adminTab_SelectedIndexChanged);
            // 
            // editCustomer_tabPage
            // 
            this.editCustomer_tabPage.Controls.Add(this.editCustomerPanel);
            this.editCustomer_tabPage.Location = new System.Drawing.Point(4, 22);
            this.editCustomer_tabPage.Name = "editCustomer_tabPage";
            this.editCustomer_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.editCustomer_tabPage.Size = new System.Drawing.Size(715, 416);
            this.editCustomer_tabPage.TabIndex = 0;
            this.editCustomer_tabPage.Text = "Edit Customer";
            this.editCustomer_tabPage.UseVisualStyleBackColor = true;
            // 
            // editBilling_tabPage
            // 
            this.editBilling_tabPage.Controls.Add(this.updBilling_button);
            this.editBilling_tabPage.Controls.Add(this.paidNo_radioButton);
            this.editBilling_tabPage.Controls.Add(this.paidYes_radioButton);
            this.editBilling_tabPage.Controls.Add(this.yearBilling_comboBox);
            this.editBilling_tabPage.Controls.Add(this.monthBilling_comboBox);
            this.editBilling_tabPage.Controls.Add(this.mailDate_picker);
            this.editBilling_tabPage.Controls.Add(this.billingId_textBox);
            this.editBilling_tabPage.Controls.Add(this.label24);
            this.editBilling_tabPage.Controls.Add(this.insertBilling_button);
            this.editBilling_tabPage.Controls.Add(this.loadBilling_button);
            this.editBilling_tabPage.Controls.Add(this.cancelBilling_Button);
            this.editBilling_tabPage.Controls.Add(this.label23);
            this.editBilling_tabPage.Controls.Add(this.paidDate_picker);
            this.editBilling_tabPage.Controls.Add(this.amtToPay_textBox);
            this.editBilling_tabPage.Controls.Add(this.meterReading_textBox);
            this.editBilling_tabPage.Controls.Add(this.meterNumber_textBox);
            this.editBilling_tabPage.Controls.Add(this.label22);
            this.editBilling_tabPage.Controls.Add(this.label21);
            this.editBilling_tabPage.Controls.Add(this.label20);
            this.editBilling_tabPage.Controls.Add(this.label19);
            this.editBilling_tabPage.Controls.Add(this.label18);
            this.editBilling_tabPage.Controls.Add(this.label17);
            this.editBilling_tabPage.Controls.Add(this.label16);
            this.editBilling_tabPage.Controls.Add(this.custBilling_textBox);
            this.editBilling_tabPage.Controls.Add(this.label15);
            this.editBilling_tabPage.Location = new System.Drawing.Point(4, 22);
            this.editBilling_tabPage.Name = "editBilling_tabPage";
            this.editBilling_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.editBilling_tabPage.Size = new System.Drawing.Size(670, 357);
            this.editBilling_tabPage.TabIndex = 1;
            this.editBilling_tabPage.Text = "Edit Billing";
            this.editBilling_tabPage.UseVisualStyleBackColor = true;
            // 
            // updBilling_button
            // 
            this.updBilling_button.Location = new System.Drawing.Point(433, 294);
            this.updBilling_button.Name = "updBilling_button";
            this.updBilling_button.Size = new System.Drawing.Size(94, 32);
            this.updBilling_button.TabIndex = 98;
            this.updBilling_button.Text = "Update";
            this.updBilling_button.UseVisualStyleBackColor = true;
            this.updBilling_button.Click += new System.EventHandler(this.updBilling_button_Click);
            // 
            // paidNo_radioButton
            // 
            this.paidNo_radioButton.AutoSize = true;
            this.paidNo_radioButton.Location = new System.Drawing.Point(493, 162);
            this.paidNo_radioButton.Name = "paidNo_radioButton";
            this.paidNo_radioButton.Size = new System.Drawing.Size(39, 17);
            this.paidNo_radioButton.TabIndex = 97;
            this.paidNo_radioButton.TabStop = true;
            this.paidNo_radioButton.Text = "No";
            this.paidNo_radioButton.UseVisualStyleBackColor = true;
            // 
            // paidYes_radioButton
            // 
            this.paidYes_radioButton.AutoSize = true;
            this.paidYes_radioButton.Location = new System.Drawing.Point(427, 162);
            this.paidYes_radioButton.Name = "paidYes_radioButton";
            this.paidYes_radioButton.Size = new System.Drawing.Size(43, 17);
            this.paidYes_radioButton.TabIndex = 96;
            this.paidYes_radioButton.TabStop = true;
            this.paidYes_radioButton.Text = "Yes";
            this.paidYes_radioButton.UseVisualStyleBackColor = true;
            // 
            // yearBilling_comboBox
            // 
            this.yearBilling_comboBox.FormattingEnabled = true;
            this.yearBilling_comboBox.Location = new System.Drawing.Point(92, 163);
            this.yearBilling_comboBox.Name = "yearBilling_comboBox";
            this.yearBilling_comboBox.Size = new System.Drawing.Size(140, 21);
            this.yearBilling_comboBox.TabIndex = 95;
            // 
            // monthBilling_comboBox
            // 
            this.monthBilling_comboBox.FormattingEnabled = true;
            this.monthBilling_comboBox.Location = new System.Drawing.Point(92, 130);
            this.monthBilling_comboBox.Name = "monthBilling_comboBox";
            this.monthBilling_comboBox.Size = new System.Drawing.Size(140, 21);
            this.monthBilling_comboBox.TabIndex = 94;
            // 
            // mailDate_picker
            // 
            this.mailDate_picker.Location = new System.Drawing.Point(83, 200);
            this.mailDate_picker.Name = "mailDate_picker";
            this.mailDate_picker.Size = new System.Drawing.Size(200, 20);
            this.mailDate_picker.TabIndex = 93;
            // 
            // billingId_textBox
            // 
            this.billingId_textBox.Location = new System.Drawing.Point(91, 64);
            this.billingId_textBox.Name = "billingId_textBox";
            this.billingId_textBox.Size = new System.Drawing.Size(141, 20);
            this.billingId_textBox.TabIndex = 92;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(19, 67);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(48, 13);
            this.label24.TabIndex = 91;
            this.label24.Text = "Billing ID";
            // 
            // insertBilling_button
            // 
            this.insertBilling_button.Location = new System.Drawing.Point(233, 294);
            this.insertBilling_button.Name = "insertBilling_button";
            this.insertBilling_button.Size = new System.Drawing.Size(94, 32);
            this.insertBilling_button.TabIndex = 90;
            this.insertBilling_button.Text = "Insert";
            this.insertBilling_button.UseVisualStyleBackColor = true;
            this.insertBilling_button.Click += new System.EventHandler(this.insertBilling_button_Click);
            // 
            // loadBilling_button
            // 
            this.loadBilling_button.Location = new System.Drawing.Point(333, 294);
            this.loadBilling_button.Name = "loadBilling_button";
            this.loadBilling_button.Size = new System.Drawing.Size(94, 32);
            this.loadBilling_button.TabIndex = 89;
            this.loadBilling_button.Text = "Load";
            this.loadBilling_button.UseVisualStyleBackColor = true;
            this.loadBilling_button.Click += new System.EventHandler(this.loadBilling_button_Click);
            // 
            // cancelBilling_Button
            // 
            this.cancelBilling_Button.Location = new System.Drawing.Point(533, 294);
            this.cancelBilling_Button.Name = "cancelBilling_Button";
            this.cancelBilling_Button.Size = new System.Drawing.Size(94, 32);
            this.cancelBilling_Button.TabIndex = 88;
            this.cancelBilling_Button.Text = "Cancel";
            this.cancelBilling_Button.UseVisualStyleBackColor = true;
            this.cancelBilling_Button.Click += new System.EventHandler(this.cancelBilling_Button_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(322, 205);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(54, 13);
            this.label23.TabIndex = 86;
            this.label23.Text = "Paid Date";
            // 
            // paidDate_picker
            // 
            this.paidDate_picker.Location = new System.Drawing.Point(427, 199);
            this.paidDate_picker.Name = "paidDate_picker";
            this.paidDate_picker.Size = new System.Drawing.Size(200, 20);
            this.paidDate_picker.TabIndex = 85;
            // 
            // amtToPay_textBox
            // 
            this.amtToPay_textBox.Location = new System.Drawing.Point(427, 131);
            this.amtToPay_textBox.Name = "amtToPay_textBox";
            this.amtToPay_textBox.Size = new System.Drawing.Size(141, 20);
            this.amtToPay_textBox.TabIndex = 80;
            // 
            // meterReading_textBox
            // 
            this.meterReading_textBox.Location = new System.Drawing.Point(427, 99);
            this.meterReading_textBox.Name = "meterReading_textBox";
            this.meterReading_textBox.Size = new System.Drawing.Size(141, 20);
            this.meterReading_textBox.TabIndex = 79;
            // 
            // meterNumber_textBox
            // 
            this.meterNumber_textBox.Location = new System.Drawing.Point(427, 64);
            this.meterNumber_textBox.Name = "meterNumber_textBox";
            this.meterNumber_textBox.Size = new System.Drawing.Size(141, 20);
            this.meterNumber_textBox.TabIndex = 78;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(322, 166);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(28, 13);
            this.label22.TabIndex = 75;
            this.label22.Text = "Paid";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(322, 134);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 13);
            this.label21.TabIndex = 74;
            this.label21.Text = "Amount To Pay";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(322, 102);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 13);
            this.label20.TabIndex = 73;
            this.label20.Text = "Meter Reading";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(322, 67);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 13);
            this.label19.TabIndex = 72;
            this.label19.Text = "Meter Number";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 205);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 13);
            this.label18.TabIndex = 71;
            this.label18.Text = "Mail Date";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 166);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 13);
            this.label17.TabIndex = 70;
            this.label17.Text = "Billing Year";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 134);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 13);
            this.label16.TabIndex = 69;
            this.label16.Text = "Billing Month";
            // 
            // custBilling_textBox
            // 
            this.custBilling_textBox.Location = new System.Drawing.Point(90, 99);
            this.custBilling_textBox.Name = "custBilling_textBox";
            this.custBilling_textBox.Size = new System.Drawing.Size(141, 20);
            this.custBilling_textBox.TabIndex = 68;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 67;
            this.label15.Text = "Customer ID";
            // 
            // AdminBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 521);
            this.Controls.Add(this.adminTab);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.title);
            this.Name = "AdminBoard";
            this.Text = "AdminBoard";
            this.groupBox1.ResumeLayout(false);
            this.editCustomerPanel.ResumeLayout(false);
            this.editCustomerPanel.PerformLayout();
            this.adminTab.ResumeLayout(false);
            this.editCustomer_tabPage.ResumeLayout(false);
            this.editBilling_tabPage.ResumeLayout(false);
            this.editBilling_tabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Button compareReportButton;
        private System.Windows.Forms.Button editBilling_button;
        private System.Windows.Forms.Button editCustomer_button;
        private System.Windows.Forms.Panel editCustomerPanel;
        private System.Windows.Forms.TextBox custId_textBox;
        private System.Windows.Forms.ComboBox country_comboBox;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox uname_textBox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.TextBox cell_phone_textBox;
        private System.Windows.Forms.TextBox ssn_textBox;
        private System.Windows.Forms.TextBox postal_code_textBox;
        private System.Windows.Forms.ComboBox state_comboBox;
        private System.Windows.Forms.TextBox city_textBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox address_textBox;
        private System.Windows.Forms.TextBox last_name_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox first_name_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Label editCustomerLabel;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.TabControl adminTab;
        private System.Windows.Forms.TabPage editCustomer_tabPage;
        private System.Windows.Forms.TabPage editBilling_tabPage;
        private System.Windows.Forms.TextBox custBilling_textBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox billingId_textBox;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button insertBilling_button;
        private System.Windows.Forms.Button loadBilling_button;
        private System.Windows.Forms.Button cancelBilling_Button;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker paidDate_picker;
        private System.Windows.Forms.TextBox amtToPay_textBox;
        private System.Windows.Forms.TextBox meterReading_textBox;
        private System.Windows.Forms.TextBox meterNumber_textBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker mailDate_picker;
        private System.Windows.Forms.ComboBox yearBilling_comboBox;
        private System.Windows.Forms.ComboBox monthBilling_comboBox;
        private System.Windows.Forms.RadioButton paidNo_radioButton;
        private System.Windows.Forms.RadioButton paidYes_radioButton;
        private System.Windows.Forms.Button updBilling_button;
    }
}