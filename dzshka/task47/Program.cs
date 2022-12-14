//Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.


using System;
using static System.Console;

Clear();


void PrintArray(double[,] mass)
{
    for (int m=0; m<mass.GetLength(0); m++)
    {
        for (int n=0; n< mass.GetLength(1); n++)
        {
            Write($"{mass[m,n]:f2} ");
            }
            WriteLine();
    }
    
}

void FillArray(double[,]mass)
{
    for (int m=0; m<mass.GetLength(0); m++)
    {
        for (int n=0; n<mass.GetLength(1); n++)
        {
            mass[m,n]=new Random().NextDouble()*2+-3;
        }
    }
  
}


double[,] mass=new double[4,3];
FillArray(mass);
PrintArray (mass);

