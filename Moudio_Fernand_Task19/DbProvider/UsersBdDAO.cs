using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DbProvider
{
    public class UsersBdDAO : IUsersDAO
    {
        public void Add(Users user)
        {
            throw new NotImplementedException();
        }

        public void AddAward(int indexOfUser, string award)
        {
            throw new NotImplementedException();
        }

        public void Delete(int index)
        {
            throw new NotImplementedException();
        }

        public void DeleteAward(int indexOfUser, string award)
        {
            throw new NotImplementedException();
        }

        public void Edit(int indexOfUser, string firstName, string lastName, DateTime birthdate, string awards)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Users> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
