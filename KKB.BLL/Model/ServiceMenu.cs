using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKB.BLL.Model
{
    public class ServiceMenu
    {
        public void MainMenu(User user)
        {
            Console.WriteLine("Приветствую Вас!{0} ", user.fullName);
            Console.WriteLine("1. Вывод баланса");
            Console.WriteLine("2. пополнение баланса");
            Console.WriteLine("3. Снять деньги со счета");
            Console.WriteLine("4. Выход");
        }
    }
}
