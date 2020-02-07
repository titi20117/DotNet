using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moudio_Fernand_Task19.Models
{
    public class UsersViewModel
    {
        public List<Users> ListUsers { get; set; }
        public UsersViewModel()
        {
            ListUsers = new List<Users>();
        }
    }
}
