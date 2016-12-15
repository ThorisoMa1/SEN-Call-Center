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

namespace CallCenter.Presentation
{
    public partial class BusinessClient : MetroForm
    {
        public BusinessClient()
        {
            InitializeComponent();
        }

        private void BusinessClient_Load(object sender, EventArgs e)
        {

        }
        
        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_new_Click(object sender, EventArgs e)
        {
               EnableControls();
               btn_submit.Width=190;
               btn_submit.Height = 23;

        }
        private void EnableControls() 
        {
            txt_bussName.Visible = true;
            drp_location.Visible = true;
            txt_bussName.Visible = true;
            drp_location.Visible = true;
        }
    }
}
