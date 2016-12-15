namespace CallCenter.Presentation
{
    partial class BusinessClient
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
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.txt_new = new System.Windows.Forms.Button();
            this.btn_submit = new MetroFramework.Controls.MetroButton();
            this.txt_bussName = new MetroFramework.Controls.MetroTextBox();
            this.drp_location = new MetroFramework.Controls.MetroComboBox();
            this.txt_Zip = new MetroFramework.Controls.MetroTextBox();
            this.lbl_Name = new MetroFramework.Controls.MetroLabel();
            this.lbl_ZIP = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(153, 86);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 0;
            // 
            // txt_new
            // 
            this.txt_new.Location = new System.Drawing.Point(23, 92);
            this.txt_new.Name = "txt_new";
            this.txt_new.Size = new System.Drawing.Size(75, 23);
            this.txt_new.TabIndex = 1;
            this.txt_new.Text = "new Bussiness";
            this.txt_new.UseVisualStyleBackColor = true;
            this.txt_new.Click += new System.EventHandler(this.txt_new_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(84, 253);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(99, 23);
            this.btn_submit.TabIndex = 2;
            this.btn_submit.Text = "submit";
            // 
            // txt_bussName
            // 
            this.txt_bussName.Enabled = false;
            this.txt_bussName.Location = new System.Drawing.Point(421, 84);
            this.txt_bussName.Name = "txt_bussName";
            this.txt_bussName.Size = new System.Drawing.Size(121, 23);
            this.txt_bussName.TabIndex = 4;
            this.txt_bussName.Visible = false;
            // 
            // drp_location
            // 
            this.drp_location.Enabled = false;
            this.drp_location.FormattingEnabled = true;
            this.drp_location.ItemHeight = 23;
            this.drp_location.Location = new System.Drawing.Point(421, 188);
            this.drp_location.Name = "drp_location";
            this.drp_location.Size = new System.Drawing.Size(121, 29);
            this.drp_location.TabIndex = 5;
            this.drp_location.Theme = MetroFramework.MetroThemeStyle.Light;
            this.drp_location.Visible = false;
            // 
            // txt_Zip
            // 
            this.txt_Zip.Enabled = false;
            this.txt_Zip.Location = new System.Drawing.Point(421, 131);
            this.txt_Zip.Name = "txt_Zip";
            this.txt_Zip.Size = new System.Drawing.Size(121, 23);
            this.txt_Zip.TabIndex = 6;
            this.txt_Zip.Visible = false;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(319, 88);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(102, 19);
            this.lbl_Name.TabIndex = 7;
            this.lbl_Name.Text = "CompanyName";
            // 
            // lbl_ZIP
            // 
            this.lbl_ZIP.AutoSize = true;
            this.lbl_ZIP.Location = new System.Drawing.Point(319, 135);
            this.lbl_ZIP.Name = "lbl_ZIP";
            this.lbl_ZIP.Size = new System.Drawing.Size(57, 19);
            this.lbl_ZIP.TabIndex = 8;
            this.lbl_ZIP.Text = "Zipcode";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(329, 197);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Location";
            // 
            // BusinessClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 290);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lbl_ZIP);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.txt_Zip);
            this.Controls.Add(this.drp_location);
            this.Controls.Add(this.txt_bussName);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_new);
            this.Controls.Add(this.metroComboBox1);
            this.Name = "BusinessClient";
            this.Text = "BusinessClient";
            this.Load += new System.EventHandler(this.BusinessClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.Button txt_new;
        private MetroFramework.Controls.MetroButton btn_submit;
        private MetroFramework.Controls.MetroTextBox txt_bussName;
        private MetroFramework.Controls.MetroComboBox drp_location;
        private MetroFramework.Controls.MetroTextBox txt_Zip;
        private MetroFramework.Controls.MetroLabel lbl_Name;
        private MetroFramework.Controls.MetroLabel lbl_ZIP;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}