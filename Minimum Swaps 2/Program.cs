using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


namespace Minimum_Swaps_2
{
    class Program
    {
        static int minimumSwaps(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                while (arr[i] != i + 1)
                {
                    int temp = arr[i];
                    arr[i] = arr[temp - 1];
                    arr[temp - 1] = temp;
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            // Ordena un vector de manera acendente sin importar el tamaño, en la menor cantidad de movimientos 
            int[] arr = new int[4] { 4, 3, 1, 2 };
            int res = minimumSwaps(arr);
            Console.Read();
        }
    }
}
