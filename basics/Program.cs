using System;
using System.Collections.Generic;
namespace basics
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("*****************************");
            int[] arr = {3,23,20,85,25,13};
            array(arr);
            System.Console.WriteLine("*****************************");
            printnums();
            System.Console.WriteLine("*****************************");
            printodds();
            System.Console.WriteLine("*****************************");
            printsums();
            System.Console.WriteLine("*****************************");
            findMax(arr);
            System.Console.WriteLine("*****************************");
            findAvg(arr);
            System.Console.WriteLine("*****************************");
            makeArray();
            System.Console.WriteLine("*****************************");
            greaterThanY(arr, 8);
            System.Console.WriteLine("*****************************");
            square(arr);
            System.Console.WriteLine("*****************************");
            nonegs(arr);
            System.Console.WriteLine("*****************************");
            left(arr);
            System.Console.WriteLine("*****************************");
            object[] objectarr = {-2, -4, 5, 6, -7};
            System.Console.WriteLine("*****************************");
            intToString(objectarr);
            System.Console.WriteLine("*****************************");



        }
        public static void array(int[] arr)
        {
            for (int i = 0; i<arr.Length; i++)
            {
                System.Console.WriteLine(arr[i]);
            }
        }
        public static void printnums(){
            for(int i =0; i<=255; i++)
            {
                System.Console.WriteLine(i);
            }
        }
            
        public static void printodds(){
            for (int i =0; i<=255; i++)
            {
                if(i%2==1)
                {
                    System.Console.WriteLine(i);
                }
            }
        }
           
        public static void printsums(){
            int sum = 0;
            for (int i = 0 ; i<= 255; i++)
            {
                System.Console.WriteLine("New Number" + i);
                System.Console.WriteLine("sum {0}", sum += i);
            }
        }
        public static void findMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i<arr.Length; i++)
            {
                if(arr[i]>max)
                {
                    max = arr[i];
                }
            }
            System.Console.WriteLine(max);
        }
        public static void findAvg(int[] arr)
        {
            double sum =0;
            for(int i = 0; i<arr.Length; i++)
            {
                sum += arr[i];
            }
            double avg;
            avg = sum/arr.Length;
            System.Console.WriteLine(avg);
        }
        public static int[] makeArray()
        {
            List<int> temp = new List<int>();
            for (int i = 0; i <=255; i++)
            {
                if(i%2==1)
                {
                    temp.Add(i);
                }
            }
            return temp.ToArray();
        }
        public static void greaterThanY(int[] arr, int val)
        {
            int counter = 0;
            for (int i = 0; i<arr.Length; i++)
            {
                if (val > arr[i])
                {
                    counter ++;
                }
            }
            System.Console.WriteLine(counter);
        }

        public static void square(int[] arr)
        {
            int sq;
            for (int i=0; i<arr.Length; i++)
            {
                sq = arr[i]*arr[i];
                System.Console.WriteLine(sq);
            }
        }

        public static void nonegs(int[] arr)
        {
            for (int i =0; i<arr.Length; i++)
            {
                if(arr[i]<0)
                {
                    arr[i] = 0;
                }
                System.Console.WriteLine(arr[i]);
            }
        }

        public static void left(int[] arr)
        {
            for (int i = 0; i<arr.Length-1; i++)
            {
                arr[i] = arr[i+1];

            }
            arr[arr.Length-1] = 0; 
            for (int j=0; j<arr.Length; j++)
            {
                System.Console.WriteLine(arr[j]);
            }
        }
        public static void intToString(object[] objectarr)
        {
            for(int i = 0; i<objectarr.Length; i++)
            {
                if ((int)objectarr[i]<0)
                {
                    objectarr[i] = "Dojo";
                }
                System.Console.WriteLine(objectarr[i]);
            }
        }
    }
}
