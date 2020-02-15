using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Moudio_Fernand_Task19.Models
{
    public class UsersAndAwardsViewModel
    {
        public List<Users> ListUsers { get; set; }
        public List<Awards> ListAwards { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateBirthday { get; set; }
        public Users NewUser { get; set; }
        public Awards NewAward { get; set; }
        public UsersAndAwardsViewModel()
        {
            ListUsers = new List<Users>();
            ListAwards = new List<Awards>();
        }
    }
}
