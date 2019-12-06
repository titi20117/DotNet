using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAwards.DAL
{
    public class AwardModel : IAwardModel
    {
        public IEnumerable<Awards> GetList()
        {
            return Data.AwardList;
        }
        public Awards GetAwardById(int Id)
        {
            foreach (var item in Data.AwardList)
            {
                if (Id == item.ID)
                {
                    return item;
                }
            }
            return null;

        }
        public List<int> GetAwardIdList()
        {
            List<int> AwardIdList = new List<int>();
            foreach (var item in Data.AwardList)
            {
                AwardIdList.Add(item.ID);
            }
            return AwardIdList;
        }
        public void Add(Awards TargetAward)
        {
            if (TargetAward == null)
            {
                throw new AggregateException("award null");
            }
            Data.AwardList.Add(TargetAward);
        }
        public void RemoveById(int Id)
        {
            Data.AwardList.Remove(GetAwardById(Id));
        }

        public List<string> GetAwardTitleList()
        {
            List<string> AwardTitleList = new List<string>();
            foreach (var item in Data.AwardList)
            {
                AwardTitleList.Add(item.Title);
            }
            return AwardTitleList;
        }
    }
}
