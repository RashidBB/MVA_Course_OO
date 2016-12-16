using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*
            Student rashid = new Student("Rashid", 100849541);
            
            for(int i=0; i<5; i++)
            {
                Console.WriteLine("Enter a grade ");
                double grade = Convert.ToDouble(Console.ReadLine());
                rashid.EnterGrade(grade);
            }

            Console.WriteLine("Your GPA is {0} ", rashid.GPA);
            Console.ReadLine();
            */

            Teacher Mr_Dan = new Teacher("Mr_Dan", 100853233);
            TA Tom = new TA("Tom", 1045453454);

            Tom.ClassLimit = 2;
            Tom.AddClass("Math");
            Tom.AddClass("Science");
            Tom.AddClass("Religion");

            Console.WriteLine("{0}", Tom.TitlesTaught.ToString());
            Console.ReadLine();
        }
    }
}
