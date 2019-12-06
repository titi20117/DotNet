using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAwards.DAL
{
    public interface IAwardingUserModel
    {
        IEnumerable<AwardingUser> GetList();
        void AddAwarding(AwardingUser awarding);
        List<int> GetAwardingListForCurrentUser(int UserId);
        void RemoveAwarding(AwardingUser awarding);
    }
}
