﻿//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.

//0,5 7 -2 -0,2

//1 -3,3 8 -9,9

//8 7,8 -7,1 98 

Random rnd = new Random();
double[,] nums = new double[3,4];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        nums[i, j] = rnd.NextDouble() * 20 - 10;
        Console.Write(Math.Round(nums[i, j], 1) + " ");
    }
    Console.WriteLine();
}

