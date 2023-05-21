using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankStudy.services
{
    public class CountingSort
    {
        public static List<int> countingSort(List<int> arr)
        {
            Dictionary<int, int> indexCount = new Dictionary<int, int>();
            int tamanho = arr.Count;
            if (arr.Count > 100)
            {
                tamanho = 100;
            }
            for (int i = 0; i < tamanho; i++)
            {
                indexCount.Add(i, 0);
            }
            for (int i = 0; i < arr.Count; i++)
            {
                if (indexCount.ContainsKey(arr[i]))
                {
                    indexCount[arr[i]]++;
                }
                else
                {
                    indexCount[arr[i]] = 1;
                }
            }
            List<int> result = new List<int>();
            foreach (int value in indexCount.Values)
            {
                result.Add(value);
            }
            return result;
        }
    }
}
