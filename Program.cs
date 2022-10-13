//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
void FillArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(0, 10);
        }
}
void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($" {Array[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}   
Console.Clear();
Console.Write("Введите число строк массива m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива n = ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] Array1= new int[m,n];
FillArray(Array1);
int [] ArraySum= new int[Array1.GetLength(0)];
for (int i = 0; i < Array1.GetLength(0); i++)
    {   for (int j = 0; j < Array1.GetLength(1); j++)
        {
            ArraySum[i]=ArraySum[i]+Array1[i,j];
                     
        }
    }
int Min=ArraySum[0];
int Num=0;
for (int k=0; k<Array1.GetLength(0); k++)
    {
        if (ArraySum[k]<Min)
        {
            Min=ArraySum[k];
            Num=k;
        }   
    }
Console.WriteLine();
PrintArray(Array1);
Console.Write($"Номер строки с наименьшей суммой элементов: {Num+1} строка");