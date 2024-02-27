using MethodPractise.Models;
using MethodPractise.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractise.Controllers
{
    internal class AccountControllers
    {

        public AccountService accountService;


        public AccountControllers()
        {
            accountService = new AccountService();
        }



        public void Login()
        {

            //Again:
            //Console.WriteLine("Add your email:");
            //string email = Console.ReadLine();

            //Console.WriteLine("Add your password");
            //string password = Console.ReadLine();


            //User[] userr = accountService.GetAll();

            //User[] users = accountService.Login(userr, email, password);
            
            //foreach (var item in users)
            //{

            //    //User[] userr = accountService.GetAll();

            //    //User[] users = accountService.Login(userr, email, password);


            //    if (item.email == email && item.password == password)
            //    {
            //        Console.WriteLine("LoginSuccess");
            //    }

            //    else
            //    {
            //        Console.WriteLine("Email or password is wrong");
            //        goto Again;
            //    }

               



            }









            //Login:
            //Console.WriteLine("Add your email:");
            //string email = Console.ReadLine();
            //Console.WriteLine("Write your password");
            //string password = Console.ReadLine();
            //if (email == email || password == null)
            //{
            //    Console.WriteLine("Login denied");
            //    goto Login;
            //}
            //else 
            //{
            //    Console.WriteLine("Login successfully");
            //}


            //var usersq = accountService.GetAll();

            //User[] user = accountService.Login(usersq, email, password);

            //if (ema)

            //Console.WriteLine("Add your password:");
            //string password = Console.ReadLine();

            //User[] user = accountService.Login(usersq, email, password);





        }


    }
}
