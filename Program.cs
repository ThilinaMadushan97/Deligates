
using System.Numerics;

public delegate int myDeligate(int x, int y);
internal class Program
{

    private static void Main(string[] args)
    {
        Program p = new Program();
        myDeligate calculator;

        calculator = p.addition;
        Console.WriteLine("Addition is " + p.addition(5,6));

        calculator = p.multiplication;
        Console.WriteLine("Multiplication is " + p.multiplication(5,4));
    }

    public int addition (int x, int y)
    {
        return x + y;
    }

    public int multiplication (int x, int y)
    {
        return x * y;
    }
}