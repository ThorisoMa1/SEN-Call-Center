using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Components;

namespace CallCenter.Presentation
{
    public partial class form_callAnswer : MetroForm
    {


        string number;
        public form_callAnswer(string Number)
        {
            InitializeComponent();
            number = Number;
        }
        
        private void CallAnswerForm_Load(object sender, EventArgs e)
        {
            DataHandler dt = new DataHandler();
            dt.connect();

            
            SetInitialBoxes(dt);//ethdo for setting box values
            
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Emp_Click(object sender, EventArgs e)
        {

        }
        private void SetInitialBoxes(DataHandler dt) 
        {
            Call c = new Call(number);
            txt_name.Text = c.ClientName;
            txt_EmployeeID.Text = c.StaffId.ToString();
            txt_StartTime.Text = c.StartTime;

            c.SetStaffID(int.Parse(txt_EmployeeID.Text));

        

            if (string.IsNullOrEmpty(txt_name.Text))//will start  insert fom
            {
                MessageBox.Show("New client Entered");
                this.Hide();
                Presentation.InsertNewClient ic = new InsertNewClient();
                ic.Show();

            }
            
           
            

        }//will set  up the initial tables

        
       
    }
}
