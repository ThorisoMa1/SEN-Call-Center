namespace CallCenter.Presentation
{
    partial class InsertNewClient
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
            this.txt_Name = new MetroFramework.Controls.MetroTextBox();
            this.txt_SurName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.drp_contract = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.drp_clientType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.drp_Issue = new MetroFramework.Controls.MetroComboBox();
            this.drp_Age = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txt_Number = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(183, 91);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(121, 23);
            this.txt_Name.TabIndex = 0;
            this.txt_Name.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // txt_SurName
            // 
            this.txt_SurName.Location = new System.Drawing.Point(183, 132);
            this.txt_SurName.Name = "txt_SurName";
            this.txt_SurName.Size = new System.Drawing.Size(121, 23);
            this.txt_SurName.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(35, 95);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(35, 136);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Surname";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(35, 235);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(33, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Age";
            // 
            // drp_contract
            // 
            this.drp_contract.FormattingEnabled = true;
            this.drp_contract.ItemHeight = 23;
            this.drp_contract.Location = new System.Drawing.Point(183, 267);
            this.drp_contract.Name = "drp_contract";
            this.drp_contract.Size = new System.Drawing.Size(121, 29);
            this.drp_contract.TabIndex = 7;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(35, 277);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Contract";
            // 
            // drp_clientType
            // 
            this.drp_clientType.FormattingEnabled = true;
            this.drp_clientType.ItemHeight = 23;
            this.drp_clientType.Location = new System.Drawing.Point(183, 315);
            this.drp_clientType.Name = "drp_clientType";
            this.drp_clientType.Size = new System.Drawing.Size(121, 29);
            this.drp_clientType.TabIndex = 9;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(35, 325);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(66, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "clientType";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "InsertClient";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(35, 369);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(36, 19);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Issue";
            // 
            // drp_Issue
            // 
            this.drp_Issue.FormattingEnabled = true;
            this.drp_Issue.ItemHeight = 23;
            this.drp_Issue.Location = new System.Drawing.Point(183, 359);
            this.drp_Issue.Name = "drp_Issue";
            this.drp_Issue.Size = new System.Drawing.Size(121, 29);
            this.drp_Issue.TabIndex = 13;
            // 
            // drp_Age
            // 
            this.drp_Age.FormattingEnabled = true;
            this.drp_Age.ItemHeight = 23;
            this.drp_Age.Location = new System.Drawing.Point(183, 225);
            this.drp_Age.Name = "drp_Age";
            this.drp_Age.Size = new System.Drawing.Size(121, 29);
            this.drp_Age.TabIndex = 14;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(35, 183);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(99, 19);
            this.metroLabel7.TabIndex = 15;
            this.metroLabel7.Text = "Phone Number";
            // 
            // txt_Number
            // 
            this.txt_Number.Location = new System.Drawing.Point(183, 179);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(121, 23);
            this.txt_Number.TabIndex = 16;
            // 
            // InsertNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 448);
            this.Controls.Add(this.txt_Number);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.drp_Age);
            this.Controls.Add(this.drp_Issue);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.drp_clientType);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.drp_contract);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_SurName);
            this.Controls.Add(this.txt_Name);
            this.Name = "InsertNewClient";
            this.Text = "InsertNewClient";
            this.Load += new System.EventHandler(this.InsertNewClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_Name;
        private MetroFramework.Controls.MetroTextBox txt_SurName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox drp_contract;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox drp_clientType;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox drp_Issue;
        private MetroFramework.Controls.MetroComboBox drp_Age;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txt_Number;
    }
}