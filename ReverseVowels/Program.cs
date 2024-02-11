namespace ReverseVowels;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Example 1");
        var reverseVowels = new Vowels();
        var result = reverseVowels.ReverseVowels("hello");
        var output = "holle";
        Console.WriteLine($"Resultado: {result == output}");
    }
}
