```

BenchmarkDotNet v0.13.10, Windows 10 (10.0.21996.1)
11th Gen Intel Core i5-11300H 3.10GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.306
  [Host]     : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2


```
| Method       | Mean      | Error     | StdDev    | Median    |
|------------- |----------:|----------:|----------:|----------:|
| Fib          | 7.9013 ns | 0.0589 ns | 0.0492 ns | 7.8924 ns |
| FibRecursive | 0.0017 ns | 0.0039 ns | 0.0091 ns | 0.0000 ns |
