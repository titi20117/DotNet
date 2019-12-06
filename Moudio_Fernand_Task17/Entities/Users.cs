using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Users
    {
        public int ID { get; set; }
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public DateTime Birthdate { get;  set; }
        public string Rewards { get; set; }
        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - Birthdate.Year;
                if (DateTime.Now.Month < Birthdate.Month)
                {
                    age--;
                }
                return age;
            }
        }

        public Users(int id, string parFirstName, string parLastName, DateTime parDateTime)
        {
            ID = id;
            FirstName = parFirstName;
            LastName = parLastName;
            Birthdate = parDateTime;
        }
    }
    

}
