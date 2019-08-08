using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace BenchMark
{
    [MemoryDiagnoser]
    public class ArrayVsList
    {
        [Benchmark]
        [Arguments(1000)]
        public void ArrayTest(int length)
        {
            int[] a = new int[length];
            for (int i = 0; i < length; i++)
            {
                a[i] = i;
            }
        }

        [Benchmark]
        [Arguments(1000)]
        public void ListTest(int length)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < length; i++)
            {
                list.Add(i);
            }
        }
    }


}

