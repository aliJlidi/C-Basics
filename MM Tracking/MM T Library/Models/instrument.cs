using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_T_Library.Models
{
   public  class instrument
    {
         public string Number { get; set; }
        public string Client { get; set; }
        public string Money { get; set; }
        public string Date { get; set; }
        public string insShow { get { return Number.PadRight(7)  + Client.PadRight(18) + Money + " TND".PadRight(7) +Date ; } }


        public instrument()
        {

        }

        public instrument(string insNum, string insBene, string insMoney, string insDate)
        {
            this.Number = insNum;
            this.Client = insBene;
            this.Money = insMoney;
            this.Date = insDate; 
        }
    }
}
