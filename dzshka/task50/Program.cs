//Напишите программу, которая на вход 
//принимает позиции элемента в двумерном 
//массиве, и возвращает значение этого 
//элемента или же указание, что такого 
//элемента нет.

using System;
using static System.Console;

Clear();

WriteLine("Введите строку числа: ");
int x = int.Parse(ReadLine());
WriteLine("Введите столбец числа: ");
int y = int.Parse(ReadLine());


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
            mass[m,n]=new Random().Next(1,100);
        }
    }
  
}


void PrintNumber(int[,] mass)
{
   
    for (int m = 0; m < mass.GetLength(0); m++)
    {
        for (int n = 0; n < mass.GetLength(1); n++)
        {
            if (x<0 || x>mass.GetLength(0) || y<0 || y>mass.GetLength(1) )
            WriteLine("Такого числа нет");
            else WriteLine($"Это число {mass[x-1,y-1]} "); 
            break;
        }
        break;
    }
}



int[,] mass=new int[7,4];
FillArray(mass);
PrintArray (mass);
WriteLine();
PrintNumber (mass);