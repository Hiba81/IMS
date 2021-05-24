using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ims
{
    public partial class login : Sample
    {
        public login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "") { nameErrorLabel.Visible = true; } else { nameErrorLabel.Visible = false; }
            if (passTxt.Text == "") { passErrorLabel.Visible = true; } else { passErrorLabel.Visible = false; }
            if(nameErrorLabel.Visible||passErrorLabel.Visible)
            {
                MainClass.showMSG("Fields with * are mandatory", "stop", "Error"); //error is the type of message

            }
            else
            {


                if (retrieval.getUserDetails(usernameTxt.Text, passTxt.Text))
                {
                    HomeScreen hm = new HomeScreen();
                    MainClass.showwindow(hm, this, MDI.ActiveForm);
                    
                }
                else
                {

                }
            }
        }


        private void login_Load(object sender, EventArgs e)
        {

        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "") { nameErrorLabel.Visible = true; } else { nameErrorLabel.Visible = false; }

        }

        private void passTxt_TextChanged(object sender, EventArgs e)
        {
            if (passTxt.Text == "") { passErrorLabel.Visible = true; } else { passErrorLabel.Visible = false; }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
            
    }
}
