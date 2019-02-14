using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKB.BLL.Model
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public double balance_;
            public double balance
        {
            get
            {
                return balance_;

            }

            set
            {
                if (value < 0)
                {
                    throw new Exception("Баланс не может быть отрицательным!");
                }
                else
                    balance_ = value;
            }
        
        }
        public DateTime CreateDate { get; set; }

    }
}
