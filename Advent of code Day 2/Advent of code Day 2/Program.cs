using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Advent_of_code_Day_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputs = File.ReadAllLines(@"C:\Users\sveni\Desktop\input2.txt").Select(x => (x)).ToList();


            long finalVertical = 0;
            long finalHorizontal = 0;

            long answer = 0;
            

            foreach(var aString in inputs)
            {
                
                
             string[] directions = aString.Split(" ");

                switch(directions[0])
                {
                    case "down":
                        finalVertical = finalVertical + long.Parse(directions[1]);
                        break;

                    case "up":
                        finalVertical = finalVertical - long.Parse(directions[1]);
                        break;

                    case "forward":
                        finalHorizontal = finalHorizontal + long.Parse(directions[1]);
                        break;
                }
            }

            answer = (finalVertical * finalHorizontal);

            Console.WriteLine(answer);

            Console.WriteLine(finalHorizontal);
            Console.WriteLine(finalVertical);

            /*---------------------------------------PART TWO----------------------------------------*/

            long finalVertical2 = 0;
            long finalHorizontal2 = 0;
            long aim = 0;

            long answer2 = 0;


            foreach (var aString2 in inputs)
            {


                string[] directions2 = aString2.Split(" ");

                switch (directions2[0])
                {
                    case "down":
                        aim += long.Parse(directions2[1]);
                        break;

                    case "up":
                        aim -= long.Parse(directions2[1]);
                        break;

                    case "forward":
                        finalHorizontal2 += long.Parse(directions2[1]);
                        finalVertical2 += aim * long.Parse(directions2[1]);
                        break;
                }
            }

            answer2 = (finalVertical2 * finalHorizontal2);

            Console.WriteLine(answer2);
        }
    }
}
