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
        public UserService userService;



        public UserController() 
        {
            userService = new UserService();
        }


        public void GetById()
        {
            var users = userService.GetAll();

            var result = userService.GetById(users, 1);

            Console.WriteLine(result.fullname + " " + result.id);

        }



        public void GetAllUsers()
        {
            var result = userService.GetAll();

            foreach (var item in result)
            {
                Console.WriteLine(item.fullname + "," + item.id + ","+ item.age);
            }
        }













    }
}
