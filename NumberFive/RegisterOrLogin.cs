using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSix
{
    internal class RegisterOrlogin
    {
        public void start()
        {
            List<string> userNames = new List<string>();
            List<string> passWords = new List<string>();
            Welcome();


            void Welcome()
            {
                Console.WriteLine("Kindly type 'Register' to Sign Up or 'Login' to Sign In");
                string answer = Console.ReadLine().ToLower();
                if (answer == "register")
                {
                    Register();
                }
                else if (answer == "login")
                {

                    Login();
                }
            }


            void Register()
            {

                Console.WriteLine("kindly put in your preferred UserName");
                string userInput = Console.ReadLine();
                userNames.Add(userInput);
                Console.WriteLine($"Hello {userInput}, Kindly set your password");
                var userPassword = Console.ReadLine();
                Console.WriteLine("Password has been set");
                passWords.Add(userPassword);
                Exit();
            }

            void Login()
            {
                Console.WriteLine("Welcome Back");
                Console.WriteLine($"Hi Kindly put in your password");
                var password = Console.ReadLine();
                if (password == passWords[0])
                {
                    Console.WriteLine($"Password is correct, welcome back");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
                Exit();
            }

            void Exit()
            {
                Console.WriteLine("Want to exit\nY or N");
                var exitOption = Console.ReadLine().ToUpper();
                if (exitOption == "Y")
                {
                    Environment.Exit(10);
                }
                else if (exitOption == "N")
                {
                    Welcome();
                }
            }
        }
    }
}

        
    