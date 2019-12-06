using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAwards.DAL
{
    public interface IUserModel
    {
        IEnumerable<User> GetList();
        User GetUserById(int Id);
        void Add(User TargetUser);
        void RemoveById(int Id);
    }
}
