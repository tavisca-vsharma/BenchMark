using BenchmarkDotNet.Attributes;

namespace BenchMark
{
    [MemoryDiagnoser]
    public class ForEachVsFor
    {
        [Benchmark]
        [Arguments(1000)]
        public void ForTest(int length)
        {
            int[] a = new int[length];
            for (int i = 0; i < length; i++)
            {
                a[i] = i;
            }
            for (int i = 0; i < length; i++)
            {
                a[i] = i;
            }
        }

        [Benchmark]
        [Arguments(1000)]
        public void ForEachTest(int length)
        {
            int[] a = new int[length];
            for (int i = 0; i < length; i++)
            {
                a[i] = i;
            }

            foreach (var x in a)
            {
                var y = x;
            }
        }
    }


}

