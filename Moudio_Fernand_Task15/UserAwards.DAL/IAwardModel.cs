using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAwards.DAL
{
    public interface IAwardModel
    {
        IEnumerable<Awards> GetList();
        Awards GetAwardById(int Id);
        List<int> GetAwardIdList();
        void Add(Awards TargetAward);
        void RemoveById(int Id);
        List<string> GetAwardTitleList();
    }
}
