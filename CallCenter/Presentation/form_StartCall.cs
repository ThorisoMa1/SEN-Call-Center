using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace CallCenter
{
    public partial class form_startCall : MetroForm
    {
        public form_startCall()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Validation();//will make sure that number is  not empty

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Validation() 
        {
            if (string.IsNullOrEmpty(txt_phoneNumber.Text)==true)
            {
                MessageBox.Show("please input a number ");
            }
            else
            {
                this.Hide();
                Presentation.form_callAnswer fca = new Presentation.form_callAnswer(txt_phoneNumber.Text);
                fca.Show(); ;
                
            }

        }//will return a validation value
    }
}
