using BenchmarkDotNet.Running;
using System;

namespace YieldDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var prd = new ManageProducts();
            //prd.ListProducts();
            _ = BenchmarkRunner.Run<ManageProducts>();
        }
    }
}
