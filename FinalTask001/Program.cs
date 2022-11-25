// Написать программу , которая из имеющегося массива строк формирует массив из строк, длина которых, меньше либо равна 3 символам.

string[] array1 = new string[5] { "Russia", "-2", "hello", ":-)", "computer science" };

string[] array2 = new string[array1.Length];

Console.Write("[{0}]", string.Join(", ", array1));