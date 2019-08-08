using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace BenchMark
{
    [MemoryDiagnoser]
    public class ClassVsStruct
    {
        [Benchmark]
        [Arguments(1000)]
        public void CheckStruct(int length)
        {
            List<Item> list = new List<Item>();

            for (int i = 0; i < length; i++)
            {
                list.Add(new Item());
            }
        }

        [Benchmark]
        [Arguments(1000)]
        public void CheckClass(int length)
        {
            List<ItemName> list = new List<ItemName>();
            for (int i = 0; i < length; i++)
            {
                list.Add(new ItemName());
            }
        }


    }
    public struct Item
    {
        string name;
        int value;
    }
    public class ItemName
    {
        string name;
        int value;
    }


}

