// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
int[,] array = new int[4, 4];

for (int i = 0; i < array.GetLength(0); i++)
{
    Console.WriteLine();
   for (int j = 0; j < array.GetLength(1); j++) 
   {
   array[i, j] = new Random().Next(2, 7);
   Console.Write(array[i, j] + " ");
}
}