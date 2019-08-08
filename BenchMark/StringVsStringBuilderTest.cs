using BenchmarkDotNet.Attributes;
using System.Text;

namespace BenchMark
{
    [MemoryDiagnoser]

    public class StringVsStringBuilderTest
    {
        [Benchmark]
        [Arguments(1000)]
        public void AppendUsingString(int length)
        {
            string one = "one string";
            for (int i = 0; i < length; i++)
            {
                one += "add string";
            }
        }

        [Benchmark]
        [Arguments(1000)]
        public void AppendUsingStringBuilder(int length)
        {
            StringBuilder stringBuilder = new StringBuilder("two string");
            for (int i = 0; i < length; i++)
            {
                stringBuilder.Append("add string");
            }
        }
    }


}

