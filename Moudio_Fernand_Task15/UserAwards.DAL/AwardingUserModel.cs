using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAwards.DAL
{
    public class AwardingUserModel : IAwardingUserModel
    {
        public void AddAwarding(AwardingUser awarding)
        {
            Data.AwadingUserList.Add(awarding);
        }

        public IEnumerable<AwardingUser> GetList()
        {
            return Data.AwadingUserList;
        }
        public List<int> GetAwardingListForCurrentUser(int UserId)
        {
            List<int> UserAwardingList = new List<int>();
            foreach (var item in Data.AwadingUserList)
            {
                if (item.UserId == UserId)
                {
                    UserAwardingList.Add(item.AwardId);
                }
            }
            return UserAwardingList;
        }

        public void RemoveAwarding(AwardingUser awarding)
        {
            Data.AwadingUserList.Remove(awarding);
        }
    }
}
