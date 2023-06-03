using System;

class Program
{
    static void Main()
    {
        string str = "Hello, world!";
        
        Console.Write("Nhập ký tự cần đếm: ");
        char character = Console.ReadKey().KeyChar;
        Console.WriteLine();
        
        int count = CountOccurrences(str, character);
        
        Console.WriteLine("Số lần xuất hiện của ký tự '{0}' trong chuỗi là: {1}", character, count);

        Console.ReadKey();
    }

    static int CountOccurrences(string str, char character)
    {
        int count = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == character)
            {
                count++;
            }
        }

        return count;
    }
}
