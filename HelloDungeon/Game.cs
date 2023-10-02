using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {

        //Given a number n, for each integer i in the range from 1 to n inclusive, print one value per line as follows:
        //If i is a multiple of both 3 and 5, print FizzBuzz.
        //If i is a multiple of 3 (but not 5), print Fizz.
        //If i is a multiple of 5 (but not 3), print Buzz.
        //If i is not a multiple of 3 or 5, print the value of i.
        //The function must print the appropriate response for each value i in the set { 1, 2, ... n} in ascending order, each on a separate line.

        void FizzBuzz(int a)
        {
            for (int i = 0; i <= a; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        public void Run()
        {
            FizzBuzz(2000000);
        }
    }
}
