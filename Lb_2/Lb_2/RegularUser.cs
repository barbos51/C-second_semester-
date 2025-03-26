using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb_2
{
    internal class RegularUser : User
    {
        public RegularUser(string userName, string email, string password) : base(userName, email, password)
        {
        }

        public void PostComment()
        {
            Console.WriteLine("Коментар додано");
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Звичайний користувач");
        }
    }
}
