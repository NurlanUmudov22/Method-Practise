using MethodPractise.Helpers.Constants;
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

        private readonly AccountService accountService;


        public AccountControllers()
        {
            accountService = new AccountService();
        }



        public void Login()
        {


            Console.WriteLine("Add your email:");
            Email:  string email = Console.ReadLine();


            if (!email.Contains("@"))
            {
                Console.WriteLine(ResponseMessages.IncorrectEmailFormat);
                goto Email;
            }


            Console.WriteLine("Add your password");
            string password = Console.ReadLine();

            var response = accountService.Login(email, password);

            if (response)
            {
                Console.WriteLine(ResponseMessages.LoginSuccess);
            }
            else
            {
                Console.WriteLine(ResponseMessages.LoginFailed);
            }








































            // Again:
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

    }
}
