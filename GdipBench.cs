namespace GdipBenches;

using BenchmarkDotNet.Attributes;
using System.Drawing;

public class GdipBench
{
    [Benchmark]
    public void CreateFont()
    {
        var font = new Font("Arial", 12);
    }
}
