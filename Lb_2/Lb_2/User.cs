using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb_2
{
    internal class User
    {
        public string UserName {  get; set; }
        public string Email {  get; set; }
        private string _password {  get; set; }

        public User(string userName, string email, string password)
        {
            UserName = userName;
            Email = email;
            _password = password;
            
        }

        public void SetPassword(string email,string OldPassword ,string NewPassword)
        {
            if(!Authenticate(email, OldPassword))
            {
                return;
            }
            _password = NewPassword;
        }
        public bool Authenticate(string email,string inputPassword)
        {
            
                return email == Email && inputPassword == _password;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Нікнейм: {UserName}");
            Console.WriteLine($"Е-мейл: {Email}");
            
        }
    }
}
