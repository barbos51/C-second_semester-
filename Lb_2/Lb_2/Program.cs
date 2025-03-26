namespace Lb_2
{
    internal class Program
    {
        static void Main()
        {
            Admin admin = new Admin("Administrator", "sword@gmail.com", "qwerty123");
            Moderator moderator = new Moderator("Modder", "modder@ukr.net", "tasty124");
            RegularUser regularUser = new RegularUser("RegUser", "regusers@gmail.com", "banny");

            List<User> users = new List<User>();
            users.Add(admin);
            users.Add(moderator);
            users.Add(regularUser);

            for (int i = 0; i < users.Count; i++)
            {
                User user = users[i];

                string inputPassword = "banny";
                string inputEmail = "regusers@gmail.com";
                if (user.Authenticate(inputEmail, inputPassword))
                {
                    Console.WriteLine("Вхід виконан успішно");
                    if (user is Admin administrator)
                    {
                        administrator.DisplayInfo();
                        administrator.BlockUser(users[2]);
                    }
                    else if (user is Moderator moder)
                    {
                        moder.DisplayInfo();
                        moder.ModerateContent();
                    }
                    else if (user is RegularUser regUser)
                    {
                        regUser.DisplayInfo();
                        regUser.PostComment();
                        regUser.SetPassword(inputEmail, inputPassword, "shortcast");
                        
                    }
                }
                else
                {
                    Console.WriteLine("Не правильно введений е-мейл чи пароль");

                }
            }
            // for (int i = 0; i < users.Count; i++)
            //{
            //    User user = users[i];

            //    string inputPassword = "banny";
            //    string inputEmail = "regusers@gmail.com";
            //    if (user.Authenticate(inputEmail, inputPassword))
            //    {
            //        Console.WriteLine("Вхід виконан успішно");
            //        if (user is Admin administrator)
            //        {
            //            administrator.DisplayInfo();
            //            administrator.BlockUser(users[2]);
            //        }
            //        else if (user is Moderator moder)
            //        {
            //            moder.DisplayInfo();
            //            moder.ModerateContent();
            //        }
            //        else if (user is RegularUser regUser)
            //        {
            //            regUser.DisplayInfo();
            //            regUser.PostComment();
            //            regUser.SetPassword(inputEmail, inputPassword, "shortcast");
                        
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Не правильно введений е-мейл чи пароль");

            //    }
            //}

            
           

        }
           
        
    }
}
