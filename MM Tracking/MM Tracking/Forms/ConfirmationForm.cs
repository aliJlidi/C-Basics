using MM_T_Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MM_Tracking.Forms
{
    public partial class ConfirmationForm : Form
    {
        MoneyTrack cstmForm = new MoneyTrack();
        static string opState;
        public static instrument insNew;
        public ConfirmationForm()
        {
            InitializeComponent();
        }
        static ConfirmationForm conForm;

        public static void Show(string caption, string label, instrument ins, string state)
        {
            conForm = new ConfirmationForm();
            conForm.captionLbl.Text = caption;
            conForm.msgLbl.Text = label;
            insNew = ins;
            opState = state;
            conForm.Show();

        }
    

        private void validBtn_Click(object sender, EventArgs e)
        {
            switch (opState)
            {
                case "delete":
                    cstmForm.deleteIns(insNew);
                    break;
                case "edit":
                    cstmForm.editIns(insNew);
                    break;

            }

            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            cstmForm.WireUpLists();
        }
    }
}
