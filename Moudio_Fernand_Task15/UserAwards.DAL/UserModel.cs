using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAwards.DAL
{
    public class UserModel : IUserModel
    {
        public IEnumerable<User> GetList()
        {
            return Data.UserList;
        }

        public User GetUserById(int Id)
        {
            foreach (var item in Data.UserList)
            {
                if (Id == item.ID)
                {
                    return item;
                }
            }
            return null;

        }

        public void Add(User TargetUser)
        {
            if (TargetUser == null)
            {
                throw new AggregateException("user null");
            }
            Data.UserList.Add(TargetUser);
        }

        public void RemoveById(int Id)
        {
            Data.UserList.Remove(GetUserById(Id));
        }
    }
}
