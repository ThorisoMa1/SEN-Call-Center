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
    public partial class InsertNewClient : MetroForm
    {
        public InsertNewClient()
        {
            InitializeComponent();
        }
        
         Business_Layer.Issues I;
         Contract c;

        public void InsertNewClient_Load(object sender, EventArgs e)
        {

            I = new Business_Layer.Issues();
            c = new Contract();
            
            drp_Issue.DataSource = DataHandler.issue;
            drp_contract.DataSource = DataHandler.ct;

            drp_Issue.DisplayMember = "Issue";
            drp_contract.DisplayMember = "contractName";
            drp_contract.ValueMember = "contractName";
            drp_Issue.ValueMember = "Issue";


            drp_clientType.Items.Add("Business");
            drp_clientType.Items.Add("Individual");
            drp_clientType.SelectedIndex = 0;

            AgeDropDown();//populates the  age dropdown
           
            
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {

            
            Client customer = new Client();
            customer.InsertClient(txt_Name.Text, txt_SurName.Text, int.Parse(drp_Age.SelectedValue.ToString()), txt_Number.Text, drp_contract.SelectedValue.ToString(), drp_Issue.SelectedValue.ToString());

        }
        private void AgeDropDown() 
        {
            List<int> Ages = new List<int>();
            for (int i = 20; i < 100; i++)
            {
                Ages.Add(i);
            }
            drp_Age.DataSource = Ages;

        }
        public static void Succesfullinsert() 
        {
            MessageBox.Show("Client is inserted");
        }
        public static void FailedInsert()
        {
            MessageBox.Show("ClientFailed to insert");
        }
    }
}
