using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using Microsoft.CodeAnalysis.Operations;
using System.Reflection.Emit;

namespace BenchmarkTEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BenchmarkTest benchmark = new();
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
           //var result1 = benchmark.Fib(15);
            
           //var result2 = benchmark.FibRecursive(15);
            
        }
    }
     
    public class BenchmarkTest 
    {
        [Benchmark]
        public int  Fib () 
        {
            int x = 15;
            int a = 0;
            int b = 1;
            for (int i = 0; i < x ; i++) 
            {
                int temp = a;
                a = b;
                b = temp + a;
            }
            return a;
        }
        [Benchmark]
        public int FibRecursive() 
        {
            int x = 15;
            if (x == 0) 
            {
                return 0;
            
            }
            if (x == 1) 
            {
                return 1;
            }
            return (x - 1) + (x - 2);
        }
    
    
    
    }
}