using HackerRankStudy.intefaces;

class Program
{
    public static void Main(string[] args)
    {


        List<int> arr = new List<int>() { 1, 1, 3, 2, 1};      

        List<int> result = IResult.countingSort(arr);

        result.ForEach(i => Console.WriteLine(i));

    }
}
