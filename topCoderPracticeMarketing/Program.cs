using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace topCoderPracticeMarketing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((new Solver()).solve( new String[]{"1 4",
                                "2",
                                "3",
                                "0",
	                        ""}));
            Console.WriteLine((new Solver()).solve( new String[]{"1","2","0"}));

            Console.WriteLine((new Solver()).solve(new String[] { "1", "2", "3", "0", "0 5", "1" }));

            Console.WriteLine((new Solver()).solve(new String[] {"","","","","","","","","","",
 "","","","","","","","","","",
 "","","","","","","","","",""}));

            Console.WriteLine((new Solver()).solve(new String[] { "1", "2", "3", "0", "5", "6", "4" }));

            Console.Read();
        }
    }
}
