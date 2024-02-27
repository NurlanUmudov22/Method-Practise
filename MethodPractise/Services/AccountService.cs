using MethodPractise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractise.Services
{
    internal class AccountService : UserService
    {

       
        public User[] Login(User[] users, string email , string password)
        {
            return  users.Where(m => m.email.StartsWith(email) && m.password.StartsWith(password)).ToArray();
        }



    }
}
