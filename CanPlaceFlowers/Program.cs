namespace CanPlaceFlowers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Example 1");
        var solution = new Solution();
        int[] flowerbed = [1, 0, 0, 0, 1];
        var n = 1;
        var output = true;

        var result = solution.CanPlaceFlowers(flowerbed, n);
        Console.WriteLine("Result:" + result);
        Console.WriteLine(result == output);

        Console.WriteLine("Example 2");
        flowerbed = [0, 0, 1, 0, 1];
        n = 1;
        output = true;
        result = solution.CanPlaceFlowers(flowerbed, n);
        Console.WriteLine("Result:" + result);
        Console.WriteLine(result == output);

        Console.WriteLine("Example 3");
        flowerbed = [0, 0, 1, 0, 0];
        n = 1;
        output = true;
        result = solution.CanPlaceFlowers(flowerbed, n);
        Console.WriteLine("Result:" + result);
        Console.WriteLine(result == output);
    }
}
