using System;
using System.Threading.Tasks;
using SandBox;

namespace _2_Parallel_MergeSort
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //int[] arr = {211, 1, 3, 800, 540};
            //Sort.ParallelQuickSort(arr);
            ////Sort.SequentialQuickSort(arr);
            ////Sort.

            //Console.WriteLine(string.Join(", ", arr));
            //make it async
            //todo

            //SimpleSort.Run();

            int[] ar = { 3, 1, 7, 2, 2, 9, 0, 5, 49, 85, 78, 98, 26 };
            Task sort = SortAlgorithmSortAlgorithm<int>.MergeSortAsync(ar);
            //sort.Wait();

            foreach (int i in ar)
            {
                Console.Write(i+" ");
            }

            Console.WriteLine();

            //ar = new int[] { 3, 1, 7, 2, 2, 9 };
            //sort = SortAlgorithmSortAlgorithm<int>.MergeSortAsync(ar);
            //sort.Wait();
            //foreach (int i in ar)
            //    Console.WriteLine(i);


        }
       
    }
}
