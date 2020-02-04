using System;
using System.Collections.Generic;
using System.Text;

namespace DbProvider
{
    interface IAwardsDAO
    {
        void Add(Entities.Awards award);
        void Delete(int index);
        void Edit(int indexOfAwards, string title, string description);
        string AwardAt(int indexOfAward);
        IEnumerable<Entities.Awards> GetList();
        IEnumerable<Entities.Awards> GetEmpty();
    }
}
