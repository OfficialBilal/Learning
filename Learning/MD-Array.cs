﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class MD_Array
    {
        public static void Main(string[] args)
        {
            int[,] num =

                { { 1, 2, 3},
                  { 4, 5, 6},
                  { 7, 8, 9},};

            num[1, 2] = 10;
             
             Console.WriteLine(num[1, 2]);

            int[,] a = new int[5, 10];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = i+j;
                    Console.Write(a[i, j]+ "\t");
                }
                Console.WriteLine();
            }
            
        }
    }
}