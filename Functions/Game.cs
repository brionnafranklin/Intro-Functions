using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Game
    {
        int numberOne = 1000;
        int numberTwo = 200;
        public void Start()
        {
            int biggestNumber = ReturnBiggestNumber(numberOne, numberTwo);

            Console.WriteLine("Of " + numberOne + " and " + numberTwo + " the biggestNumber is " + biggestNumber);
            Console.ReadKey();

        }
        int ReturnBiggestNumber(int first, int second)
        {
            if(first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
