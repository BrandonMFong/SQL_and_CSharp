namespace Project_4
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
            this.SELECT = new System.Windows.Forms.Button();
            this.Account_Number_SELECT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Account_mem_name = new System.Windows.Forms.Label();
            this.CurrentBalance = new System.Windows.Forms.Label();
            this.Mem_Balance = new System.Windows.Forms.Label();
            this.Update_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Account_Number_UPDATE = new System.Windows.Forms.TextBox();
            this.New_First_Name = new System.Windows.Forms.TextBox();
            this.New_Last_Name = new System.Windows.Forms.TextBox();
            this.create_user_profile = new System.Windows.Forms.Label();
            this.newmemlastname = new System.Windows.Forms.TextBox();
            this.newmemfirstname = new System.Windows.Forms.TextBox();
            this.newacccountnum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.newmembalance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Account_to_delete = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SELECT
            // 
            this.SELECT.Location = new System.Drawing.Point(76, 290);
            this.SELECT.Name = "SELECT";
            this.SELECT.Size = new System.Drawing.Size(75, 23);
            this.SELECT.TabIndex = 0;
            this.SELECT.Text = "Enter";
            this.SELECT.UseVisualStyleBackColor = true;
            this.SELECT.Click += new System.EventHandler(this.button1_Click);
            // 
            // Account_Number_SELECT
            // 
            this.Account_Number_SELECT.Location = new System.Drawing.Point(76, 244);
            this.Account_Number_SELECT.Name = "Account_Number_SELECT";
            this.Account_Number_SELECT.Size = new System.Drawing.Size(100, 20);
            this.Account_Number_SELECT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Account Information";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name: ";
            // 
            // Account_mem_name
            // 
            this.Account_mem_name.AutoSize = true;
            this.Account_mem_name.Location = new System.Drawing.Point(272, 245);
            this.Account_mem_name.Name = "Account_mem_name";
            this.Account_mem_name.Size = new System.Drawing.Size(0, 13);
            this.Account_mem_name.TabIndex = 5;
            // 
            // CurrentBalance
            // 
            this.CurrentBalance.AutoSize = true;
            this.CurrentBalance.Location = new System.Drawing.Point(207, 280);
            this.CurrentBalance.Name = "CurrentBalance";
            this.CurrentBalance.Size = new System.Drawing.Size(89, 13);
            this.CurrentBalance.TabIndex = 6;
            this.CurrentBalance.Text = "Current Balance: ";
            // 
            // Mem_Balance
            // 
            this.Mem_Balance.AutoSize = true;
            this.Mem_Balance.Location = new System.Drawing.Point(306, 280);
            this.Mem_Balance.Name = "Mem_Balance";
            this.Mem_Balance.Size = new System.Drawing.Size(0, 13);
            this.Mem_Balance.TabIndex = 7;
            // 
            // Update_Button
            // 
            this.Update_Button.Location = new System.Drawing.Point(257, 137);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(75, 23);
            this.Update_Button.TabIndex = 8;
            this.Update_Button.Text = "Update";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "UPDATE USER PROFILE";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Account_Number_UPDATE
            // 
            this.Account_Number_UPDATE.Location = new System.Drawing.Point(247, 46);
            this.Account_Number_UPDATE.Name = "Account_Number_UPDATE";
            this.Account_Number_UPDATE.Size = new System.Drawing.Size(100, 20);
            this.Account_Number_UPDATE.TabIndex = 11;
            this.Account_Number_UPDATE.Text = "Account Number";
            // 
            // New_First_Name
            // 
            this.New_First_Name.Location = new System.Drawing.Point(247, 73);
            this.New_First_Name.Name = "New_First_Name";
            this.New_First_Name.Size = new System.Drawing.Size(100, 20);
            this.New_First_Name.TabIndex = 12;
            this.New_First_Name.Text = "New First Name";
            // 
            // New_Last_Name
            // 
            this.New_Last_Name.Location = new System.Drawing.Point(247, 100);
            this.New_Last_Name.Name = "New_Last_Name";
            this.New_Last_Name.Size = new System.Drawing.Size(100, 20);
            this.New_Last_Name.TabIndex = 13;
            this.New_Last_Name.Text = "New Last Name";
            // 
            // create_user_profile
            // 
            this.create_user_profile.AutoSize = true;
            this.create_user_profile.Location = new System.Drawing.Point(13, 14);
            this.create_user_profile.Name = "create_user_profile";
            this.create_user_profile.Size = new System.Drawing.Size(131, 13);
            this.create_user_profile.TabIndex = 14;
            this.create_user_profile.Text = "CREATE USER PROFILE";
            this.create_user_profile.Click += new System.EventHandler(this.label5_Click);
            // 
            // newmemlastname
            // 
            this.newmemlastname.Location = new System.Drawing.Point(23, 84);
            this.newmemlastname.Name = "newmemlastname";
            this.newmemlastname.Size = new System.Drawing.Size(100, 20);
            this.newmemlastname.TabIndex = 18;
            this.newmemlastname.Text = "New Last Name";
            // 
            // newmemfirstname
            // 
            this.newmemfirstname.Location = new System.Drawing.Point(23, 57);
            this.newmemfirstname.Name = "newmemfirstname";
            this.newmemfirstname.Size = new System.Drawing.Size(100, 20);
            this.newmemfirstname.TabIndex = 17;
            this.newmemfirstname.Text = "New First Name";
            // 
            // newacccountnum
            // 
            this.newacccountnum.Location = new System.Drawing.Point(23, 30);
            this.newacccountnum.Name = "newacccountnum";
            this.newacccountnum.Size = new System.Drawing.Size(100, 20);
            this.newacccountnum.TabIndex = 16;
            this.newacccountnum.Text = "Account Number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // newmembalance
            // 
            this.newmembalance.Location = new System.Drawing.Point(23, 111);
            this.newmembalance.Name = "newmembalance";
            this.newmembalance.Size = new System.Drawing.Size(100, 20);
            this.newmembalance.TabIndex = 19;
            this.newmembalance.Text = "Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Enter Account Number";
            // 
            // Account_to_delete
            // 
            this.Account_to_delete.Location = new System.Drawing.Point(141, 357);
            this.Account_to_delete.Name = "Account_to_delete";
            this.Account_to_delete.Size = new System.Drawing.Size(100, 20);
            this.Account_to_delete.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 45);
            this.button2.TabIndex = 22;
            this.button2.Text = "Delete Account";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Account_to_delete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.newmembalance);
            this.Controls.Add(this.newmemlastname);
            this.Controls.Add(this.newmemfirstname);
            this.Controls.Add(this.newacccountnum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.create_user_profile);
            this.Controls.Add(this.New_Last_Name);
            this.Controls.Add(this.New_First_Name);
            this.Controls.Add(this.Account_Number_UPDATE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.Mem_Balance);
            this.Controls.Add(this.CurrentBalance);
            this.Controls.Add(this.Account_mem_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Account_Number_SELECT);
            this.Controls.Add(this.SELECT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SELECT;
        private System.Windows.Forms.TextBox Account_Number_SELECT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Account_mem_name;
        private System.Windows.Forms.Label CurrentBalance;
        private System.Windows.Forms.Label Mem_Balance;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Account_Number_UPDATE;
        private System.Windows.Forms.TextBox New_First_Name;
        private System.Windows.Forms.TextBox New_Last_Name;
        private System.Windows.Forms.Label create_user_profile;
        private System.Windows.Forms.TextBox newmemlastname;
        private System.Windows.Forms.TextBox newmemfirstname;
        private System.Windows.Forms.TextBox newacccountnum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox newmembalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Account_to_delete;
        private System.Windows.Forms.Button button2;
    }
}

