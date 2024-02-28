using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractise.Models
{
    internal class PractiseUser
    {
        public string name;
        public int age;
        public string surname;
        public string password;



        public PractiseUser()
        {

        }




        public void SetPassword(string password)
        {
            this.password = password;
        }

        public string GetPassword()
        {
            return password;
        }






    }




}
