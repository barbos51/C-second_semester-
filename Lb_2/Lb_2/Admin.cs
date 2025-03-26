using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb_2
{
    internal class Admin : User
    {
        public Admin(string userName, string email, string password) : base(userName, email, password)
        {
        }

        public void BlockUser(User user)
        {
            Console.WriteLine($"Користувача {UserName} заблоковано");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Роль: Адміністратор");
        }

        
    }
}
