using System;
using Department.DAL;
using Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.BLL
{
   public class RewardsBL
    {
        private readonly IRewardsDAO rewardsDAO;
        public int indexOfReward;
        public RewardsBL()
        {
            rewardsDAO = new RewardsBdDAO();
            //studentsDAO = new StudentDAOdb();
        }

        public IEnumerable<Rewards> InitList()
        {
            return GetList();
        }

        public IEnumerable<Rewards> SortStudentsByFullNameAsc()
        {
            return (from s in GetList()
                    orderby s.Title ascending
                    select s);
        }

        public IEnumerable<Rewards> SortStudentsByFullNameDesc()
        {
            return (from s in GetList()
                    orderby s.Title descending
                    select s).ToList();
        }

        public void Add(string parTitle, string parDescription)
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
            Rewards reward=new Rewards(ID, parTitle, parDescription); 
            this.Add(reward);
        }

        public void Add(Rewards reward)
        {
            if (reward == null)
                throw new ArgumentException("student");

            rewardsDAO.Add(reward);
        }

        public string Delete()
        {
            string rewardForDelete = rewardsDAO.RewardAt(indexOfReward);
            rewardsDAO.Delete(indexOfReward);
            return rewardForDelete;
        }
        public void Edit(int indexOfRewards, string title, string description)
        {
            rewardsDAO.Edit(indexOfRewards, title, description);
        }
        public IEnumerable<Rewards> GetList()
        {
            return rewardsDAO.GetList();
        }
        public IEnumerable<Rewards> GetEmpty()
        {
            return rewardsDAO.GetEmpty();
        }
    }
}
