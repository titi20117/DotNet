using System;
using Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.DAL
{
    public interface IUsersDAO
    {
        void Add(Entities.Users user);
        void Delete(int index);
        void Edit(int indexOfUser, string firstName, string lastName, DateTime birthdate, string rewards);
        void AddReward(int indexOfUser, string reward);
        void DeleteReward(int indexOfUser, string reward);
        System.Collections.Generic.IEnumerable<Entities.Users> GetList();
    }
}
