// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class Program12
{
    static void Main()
    {
        var numbers = new[] { 1, 2, 3, 4, 5 };
        var squares = numbers.Select(n => n * n);
        Console.WriteLine("Квадраты: " + string.Join(", ", squares));
    }
}