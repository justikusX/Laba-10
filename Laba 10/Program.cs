using System;

class ParentClass
{
    protected double a;
    protected double b;

    public ParentClass(double aValue, double bValue)
    {
        a = aValue;
        b = bValue;
    }
}

class ChildClass : ParentClass
{
    private double x;

    public ChildClass(double aValue, double bValue, double xValue) : base(aValue, bValue)
    {
        x = xValue;
    }

    public double Calculate()
    {
        return a * Math.Pow(x, 2) + b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значения a, b и x:");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double x = Convert.ToDouble(Console.ReadLine());

        ChildClass child = new ChildClass(a, b, x);
        double result = child.Calculate();

        Console.WriteLine($"Результат вычисления: {result}");
    }
}