using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankStudy.services
{
    public class SumMaxAndMin
    {
        public static void miniMaxSum(List<int> arr)
        {
            double total = 0;
            arr = arr.OrderBy(i => i).ToList();
            foreach (int i in arr)
            {
                total += i;
            }

            double max = total - arr.First();
            double min = total - arr.Last();
            Console.WriteLine($"{min} {max}");
        }


    }
}
