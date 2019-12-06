using System;
using Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.DAL
{
    public interface IRewardsDAO
    {
        void Add(Entities.Rewards reward);
        void Delete(int index);
        void Edit(int indexOfRewards, string title, string description);
        string RewardAt(int indexOfReward);
        System.Collections.Generic.IEnumerable<Entities.Rewards> GetList();
        System.Collections.Generic.IEnumerable<Entities.Rewards> GetEmpty();
    }
}
