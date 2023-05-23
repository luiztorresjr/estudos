using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankStudy.services
{
    public class TwoArrays
    {
        public static string twoArrays(int k, List<int> A, List<int> B)
        {
            var a = A.OrderBy(x => x).ToList();
            var b = B.OrderByDescending(x => x).ToList<int>();
            for (int i = 0; i < a.Count(); i++)
            {
                if (a[i] + b[i] >= k) continue;
                else return "NO";
            }
            return "YES";
        }
    }
}
