namespace CallCenter
{
    partial class form_startCall
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
            this.btn_endCall = new System.Windows.Forms.Button();
            this.btn_Call = new System.Windows.Forms.Button();
            this.txt_phoneNumber = new System.Windows.Forms.TextBox();
            this.lbl_Number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_endCall
            // 
            this.btn_endCall.Location = new System.Drawing.Point(266, 242);
            this.btn_endCall.Name = "btn_endCall";
            this.btn_endCall.Size = new System.Drawing.Size(75, 23);
            this.btn_endCall.TabIndex = 0;
            this.btn_endCall.Text = "endCall";
            this.btn_endCall.UseVisualStyleBackColor = true;
            // 
            // btn_Call
            // 
            this.btn_Call.Location = new System.Drawing.Point(23, 242);
            this.btn_Call.Name = "btn_Call";
            this.btn_Call.Size = new System.Drawing.Size(75, 23);
            this.btn_Call.TabIndex = 1;
            this.btn_Call.Text = "Call";
            this.btn_Call.UseVisualStyleBackColor = true;
            this.btn_Call.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_phoneNumber
            // 
            this.txt_phoneNumber.Location = new System.Drawing.Point(241, 123);
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txt_phoneNumber.TabIndex = 2;
            this.txt_phoneNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_Number
            // 
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.Location = new System.Drawing.Point(36, 130);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(44, 13);
            this.lbl_Number.TabIndex = 3;
            this.lbl_Number.Text = "Number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 370);
            this.Controls.Add(this.lbl_Number);
            this.Controls.Add(this.txt_phoneNumber);
            this.Controls.Add(this.btn_Call);
            this.Controls.Add(this.btn_endCall);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_endCall;
        private System.Windows.Forms.Button btn_Call;
        private System.Windows.Forms.TextBox txt_phoneNumber;
        private System.Windows.Forms.Label lbl_Number;
    }
}

