using System;
using Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.DAL
{
    public class UsersDAO: IUsersDAO
    {
        private List<Users> users = new List<Users>();

        public void Add(Users user)
        {
            if (user == null)
                throw new ArgumentException("student");

            users.Add(user);
        }

        public void Delete(int index)
        {
            users.RemoveAt(index);
            if (users.Count != 0)
            {
                for (int i = 0; i < users.Count; i++)
                {
                    users[i].ID = i + 1;
                }
            }
        }
        public void Edit(int indexOfUser, string firstName, string lastName, DateTime birthdate, string rewards)
        {
            users[indexOfUser].FirstName = firstName;
            users[indexOfUser].LastName = lastName;
            users[indexOfUser].Birthdate = birthdate;
            users[indexOfUser].Rewards = rewards;
        }
        public IEnumerable<Users> GetList()
        {
            return users;
        }
        public void AddReward(int indexOfUser,string reward)
        {
            users[indexOfUser].Rewards = users[indexOfUser].Rewards +" "+ reward;
        }
        public void DeleteReward(int indexOfUser,string reward)
        {
            users[indexOfUser].Rewards = users[indexOfUser].Rewards.Replace(reward, "");
        }
    }
    
}
