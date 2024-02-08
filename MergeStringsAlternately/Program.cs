namespace MergeStringsAlternately;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Example 1:");
        var solution = new Solution();
        var result = solution.MergeAlternately("abc", "pqr");
        var output = "apbqcr";
        Console.WriteLine($"result {result}: {result == output}");


        Console.WriteLine("Example 2:");
        result = solution.MergeAlternately("ab", "pqrs");
        output = "apbqrs";
        Console.WriteLine($"result {result}: {result == output}");

        Console.WriteLine("Example 3:");
        result = solution.MergeAlternately("abcd", "pq");
        output = "apbqcd";
        Console.WriteLine($"result {result}: {result == output}");
    }
}
