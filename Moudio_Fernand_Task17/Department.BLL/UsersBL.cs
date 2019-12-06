using System;
using Department.DAL;
using Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.BLL
{
    public class UsersBL
    {
        private readonly IUsersDAO usersDAO;
        public int indexOfUser;
        public UsersBL()
        {
            usersDAO = new UsersBdDAO();
            //studentsDAO = new StudentDAOdb();
        }

        public IEnumerable<Users> InitList()
        {
            return GetList();
        }

        public IEnumerable<Users> SortStudentsByFullNameAsc()
        {
            return (from s in GetList()
                    orderby s.FirstName ascending
                    select s);
        }

        public IEnumerable<Users> SortStudentsByFullNameDesc()
        {
            return (from s in GetList()
                    orderby s.FirstName descending
                    select s).ToList();
        }

        public void Add(string parFirstName, string parLastName, DateTime parDateTime, string rewards)
        {
            int ID;
            if (GetList().Count() != 0)
            {
                ID = GetList().ToList()[GetList().Count() - 1].ID + 1;
            }
            else
            {
                ID = 1;
            }
            Users user = new Users(ID, parFirstName, parLastName, parDateTime);
            if (rewards != "")
            {
                user.Rewards = rewards;
            }
            this.Add(user);
        }

        public void Add(Users user)
        {
            if (user == null)
                throw new ArgumentException("student");

            usersDAO.Add(user);
        }
        public void DeleteReward(int indexOfUsers,string reward)
        {
            usersDAO.DeleteReward(indexOfUsers, reward);
        }
        public void Delete()
        {
            usersDAO.Delete(indexOfUser);
        }
        public void Edit(string firstName,string lastName,DateTime birthdate, string rewards)
        {
            usersDAO.Edit(indexOfUser,firstName, lastName, birthdate, rewards);
        }
        public IEnumerable<Users> GetList()
        {
            return usersDAO.GetList();
        }
    }
}
