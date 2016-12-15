namespace CallCenter.Presentation
{
    partial class ServiceMaintance
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
            this.btn_assign = new MetroFramework.Controls.MetroButton();
            this.btn_track = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_esculate = new MetroFramework.Controls.MetroButton();
            this.btn_reassign = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_assign
            // 
            this.btn_assign.Location = new System.Drawing.Point(166, 281);
            this.btn_assign.Name = "btn_assign";
            this.btn_assign.Size = new System.Drawing.Size(105, 23);
            this.btn_assign.TabIndex = 0;
            this.btn_assign.Text = "Assign Requests";
            // 
            // btn_track
            // 
            this.btn_track.Location = new System.Drawing.Point(23, 281);
            this.btn_track.Name = "btn_track";
            this.btn_track.Size = new System.Drawing.Size(105, 23);
            this.btn_track.TabIndex = 1;
            this.btn_track.Text = "Track jobs";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // btn_esculate
            // 
            this.btn_esculate.Location = new System.Drawing.Point(166, 329);
            this.btn_esculate.Name = "btn_esculate";
            this.btn_esculate.Size = new System.Drawing.Size(105, 23);
            this.btn_esculate.TabIndex = 4;
            this.btn_esculate.Text = "esculate job";
            // 
            // btn_reassign
            // 
            this.btn_reassign.Location = new System.Drawing.Point(23, 329);
            this.btn_reassign.Name = "btn_reassign";
            this.btn_reassign.Size = new System.Drawing.Size(105, 23);
            this.btn_reassign.TabIndex = 3;
            this.btn_reassign.Text = "re-assign";
            // 
            // ServiceMaintance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 408);
            this.Controls.Add(this.btn_esculate);
            this.Controls.Add(this.btn_reassign);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_track);
            this.Controls.Add(this.btn_assign);
            this.Name = "ServiceMaintance";
            this.Text = "ServiceMaintance";
            this.Load += new System.EventHandler(this.ServiceMaintance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_assign;
        private MetroFramework.Controls.MetroButton btn_track;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton btn_esculate;
        private MetroFramework.Controls.MetroButton btn_reassign;
    }
}