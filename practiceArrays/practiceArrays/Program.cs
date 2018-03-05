using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main()
        {
            MagicNumber();
        }
        static void MagicNumber()
        {
            int RandomNumber;
            int RandomNumber2;

            List<int> Number = new List<int>();
            List<int> Number2 = new List<int>();

            for (int i = 100000; i <= 999999; i++)
            {
                Number.Clear();
                Number2.Clear();

                RandomNumber = i;
                while (RandomNumber > 0)
                {
                    Number.Add(RandomNumber % 10);
                    RandomNumber = RandomNumber / 10;
                }
                Number.Sort();
                if (Number.Count != Number.Distinct().Count())
                {
                    continue;
                }
                else
                {
                    for (int n = 2; n <= 6; n++)
                    {
                        Number2.Clear();
                        RandomNumber2 = i * n;
                        while (RandomNumber2 > 0)
                        {
                            Number2.Add(RandomNumber2 % 10);
                            RandomNumber2 = RandomNumber2 / 10;
                        }
                        Number2.Sort();
                        if (Number.SequenceEqual(Number2) == true)
                        {
                            if (n == 6)
                            {
                                Console.WriteLine("Magiskas skaicius = " + i);
                            }
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
