using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les15ON
{
    internal class UserUtils
    {
        public static int GenerateRandomNumber(int minRandomNumber, int maxRandomNumber)
        {
            Random random = new Random();

            return random.Next(minRandomNumber, maxRandomNumber);
        }

        public static int GetPositiveNumber()
        {
            string line;
            bool isConversionSucceeded = true;
            bool isCorrectNumber;
            int number = 0;

            while (isConversionSucceeded)
            {
                line = Console.ReadLine();
                isCorrectNumber = int.TryParse(line, out number);

                if (isCorrectNumber)
                {
                    if (number < 1)
                    {
                        Console.Write("Неверный ввод. Число меньше единици. Повторите ввод - ");
                    }
                    else
                    {
                        isConversionSucceeded = false;
                    }
                }
                else
                {
                    Console.Write("Неверный ввод. Повторите ввод - ");
                }
            }

            return number;
        }
    }
}
