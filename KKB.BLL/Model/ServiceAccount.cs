using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKB.BLL.Model
{
    public  class ServiceAccount
    {
        public static List<Account> GetAccounts()
        {
            List<Account> accounts = new List<Account>();
            Random rnd = new Random();
            for (int i = 0; i < rnd.Next(1,3); i++)
            {
                Account account = new Account();
                account.AccountNumber ="KZT"+ rnd.Next();
                account.balance = rnd.Next(10000, 20000000);
                account.CreateDate = DateTime.Now.AddMonths(rnd.Next(20, 100)*(-1));
                accounts.Add(account);
            }
            return accounts;
        }
    }
}
