// See https://aka.ms/new-console-template for more information
namespace GdipBenches;

using BenchmarkDotNet.Running;

public static class Program
{
    public static void Main(string[] args) =>
        BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
}
