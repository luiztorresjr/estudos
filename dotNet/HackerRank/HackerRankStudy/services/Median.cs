using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankStudy.services
{
    public class Median
    {
       
        public static int findMedian(List<int> arr)
        {
            arr = arr.OrderBy(i => i).ToList();
            return arr[arr.Count / 2];
        }
    }
}
