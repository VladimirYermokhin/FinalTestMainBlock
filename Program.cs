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
if (newSize == 0)
{
    Console.WriteLine("В массиве нет строк длиной 3 символа или меньше.");
}
else
{
    // Создаем новый массив
    string[] newArray = new string[newSize];
    int newIndex = 0;

    // Заполняем новый массив
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            newArray[newIndex] = inputArray[i];
            newIndex++;
        }
    }

    // Выводим новый массив
    Console.WriteLine("Новый массив из строк, длина которых меньше или равна 3 символам:");
    Console.WriteLine(string.Join(" ", newArray));
}

