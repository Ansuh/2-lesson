using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson__6_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Ring j1 = new Ring();
            //string.Empty // readonly field e class-um, ev static e

            j1.BaseMaterial = Jewelry.Material.Platinium;
            Console.WriteLine(j1.GemStone?.Weight); // es kerp kanchelov mez apahovum enq vor ete 
                                                    // qar chlini ev null lini chvercnenq ev class-um null chunenanq   
            Console.ReadKey(); // start aneluc heto parzum es skzbum vo classn e ashxatum base-n te direct@, 
            //static ev ayln, Aghasic fayl@ vercnel ev nayel kodi sharunakutyun@!!!



        }
    }
}
