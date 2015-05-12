namespace ElxBillingSystem
{
    partial class loginForm
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
            this.uname_txtBox = new System.Windows.Forms.TextBox();
            this.password_txtBox = new System.Windows.Forms.TextBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.registerLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(529, 55);
            this.title.TabIndex = 0;
            this.title.Text = "Electrical Billing System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // uname_txtBox
            // 
            this.uname_txtBox.Location = new System.Drawing.Point(208, 169);
            this.uname_txtBox.Name = "uname_txtBox";
            this.uname_txtBox.Size = new System.Drawing.Size(170, 20);
            this.uname_txtBox.TabIndex = 4;
            // 
            // password_txtBox
            // 
            this.password_txtBox.Location = new System.Drawing.Point(208, 201);
            this.password_txtBox.Name = "password_txtBox";
            this.password_txtBox.PasswordChar = '*';
            this.password_txtBox.Size = new System.Drawing.Size(170, 20);
            this.password_txtBox.TabIndex = 5;
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(208, 263);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(75, 23);
            this.submit_button.TabIndex = 6;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(303, 263);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 7;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Location = new System.Drawing.Point(205, 235);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(106, 13);
            this.registerLabel.TabIndex = 8;
            this.registerLabel.TabStop = true;
            this.registerLabel.Text = "Register as new user";
            this.registerLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 360);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.password_txtBox);
            this.Controls.Add(this.uname_txtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Name = "loginForm";
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uname_txtBox;
        private System.Windows.Forms.TextBox password_txtBox;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.LinkLabel registerLabel;
    }
}

