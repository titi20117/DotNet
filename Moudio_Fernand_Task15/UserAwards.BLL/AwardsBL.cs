using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAwards.DAL;

namespace UserAwards.BLL
{
    public class AwardsBL
    {
        private static int StartAwardId;
        private readonly IAwardModel awardModel;

        public AwardsBL()
        {
            awardModel = new AwardModel();
        }
        public IEnumerable<Awards> GetList()
        {
            return awardModel.GetList();
        }
        public Awards GetUserById(int Id)
        {
            Awards CurrentAward = awardModel.GetAwardById(Id);
            return CurrentAward;
        }
        public void CreateNewAward(string Title, string Description)
        {
            Awards TargetAward = new Awards();
            TargetAward.ID = StartAwardId += 1;
            TargetAward.Title = Title;
            TargetAward.Description = Description;
            awardModel.Add(TargetAward);
        }
        public void EditCurrentAward(string Title, string Description, Awards CurrentAward)
        {
            CurrentAward.Title = Title;
            CurrentAward.Description = Description;
        }

        public void DeleteCurrentAwardById(int Id)
        {
            awardModel.RemoveById(Id);

        }

        public List<int> GetAwardIdList()
        {
            return awardModel.GetAwardIdList();
        }

        public List<string> GetAwardTitleList()
        {
            return awardModel.GetAwardTitleList();
        }

        public string GetTitleById(int AwardId)
        {
            foreach (var item in awardModel.GetList())
            {
                if (item.ID == AwardId)
                {
                    return item.Title;
                }
            }
            return null;

        }
    }
}
