using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson__6_Inheritance
{
    class Ring : Jewelry
    {
        static Ring()
        {
            Console.WriteLine("Static ring Ctor");
        }
        public Ring()
        {
            Console.WriteLine("Ring Ctor");
        }

        public float Diameter { get; set; }
        public TargetGender For { get; set; }

        //TODO: Use interface intead   // sa view-ic task list-um avtomat avelanum e, KARDAL SRA(TODO comment) MASIN, 
        public GemStone GemStone { get; set; }

       

    }
}
