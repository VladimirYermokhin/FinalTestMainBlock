Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
Console.WriteLine("Введите строки массива через пробел");
string input = Console.ReadLine()!;
string[] inputArray = input.Split(' ');