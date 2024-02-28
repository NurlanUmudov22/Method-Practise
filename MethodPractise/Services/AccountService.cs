using MethodPractise.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractise.Services
{
    internal class AccountService 
    {

        private readonly UserService userService;


        public AccountService()
        {
            userService = new UserService();
        }


        public bool Login(string email, string password)
        {
            var users = userService.GetAll();
            return users.Any(m => m.email == email && m.password == password);
        }


    }
}
