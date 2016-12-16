using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOLabs
{
    interface ITeach
    {
        ArrayList TitlesTaught { get; set; }
        string Subject { get; set; }
        int ClassLimit { get; set; }

        void AddClass(string className);
        void RemoveClass(string className);
        
    }
}
