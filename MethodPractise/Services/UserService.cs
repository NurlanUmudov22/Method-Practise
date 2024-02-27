using MethodPractise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractise.Services
{
    internal class UserService : User
    {

        public User[] GetAll()
        {

            User user1 = new()
            {
                id = 1,
                fullname = "User1 Userov1",
                age = 26,
                email = "user1@gmail.com",
                password = "user1..."
            };


            User user2 = new()
            {
                id = 2,
                fullname = "User2 Userov2",
                age = 29,
                email = "user2@gmail.com",
                password = "user2..."
            };



            User user3 = new()
            {
                id = 3,
                fullname = "User3 Userov3",
                age = 36,
                email = "user3@gmail.com",
                password = "user3..."
            };


            User user4 = new()
            {
                id = 4,
                fullname = "User4 Userov1",
                age = 27,
                email = "user4@gmail.com",
                password = "user4..."
            };

            User[] users = { user1, user2, user3, user4, };
            return users;


        }




        public User GetById(User[] users, int id)
        {
            return users.FirstOrDefault(m => m.id == id);
        }



    }
}
