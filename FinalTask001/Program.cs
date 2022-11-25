// Написать программу , которая из имеющегося массива строк формирует массив из строк, длина которых, меньше либо равна 3 символам.

string[] array1 = new string[5] { "Russia", "-2", "hello", ":-)", "computer science" };

string[] array2 = new string[array1.Length];

Console.Write("[{0}]", string.Join(", ", array1));

void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"[{array[i]}]");
    }

}

SecondArray(array1, array2);
Console.Write($" -> ");
PrintArray(array2);