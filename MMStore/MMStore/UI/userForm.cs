using MMStore.BLL;
using MMStore.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMStore.UI
{
    public partial class userForm : Form
    {
        public userForm()
        {
            InitializeComponent();
        }

        userBLL u = new userBLL();
        userDAL dal = new userDAL();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //getting data from UI
            u.firstName = fNameTxt.Text;
            u.lastName = lNameTxt.Text;
            u.email = eMailTxt.Text;
            u.userName = userTxt.Text;
            u.password = passTxt.Text;
            u.contact = contactTxt.Text;
            u.adress = addTxt.Text;
            u.gender = genderCmb.Text;
            u.userType = userTypeCmb.Text;
            u.addedDate = DateTime.Now;
            u.addedBy = 1;

            //Inserting data
            bool success = dal.Insert(u);
            ////check
            if (success)
            {
                MessageBox.Show("user successefuly created");
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }


  
    }
}
