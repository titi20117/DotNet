using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAwards.DAL
{
    internal class Data
    {
        public static List<User> UserList = new List<User>();

        public static List<Awards> AwardList = new List<Awards>();

        public static List<AwardingUser> AwadingUserList = new List<AwardingUser>();
    }
}
