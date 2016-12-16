using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOLabs
{
    class TA : Student,ITeach
    {
        public ArrayList TitlesTaught { get; set; }

        public string Subject { get; set; }

        public int ClassLimit { get; set; }

        public TA(string name, int ID):base(name, ID)
        {
            ClassLimit = 2;
        }

        public void AddClass(string className)
        {
            //check if class name is there
            if (!(TitlesTaught.Contains(className)) && ((TitlesTaught == null) || (TitlesTaught.Count<ClassLimit)))
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
