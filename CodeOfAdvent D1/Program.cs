using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CodeOfAdvent_D1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputs = File.ReadAllLines(@"C:\Users\sveni\Desktop\input.txt").Select(x => int.Parse(x)).ToList();


            int theNumber = 0;

            for(int i = 1; i < inputs.Count(); i++)
           {
                if(inputs[i] > inputs[i-1])
                {
                    theNumber++;
                }
            }

            Console.WriteLine(theNumber);


            List<int> numberOfWin = new List<int>();



            for (int i = 2; i < inputs.Count(); i++)
            {
               numberOfWin.Add((inputs[i] + inputs[i - 1] + inputs[i - 2]));

            }

            int numberOfChanges = 0;

            for (int i = 1; i < numberOfWin.Count(); i++)
            {
                if (numberOfWin[i] > numberOfWin[i - 1])
                {
                    numberOfChanges++;
                }
            }

            Console.WriteLine(numberOfChanges);






            //List<int> inputs = File.ReadAllLines(@"C:\Users\sveni\Desktop\input.txt").Select(x => int.Parse(x)).ToList();
            //int count = -1;
            //int current = 0;
            //foreach (var num in inputs)
            //{
            //    if (num > current)
            //    {
            //        current = num;
            //        count++;
            //    }
            //}


            //Console.WriteLine(count);


        }
    }
}
