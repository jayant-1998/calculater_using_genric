using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first input:");
        var input1 = Console.ReadLine();

        Console.WriteLine("Enter the operation (+ for addition, - for subtraction):");
        char operation = char.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second input:");
        var input2 = Console.ReadLine();

        //var t = PerformOperation<string>(""+"")


        string result;
        result = PerformOperation<double,double>(double.Parse(input1), double.Parse(input2), operation);


        Console.WriteLine($"Result: {result}");
    }

    static string PerformOperation<T,T2>(T input1, T2 input2, char operation)
    {
        dynamic result;
        switch (operation)
        {
            case '+':
                result = Add<T,T2>(input1, input2);
                break;
            case '-':
                result = Subtract<T,T2>(input1, input2);
                break;
            default:
                throw new ArgumentException("Invalid operation!");
        }

        return result.ToString();
    }

    static string Add<T, T2>(T a, T2 b)
    {
        dynamic sum = (dynamic)a + (dynamic)b;
        return sum.ToString();
    }

    static string Subtract<T,T2>(T a, T2 b)
    {
        dynamic difference = (dynamic)a - (dynamic)b;
        return difference.ToString();
    }
}
