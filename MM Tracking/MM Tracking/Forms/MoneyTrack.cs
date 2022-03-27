using MM_Tracking.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MM_T_Library;
using MM_T_Library.Models;
using System.Data.SQLite;
using System.Configuration;



namespace MM_Tracking.Forms
{
    public partial class MoneyTrack : Form
    {
        // define a message to show if something wrong in the customized error message 
        string errorMsg;
        // empty list of customer to use it for the check 
        List<instrument> instrumentCheck = new List<instrument>();
          // defing a sqlite data access instance to access it functions 
        sqliteDataAccess con = new sqliteDataAccess();
        // get the current selected food to pass it as para in the confirmation message
        instrument currentInstrument;
        // check what is the current state delete or edit to pass it when challing the confirmation message
        string state;
        public MoneyTrack()
        {
            InitializeComponent();
            WireUpLists();
        }


        public void WireUpLists()
        {
            moneyList.DataSource = null;
            this.moneyList.DataSource = con.instrument_GetAll();
            this.moneyList.DisplayMember = "insShow";
        }
   

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {

                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            CustomizedErrorMessage.Show("Voulez vous vraiment quitter L'application?", "alerte", "Oui", "Non");
            if (CustomizedErrorMessage.closeProgram)
            {
                Application.Exit();
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            Home home = (Home)Application.OpenForms["Home"];
            home.Show();
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
             if (ValidateForm())
            {
               
                instrument ins = new instrument(numTxt.Text, beneTxt.Text, moneyTxt.Text, dateTxt.Text);
                // save costumer
                con.instrument_Create(ins);

                numTxt.Text = "";
                beneTxt.Text ="";
                moneyTxt.Text="";
                dateTxt.Text ="";
                WireUpLists();
                CustomizedErrorMessage.Show("Article créé", "Client", "Ok!","");

            }
            else
            {
                CustomizedErrorMessage.Show(errorMsg, "Erreur", "OK!","");
            }
        }
         private bool ValidateForm()
        {
            instrumentCheck = con.instrument_GetAll();
            bool output = true;
            float f = 0f;
            foreach (instrument ins in instrumentCheck)
            {
                if (ins.Number == numTxt.Text)
                {
                    output = false;
                    errorMsg = "Le code déjà existe ";
                    break;

                }
            }
            if (numTxt.Text.Length == 0 || beneTxt.Text.Length == 0 || moneyTxt.Text.Length == 0 || dateTxt.Text.Length == 0)
            {
                output = false;
                errorMsg = "Certain champs sont vides !";
            }
             if (!float.TryParse(moneyTxt.Text, out f))
            {
                output = false;
                errorMsg = "Montant doit étre en forme numérique !";
            }
            
            return output;
        }

         private void editBtn_Click(object sender, EventArgs e)
         {
              if (ValidateForm()) { 
             if (moneyList.SelectedValue != null)
             {
                 state = "edit";
                 currentInstrument = new instrument(numTxt.Text, beneTxt.Text, moneyTxt.Text, dateTxt.Text);
                 string _id = moneyList.GetItemText(this.moneyList.SelectedItem);
                 ConfirmationForm.Show("Confirmation", "êtes-vous sûr de modifier cet article:\n" + _id, currentInstrument, state);
             }
             else
             {
                 CustomizedErrorMessage.Show("Vous devez d'abord sélectionner quelle entité a supprimer", "Erreur", "", "Ok!");
             }
              }
              else
              {
                  CustomizedErrorMessage.Show(errorMsg, "Erreur", "OK!", "");
              }
         }
         public void editIns(instrument paraIns)
         {
            
             con.instrument_Edit(paraIns);
        
         }

         public void deleteIns(instrument paraIns)
         {
             con.instrument_Delete(paraIns);
             numTxt.Text = "";
             beneTxt.Text = "";
             moneyTxt.Text = "";
             dateTxt.Text = "";
         }

         private void deleteBtn_Click(object sender, EventArgs e)
         {
             if (moneyList.SelectedValue != null)
             {
                 state = "delete";
                 currentInstrument = (instrument)moneyList.SelectedItem;
                 string _id = moneyList.GetItemText(this.moneyList.SelectedItem);
                 ConfirmationForm.Show("Confirmation", "êtes-vous sûr de supprimer cet article:\n" + _id, currentInstrument, state);
             }
             else
             {
                 CustomizedErrorMessage.Show("Vous devez d'abord sélectionner quelle entité a supprimer", "Erreur","", "Ok!");
             }
         }

         private void MoneyTrack_Activated(object sender, EventArgs e)
         {
             WireUpLists();
         }
        }
    }

