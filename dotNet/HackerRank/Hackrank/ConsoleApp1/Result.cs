namespace interviewPreparation
{
    public class Result
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

        public static int findMedian(List<int> arr)
        {
            arr = arr.OrderBy(i => i).ToList();
            return arr[arr.Count/2];
        }

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

        public static int diagonalDifference(List<List<int>> arr)
        {
            int diagonalOne = 0;
            int diagonalTwo = 0;

            for(int r = 0; r < arr.Count; r++)
            {
                for(int c = 0; c < arr[r].Count; c++)
                {
                    if (r == c) diagonalOne += arr[r][c];
                    if((r + c) == (arr.Count - 1)) diagonalTwo += arr[r][c];
                }
            }

            return Math.Abs(diagonalTwo - diagonalOne);

        }

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
