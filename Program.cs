using NMlab1;

internal class Program
{
    private static void Main(string[] args)
    {
        SimpleIteration simpleIteration;
        Console.WriteLine("Simple Iteration: ");
        simpleIteration = new SimpleIteration();
        Newton newton;
        Console.WriteLine("\n\nNewton: ");
        newton = new Newton();
        ModificatedNewthon modificatedNewthon;
        Console.WriteLine("\n\nModificated Newthon: ");
        modificatedNewthon = new ModificatedNewthon();
        Console.ReadKey();
    }
}