using System;

namespace Departments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Total students placed in CS: ");
            int cs = int.Parse(Console.ReadLine());
            Console.Write("Total students placed in MECH: ");
            int mech = int.Parse(Console.ReadLine());
            Console.Write("Total students placed in MET: ");
            int met = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (cs >= mech && cs >= met)
            {
                Console.WriteLine( "Highest placement CS");
            }
            if (mech >= cs && mech >= met)
            {
                Console.WriteLine( "Highest placement MECH");
            }
            if (met >= cs && met >= mech)
            {
                Console.WriteLine( "Highest placement MET");
            }


        }
    }
}
