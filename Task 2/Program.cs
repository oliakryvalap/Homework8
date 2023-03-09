// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array = new int[3, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    Console.WriteLine();
   for (int j = 0; j < array.GetLength(1); j++) 
   {
   array[i, j] = new Random().Next(-10, 11);
   Console.Write(array[i, j] + " ");
}
}
void PrintArray(int[,] array)
{
    for (int i = 0; i <  array.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            if (j < array.GetLength(1) -1) Console.Write($"{array[i, j], 1}|");
            else Console.Write($"{array[i, j], 1}");
        }
        Console.WriteLine("|");        
    }        
}

void SumStringArray(int[,] array)
{
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        int minsum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
            if (sum <= minsum) sum = minsum;
            index = i;        
            
        }
        Console.Write($"Строка с минимальной суммой элементов равна {array[i, j] }. ");
    }            
}
   


PrintArray(array);
SumStringArray(array);