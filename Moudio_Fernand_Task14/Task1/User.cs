using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public int Age { get { return DateTime.Now.Year - Birthdate.Year; } }
        public BindingList<int> ListAward { get; set; }
        public string Award
        {
            get
            {
                return String.Join(",", ListAward);
            }

        }
    }
}
