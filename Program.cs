﻿// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] CreateArray(int size)
{
    string[] arr = new string[size];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Please enter the first elemet of the array: ");
        arr[i] = Convert.ToString(Console.ReadLine());
    }
    return arr;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"\"{arr[i]}\", ");
        else Console.Write($"\"{arr[i]}\"");
    }
    Console.Write("]");
}

string[] AlterationArray(string[] arr)
{
    string[] arrSec = new string[arr.Length];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
        {  
                if (arr[i].Length < 3) 
                {
                    arrSec[j] = arr[i];
                    j++;
                }             
        }
        return arrSec;
}

Console.WriteLine("Please enter the size of your array: ");
int length = Convert.ToInt32(Console.ReadLine());

string[] array = CreateArray(length);
PrintArray(array);
Console.WriteLine("->");
string[] arraySecond = AlterationArray(array);
PrintArray(arraySecond);
