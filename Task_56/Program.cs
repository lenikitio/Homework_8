// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int[,] GetBiArray(int Strok, int Stolb, int min, int max)
{
    if(Strok == Stolb) 
    {
        Console.WriteLine("Необходим прямоугольный массив");
        return null;
    }
    else
    {
    Random rnd = new Random();
    int[,] result = new int[Strok, Stolb];
    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = rnd.Next(min, max + 1);
        }
    }
    return result;
    }
}

void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
}


void GetSumStrok(int[,] array)
{
    int Sum = 0;
    int result = 0;
    int number = 0;
    for(int k = 0; k < array.GetLength(1); k++ )
    {
        result += array[0, k];
    }
    for(int i = 1; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Sum += array[i,j];
        }
        if(Sum <= result) 
        {
            result = Sum;
            number = i;
        }
        Sum = 0;
    }
    Console.WriteLine($"Наименьшая сумма элементов в строке под номером {number}");
}

int[,] array = GetBiArray(6, 3, 0, 9);
PrintArray(array);
GetSumStrok(array);
