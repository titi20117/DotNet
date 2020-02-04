using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DbProvider
{
    public class UsersDAO : IUsersDAO
    {
        private List<Users> users = new List<Users>();
        public void Add(Users user)
        {
            if (user == null)
                throw new ArgumentException("user");
            
            users.Add(user);
        }

        public void AddAward(int indexOfUser, string award)
        {
            users[indexOfUser].Awards = users[indexOfUser].Awards + "\n" + award;
        }

        public void Delete(int index)
        {
            users.RemoveAt(index);
            if(users.Count != 0)
            {
                for (int i = 0; i < users.Count; i++)
                {
                    users[i].Id = i + 1;
                }
            }
        }

        public void DeleteAward(int indexOfUser, string award)
        {
            users[indexOfUser].Awards = users[indexOfUser].Awards.Replace(award, "");
        }

        public void Edit(int indexOfUser, string firstName, string lastName, DateTime birthdate, string awards)
        {
            users[indexOfUser].FirstName = firstName;
            users[indexOfUser].LastName = lastName;
            users[indexOfUser].BirthDate = birthdate;
            users[indexOfUser].Awards = awards;
        }

        public IEnumerable<Users> GetList()
        {
            return users;
        }
    }
}
