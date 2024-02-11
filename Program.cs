/* Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
Console.WriteLine("Введите строки массива через пробел");
string input = Console.ReadLine()!;
string[] inputArray = input.Split(' ');
 */

Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
Console.WriteLine("Введите строки массива через пробел");
string input = Console.ReadLine()!;
string[] inputArray = input.Split(' ');

int newSize = 0;
for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length <= 3)
    {
        newSize++;
    }
}

