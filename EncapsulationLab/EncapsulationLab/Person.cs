using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOLabs
{
    class Person
    {
        public string Name { get; set; }

        public int ID { get; set; }

        public Person(string name, int id)
        {
            this.Name = name;
            this.ID = id;
        }
    }
}
