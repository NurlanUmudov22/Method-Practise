using MethodPractise.Helpers.Constants;
using MethodPractise.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractise.Controllers
{
    internal class UserController
    {
        private readonly UserService userService;



        public UserController() 
        {
            userService = new UserService();
        }


        public void GetById()
        {

            Console.WriteLine("Add user id:");
            UserId: string strId = Console.ReadLine();


            int id;

            bool isCorrectId = int.TryParse(strId, out id);

            if (isCorrectId)
            {
                var user = userService.GetById(userService.GetAll(), 2);
                if (user == null)
                {
                    Console.WriteLine(ResponseMessages.Notfound);
                    return;
                }

                string result = user.fullname + "," + user.email + "," + user.age;
                Console.WriteLine(result);

            }
            else
            {
                Console.WriteLine(ResponseMessages.IncorrectFormat);
                goto UserId;
            }

        }



        public void GetAllUsers()
        {
            var result = userService.GetAll();

            foreach (var item in result)
            {
                Console.WriteLine(item.fullname + "," + item.email + ","+ item.age);
            }
        }













    }
}
