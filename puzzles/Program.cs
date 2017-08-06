using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RandomArray();
            TossCoin(new Random());
            Names();
            MultTossCoin(1);
        }

        public static void RandomArray()
        {
            int[] arr = new int[10];
            Random rando = new Random();
            int sum = 0;
            int max = arr[0];
            for ( int i = 0; i<arr.Length; i++)
            {
                arr[i] = rando.Next(5,26);
                System.Console.WriteLine(arr[i]);
                if (arr[i]>max)
                {
                    max = arr[i];
                }
                sum += arr[i];
            }
            int min = arr[0];
            for (int j=0; j<arr.Length; j++)
            {
                if (arr[j]<min)
                {
                    min = arr[j];
                }
            }
            System.Console.WriteLine("the max value is " + max + ", the min value is " + min + ", and the sum of the array is " + sum);
        }

        public static void TossCoin(Random randoint)
        {
            System.Console.WriteLine("Tossing a Coin");
            if (randoint.Next(0,101) > 50)
            {
                System.Console.WriteLine("Tails");
            }
            else 
            {
                System.Console.WriteLine("Heads");
            }
        }
        public static void MultTossCoin(int num)
        {
            for ( int i = 0; i<num+1; i++)
            {
                TossCoin(new Random());
            }
        }

        public static string[] Names()
        {
            string[] name = {"Tiffany", "John", "Sammy", "Beth"};
            Random shuff = new Random();
            
            for (int i = 0; i < name.Length -1; i++)
            {
                int h = shuff.Next(i+1, name.Length-1);
                string p = name[i];
                name[i] = name[h];
                name[h] = p;


            }
            for(int j = 0; j<name.Length; j++)
            {
                System.Console.WriteLine(name[j]);
            }
            return name;
        }
    }
}
