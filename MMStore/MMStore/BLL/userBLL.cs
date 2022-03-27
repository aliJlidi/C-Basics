using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMStore.BLL
{
    class userBLL
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string contact { get; set; }
        public string adress { get; set; }
        public string gender { get; set; }
        public string userType { get; set; }
        public DateTime addedDate { get; set; }
        public int addedBy { get; set; }
    }
}
