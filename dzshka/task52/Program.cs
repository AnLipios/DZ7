//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов 
//в каждом столбце.



using System;
using static System.Console;

Clear();


void PrintArray(int[,] mass)
{
    for (int m=0; m<mass.GetLength(0); m++)
    {
        for (int n=0; n< mass.GetLength(1); n++)
        {
            Write($"{mass[m,n]} ");
            }
            WriteLine();
    }
    
}

void FillArray(int[,]mass)
{
    for (int m=0; m<mass.GetLength(0); m++)
    {
        for (int n=0; n<mass.GetLength(1); n++)
        {
            mass[m,n]=new Random().Next(1,10);
        }
    }
  
}

void GetAverage(int[,]mass)
{
    for (int n = 0; n < mass.GetLength(1); n++)
    {
        double sum = 0;
        for (int m = 0; m < mass.GetLength(0); m++)
        {
            sum += mass[m, n];
        }
        Write($"{ sum / mass.GetLength(0)} ");
    }
}

int[,] mass=new int[4,6];
FillArray(mass);
PrintArray (mass);
WriteLine("----------");
GetAverage (mass);
WriteLine();