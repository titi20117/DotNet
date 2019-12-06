using System;
using Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.DAL
{
    public class RewardsDAO : IRewardsDAO
    {
        private List<Rewards> rewards = new List<Rewards>();
        private List<Rewards> Empty = new List<Rewards>();
        public void Add(Rewards reward)
        {
            if (reward == null)
                throw new ArgumentException("student");

            rewards.Add(reward);
        }
        public void Delete(int index)
        {
            rewards.RemoveAt(index);
            if (rewards.Count != 0)
            {
                for (int i = 0; i < rewards.Count; i++)
                {
                    rewards[i].ID = i + 1;
                }
            }
        }
        public void Edit(int indexOfRewards, string title, string description)
        {
            rewards[indexOfRewards].Title = title;
            rewards[indexOfRewards].Description = description;
        }
        public IEnumerable<Rewards> GetList()
        {
            return rewards;
        }
        public IEnumerable<Rewards> GetEmpty()
        {
            return Empty;
        }
        public string RewardAt(int indexOfReward)
        {
            return rewards[indexOfReward].Title;
        }
    }
    
}
