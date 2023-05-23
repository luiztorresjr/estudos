using HackerRankStudy.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankStudy.intefaces
{
    public interface IResult
    {
        public static void miniMaxSum(List<int> arr) => SumMaxAndMin.miniMaxSum(arr);
        public static int findMedian(List<int> arr) =>  Median.findMedian(arr);
        public static int lonelyinteger(List<int> a) => Lonely.lonelyinteger(a);
        public static int diagonalDifference(List<List<int>> arr) => MatrixCalculate.diagonalDifference(arr);
        public static List<int> countingSort(List<int> arr) => CountingSort.countingSort(arr);
        public static string pangram(string s) => Pangram.pangrams(s);
        public static void plusMinus(List<int> arr) => PlusMinus.plusMinus(arr);
        public static int sockMerchant(int n, List<int> arr) => Pair.sockMerchant(n, arr);

        public static string twoArrays(int k, List<int> A, List<int> B) => TwoArrays.twoArrays(k, A, B);
    }
}
