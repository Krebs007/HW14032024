﻿
using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        PrintArrayReverse(arr, arr.Length - 1);
    }
    
    public static void PrintArrayReverse(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(arr[index]);
            PrintArrayReverse(arr, index - 1);
        }
    }
}


