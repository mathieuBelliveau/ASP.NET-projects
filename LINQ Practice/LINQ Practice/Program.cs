using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var lowNums = from num in nums where num < 5 select num;
            var lowNums2 = nums.Where((digit, index) => digit < 5);//logically equivalent to the above

            

            foreach (var x in lowNums2)
                Console.WriteLine(x);

            var firstNums = nums.Take(3);
            foreach (var x in firstNums)
                Console.WriteLine(x);

            var lessThan = nums.TakeWhile(n => n < 6);

        }
    }
}
