using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOLabs
{
    class Teacher : Person, ITeach
    {
        public string Subject { get; set; }

        public ArrayList TitlesTaught { get; set; }

        public int ClassLimit { get; set; }

        public Teacher(string name, int ID) : base(name, ID)
        {

        }

        public void AddClass(string className)
        {
            //check if class name is there
            if (!(TitlesTaught.Contains(className)))
            {
                TitlesTaught.Add(className);
            }
        }

        public void RemoveClass(string className)
        {
            if ((TitlesTaught.Contains(className)))
            {
                TitlesTaught.Remove(className);
            }
        }
    }
}
