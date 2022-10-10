class Program
{
    public static void Main(string[] args)
    {
        int[] arr = new int[400];
        Console.WriteLine("Please enter a string ");
        string insertString = Console.ReadLine();
        for (int i = 0; i < insertString.Length; i++)
            arr[insertString[i]]++;

        int max = arr[0];

        for (int i = 0; i < 400; i++)
            if (arr[i] >= max)
                max = arr[i];

        Console.WriteLine();

        for (int i = 0; i < 400; i++)
            if (arr[i] == max)
            {
                Console.Write((char)i);
                Console.WriteLine($" - is repeated {arr[i]} times");
            }
    }
}