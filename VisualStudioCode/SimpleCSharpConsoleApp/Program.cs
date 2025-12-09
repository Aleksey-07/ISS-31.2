// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
class Program
{
    static void Main()
    {
        var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var evens = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("Четные числа: " + string.Join(", ", evens));
    }
}