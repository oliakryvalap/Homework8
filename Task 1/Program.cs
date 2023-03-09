// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

int[,] array = new int[3, 4];

for (int i = 0; i < array.GetLength(0); i++)
{
    Console.WriteLine();
   for (int j = 0; j < array.GetLength(1); j++) 
   {
   array[i, j] = new Random().Next(2, 7);
   Console.Write(array[i, j] + " ");
}
}
void SortToLower(int[,] array)

    
    {
        for    (int i = 0;   i < array.GetLength(0); i++)
        
        {
            int min = i;
            for    (int j = 0;   j < array.GetLength(1)  ; j++)
        
            {  
                if (array[i, j] < array[min, j]);  
                int min = j;                      
                
            }
            int tmp = array[i, j];
            array[i, j] = array[min, j];
            array[min, j] = tmp;
        }
    }

SortToLower(array);


 