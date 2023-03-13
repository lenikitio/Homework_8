// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2 

 


Console.Clear();

int[,] GetBiArray(int Strok, int Stolb, int min, int max)
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

int[,] ArrangeBiArray(int[,] array)
{
    int[,] ArrangeArray = (int[,]) array.Clone();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int max = ArrangeArray[i, 0];
        int Value = 0;
        for(int j = 1; j < array.GetLength(1); j++)
        {
            if(ArrangeArray[i, j] > max)
            {
                max = ArrangeArray[i, j];
                ArrangeArray[i, j] = ArrangeArray[i, 0];
                ArrangeArray[i, 0] = max;
            }
            for(int k = 1; k < j; k++)
            {
                if(ArrangeArray[i, k] < ArrangeArray[i, j])
                {
                    Value = ArrangeArray[i, j];
                    ArrangeArray[i, j] = ArrangeArray[i, k];
                    ArrangeArray[i, k] = Value;
                }
            }
        }
    }
    return ArrangeArray;
}


int[,] BiArr = GetBiArray(4, 6, 0, 9);
PrintArray(BiArr);
int[,] Array = ArrangeBiArray(BiArr);
PrintArray(Array);
