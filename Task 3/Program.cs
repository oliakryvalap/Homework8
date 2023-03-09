// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
 //Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int[,] array1 = new int[3, 4];
for (int i = 0; i < array1.GetLength(0); i++)
{
    Console.WriteLine();
   for (int j = 0; j < array1.GetLength(1); j++) 
   {
   array1[i, j] = new Random().Next(-10, 11);
   Console.Write(array1[i, j] + " ");
}
}
int[,] array2 = new int[3, 4];
for (int i = 0; i < array2.GetLength(0); i++)
{
    Console.WriteLine();
   for (int j = 0; j < array2.GetLength(1); j++) 
   {
   array2[i, j] = new Random().Next(-10, 11);
   Console.Write(array2[i, j] + " ");
}
}

  void Exploer(int[,] array1; int[,] array2; int[,] newarray;)
{
for (int i = 0; i < array1.GetLength(0); i++)
{
    Console.WriteLine();
   for (int j = 0; j < array1.GetLength(1); j++) 

      {for (int i = 0; i < array2.GetLength(0); i++)
{
    Console.WriteLine();
   for (int j = 0; j < array2.GetLength(1); j++) 
        
   {
    newarray[i, j]= array1[i, j] * array2[i, j];
        }
   Console.Write(newarray[i, j] + " ");
}
}
}
}


Console.WriteLine();
Exploer(array);   