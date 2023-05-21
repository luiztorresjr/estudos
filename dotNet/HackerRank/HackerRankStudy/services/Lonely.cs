using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankStudy.services
{
    public class Lonely
    {
        public static int lonelyinteger(List<int> a)
        {
            int lonely = 0;
            a.ForEach(i =>
            {
                if (a.Count(x => x == i) > 1) return;
                else lonely = i;
            });
            return lonely;
        }

    }
}
