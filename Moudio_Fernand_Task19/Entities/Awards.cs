using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Awards
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Awards(int id, string title)
        {
            Id = id;
            Title = title;
        }

        public Awards(int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
        }
    }
}
