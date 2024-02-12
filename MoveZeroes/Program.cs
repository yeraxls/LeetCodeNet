namespace MoveZeroes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var solution = new Solution();
        int[] input = [0,1,0,3,12];
        int[] output = [1,3,12,0,0];
        solution.MoveZeroes(input);
    }
}
