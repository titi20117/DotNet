using System;
using System.Collections.Generic;
using System.Text;

namespace DbProvider
{
    interface IUsersDAO
    {
        void Add(Entities.Users user);
        void Delete(int index);
        void Edit(int indexOfUser, string firstName, string lastName, DateTime birthdate, string awards);
        void AddAward(int indexOfUser, string award);
        void DeleteAward(int indexOfUser, string award);
        IEnumerable<Entities.Users> GetList();
    }
}
