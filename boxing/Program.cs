using System;
using System.Collections.Generic;
namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> boxxed = new List<object>();
            boxxed.Add(7);
            boxxed.Add(28);
            boxxed.Add(-1);
            boxxed.Add(true);
            boxxed.Add("chair");

            int sum = 0;
            for(int i = 0;  i<boxxed.Count; i++)
            {
                System.Console.WriteLine(boxxed[i]);
                if(boxxed[i] is int)
                {
                    sum += (int)boxxed[i];
                }
            }
            System.Console.WriteLine(sum);

        }
    }
}
