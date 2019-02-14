using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKB.BLL.Model
{
    public class User
    {
        public string login { get; set; }
        public string password { get; set; }
        public string fullName { get; set; }
        public DateTime dob { get; set; }
        public string iin { get; set; }
        public string phone { get; set; }

        public List<Account> accounts = new List<Account>();
    }
}
