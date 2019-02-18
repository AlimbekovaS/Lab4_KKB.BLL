using KKB.BLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KKB.WEB.Model
{
    public class ServiceMenu
    {
        private User user = null;

        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("1.Registration");
            Console.WriteLine("2.LogOn");
            Console.WriteLine(":");
            int choise = Int32.Parse(Console.ReadLine());
            if (choise==1)
            {
                RegistrationMenu();

            }
            else if(choise==2)
            {
                LogOnMenu();
            }
        }
        private void LogOnMenu()
        {
            string login = "";
            string password = "";
            string message = "";
            Console.WriteLine("Enter login: ");
            login = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            password = Console.ReadLine();
            ServiceUser surs = new ServiceUser();
            user = surs.LogOn(login, password, out message);
            if(user!=null)
            {
                AutoriseUserMenu();
            }
           else
            {
                Console.WriteLine( message);
                Thread.Sleep(3000);
                MainMenu();
            }
        }
        private void RegistrationMenu()
        {
            User user = new User();
            Console.Write("Enter Login: ");
            user.login = Console.ReadLine();

            Console.WriteLine("Enter Password: ");
            user.password = Console.ReadLine();
            Console.WriteLine("Enter Full Name:");
            user.fullName = Console.ReadLine();
            string message = "";
            ServiceUser susr = new ServiceUser();
            if(susr.Registration(user, out message))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(message);
                Console.ForegroundColor = ConsoleColor.White;

                Thread.Sleep(3000);
                MainMenu();
            }
            else
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ForegroundColor = ConsoleColor.White;

            }
;
        }
        public void AutoriseUserMenu()
        {
            Console.WriteLine("Приветствую Вас!{0} ", user.fullName);
            Console.WriteLine("1. Вывод баланса");
            Console.WriteLine("2. пополнение баланса");
            Console.WriteLine("3. Снять деньги со счета");
            Console.WriteLine("4. Выход");
        }
    }
}
