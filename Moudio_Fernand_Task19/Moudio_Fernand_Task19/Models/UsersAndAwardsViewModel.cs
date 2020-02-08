using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moudio_Fernand_Task19.Models
{
    public class UsersAndAwardsViewModel
    {
        public List<Users> ListUsers { get; set; }
        public List<Awards> ListAwards { get; set; }
        public UsersAndAwardsViewModel()
        {
            ListUsers = new List<Users>();
            ListAwards = new List<Awards>();
        }
    }
}
