using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomUser.Model;


namespace KKB.BLL.Model
{
    public class ServiceUser
    {
        public bool LogOn(User user, out string message)
        {
            if (user.login == "admin" & user.password.Equals("admin")) 
            {
                results result= GenerateUser.GetUser();
                user.fullName =  string.Format("{0} {1} {2}",
                    result.name.title, 
                    result.name.first, 
                    result.name.last);
                message= string.Format("{0} {1} {2}",
                    result.name.title,
                    result.name.first,
                    result.name.last);

                user.accounts = ServiceAccount.GetAccounts();
                message = "ok";
                return true;
                
            }
            else
            {
                message = "Неправильный пароль";
                return false;
            }
            
        }
    }
}
