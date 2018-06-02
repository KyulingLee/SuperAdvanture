using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //생성자
        public Location(int id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;
        }
    }
}
