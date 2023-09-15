using System.Diagnostics;
/* 
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
 */

using System;
using static System.Console;
Clear();

Write("Введите массив: ");
string arrayenter = Convert.ToString(ReadLine());

string[] filarray = new string[arrayenter.Length];

void CreatArray(string[] arrayenter, string[] array)
{
    int index = 0;
    for (int i = 0; i < arrayenter.Length; i++)
    {
        if (arrayenter[i].Length <= 3)
        {
            array[index] = arrayenter[i];
            index++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    WriteLine();
}
CreatArray(arrayenter, filarray);
PrintArray(filarray);
