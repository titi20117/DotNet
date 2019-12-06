using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAwards.DAL;

namespace UserAwards.BLL
{
    public class AwardingUsersBL
    {
        private readonly IAwardingUserModel awardingModel;
        private readonly IUserModel userModel;
        public AwardingUsersBL()
        {
            awardingModel = new AwardingUserModel();
            userModel = new UserModel();
        }
        public void AddAwardForUser(int UserId, int AwardId)
        {
            AwardingUser awarding = new AwardingUser();
            awarding.UserId = UserId;
            awarding.AwardId = AwardId;
            awardingModel.AddAwarding(awarding);
        }

        public List<int> GetUserAwardByUserId(int UserId)
        {
            return awardingModel.GetAwardingListForCurrentUser(UserId);
        }

        public List<int> GetUserIdByAwardId(int id)
        {
            List<int> tempList = new List<int>();
            foreach (var item in awardingModel.GetList())
            {
                if (item.AwardId == id)
                {
                    tempList.Add(item.UserId);
                }
            }
            return tempList;
        }



        public void RemoveAwardFromUser(int UserId, int AwardId)
        {
            List<AwardingUser> temp2 = new List<AwardingUser>();
            IEnumerable<AwardingUser> tempCollection = awardingModel.GetList();
            foreach (AwardingUser item in tempCollection)
            {
                if ((UserId == item.UserId) && (AwardId == item.AwardId))
                {
                    temp2.Add(item);
                }
            }
            foreach (AwardingUser item in temp2)
            {
                awardingModel.RemoveAwarding(item);
            }
        }

        public bool CheckAwardId(int UserId, int AwardId)
        {
            foreach (AwardingUser item in awardingModel.GetList())
            {
                if ((UserId == item.UserId) && (AwardId == item.AwardId))
                {
                    return false;
                }
            }
            return true;

        }
    }
}
