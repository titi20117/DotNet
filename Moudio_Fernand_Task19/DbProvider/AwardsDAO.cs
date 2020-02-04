using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DbProvider
{
    public class AwardsDAO : IAwardsDAO
    {
        private List<Awards> awards = new List<Awards>();
        private List<Awards> Empty = new List<Awards>();
        public void Add(Awards award)
        {
            if (award == null)
                throw new ArgumentException("award");

            awards.Add(award);
        }

        public string AwardAt(int indexOfAward)
        {
            return awards[indexOfAward].Title;
        }

        public void Delete(int index)
        {
            awards.RemoveAt(index);
            if(awards.Count != 0)
            {
                for (int i = 0; i < awards.Count; i++)
                {
                    awards[i].Id = i + 1;
                }
            }
        }

        public void Edit(int indexOfAwards, string title, string description)
        {
            awards[indexOfAwards].Title = title;
            awards[indexOfAwards].Description = description;
        }

        public IEnumerable<Awards> GetEmpty()
        {
            return Empty;
        }

        public IEnumerable<Awards> GetList()
        {
            return awards;
        }
    }
}
