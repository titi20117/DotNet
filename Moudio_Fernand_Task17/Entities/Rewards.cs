using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Rewards
    {

        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Rewards(int id, string parTitle)
        {
            ID = id;
            Title = parTitle;
        }
        public Rewards(int id, string parTitle, string parDescription)
        {
            ID = id;
            Title = parTitle;
            Description = parDescription;
        }
    
    }
}
