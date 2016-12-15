namespace CallCenter.Presentation
{
    partial class form_callAnswer
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
            this.components = new System.ComponentModel.Container();
            this.txt_EmployeeID = new System.Windows.Forms.TextBox();
            this.btn_end = new System.Windows.Forms.Button();
            this.txt_StartTime = new System.Windows.Forms.TextBox();
            this.txt_endtime = new System.Windows.Forms.TextBox();
            this.Emp = new System.Windows.Forms.Label();
            this.callerName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_callerName = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_duritation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_EmployeeID
            // 
            this.txt_EmployeeID.Location = new System.Drawing.Point(198, 63);
            this.txt_EmployeeID.Name = "txt_EmployeeID";
            this.txt_EmployeeID.Size = new System.Drawing.Size(100, 20);
            this.txt_EmployeeID.TabIndex = 0;
            this.txt_EmployeeID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_end
            // 
            this.btn_end.Location = new System.Drawing.Point(21, 295);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(75, 23);
            this.btn_end.TabIndex = 1;
            this.btn_end.Text = "EndCall";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_StartTime
            // 
            this.txt_StartTime.Location = new System.Drawing.Point(198, 100);
            this.txt_StartTime.Name = "txt_StartTime";
            this.txt_StartTime.Size = new System.Drawing.Size(100, 20);
            this.txt_StartTime.TabIndex = 2;
            // 
            // txt_endtime
            // 
            this.txt_endtime.Location = new System.Drawing.Point(198, 138);
            this.txt_endtime.Name = "txt_endtime";
            this.txt_endtime.Size = new System.Drawing.Size(100, 20);
            this.txt_endtime.TabIndex = 3;
            // 
            // Emp
            // 
            this.Emp.AutoSize = true;
            this.Emp.Location = new System.Drawing.Point(23, 69);
            this.Emp.Name = "Emp";
            this.Emp.Size = new System.Drawing.Size(39, 13);
            this.Emp.TabIndex = 4;
            this.Emp.Text = "EmpID";
            this.Emp.Click += new System.EventHandler(this.Emp_Click);
            // 
            // callerName
            // 
            this.callerName.AutoSize = true;
            this.callerName.Location = new System.Drawing.Point(22, 107);
            this.callerName.Name = "callerName";
            this.callerName.Size = new System.Drawing.Size(74, 13);
            this.callerName.TabIndex = 5;
            this.callerName.Text = "call_StartTime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "callEndTime";
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(21, 251);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(277, 23);
            this.btn_confirm.TabIndex = 7;
            this.btn_confirm.Text = "Confirmation";
            this.btn_confirm.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(416, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 236);
            this.dataGridView1.TabIndex = 8;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(198, 172);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 9;
            // 
            // txt_callerName
            // 
            this.txt_callerName.AutoSize = true;
            this.txt_callerName.Location = new System.Drawing.Point(20, 175);
            this.txt_callerName.Name = "txt_callerName";
            this.txt_callerName.Size = new System.Drawing.Size(64, 13);
            this.txt_callerName.TabIndex = 10;
            this.txt_callerName.Text = "Caller Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Duritation";
            // 
            // txt_duritation
            // 
            this.txt_duritation.Location = new System.Drawing.Point(198, 213);
            this.txt_duritation.Name = "txt_duritation";
            this.txt_duritation.Size = new System.Drawing.Size(100, 20);
            this.txt_duritation.TabIndex = 14;
            // 
            // form_callAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 341);
            this.Controls.Add(this.txt_duritation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_callerName);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.callerName);
            this.Controls.Add(this.Emp);
            this.Controls.Add(this.txt_endtime);
            this.Controls.Add(this.txt_StartTime);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.txt_EmployeeID);
            this.Name = "form_callAnswer";
            this.Text = "CallAnswerForm";
            this.Load += new System.EventHandler(this.CallAnswerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_EmployeeID;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.TextBox txt_StartTime;
        private System.Windows.Forms.TextBox txt_endtime;
        private System.Windows.Forms.Label Emp;
        private System.Windows.Forms.Label callerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label txt_callerName;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_duritation;
    }
}