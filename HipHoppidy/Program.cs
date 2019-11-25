using System;

namespace HipHoppidy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hoppidy();
            //HipHoppidy();
            string input = Console.ReadLine();
            int f = Convert.ToInt32(input);

            Console.WriteLine("The factorial is {0}", fact(f));
        }

        private static void Hoppidy()
        {
            Console.WriteLine("Hoppidy");
        }

        private static void HipHoppidy()
        {
            for(int x = 0; x < 10; ++x)
            {
                Hoppidy();
            }
            HipHoppidy(); //calls on itself causing infinite recursion, NOT GOOD
        }

        private static int fact(int f)
        {
            if(f <= 0)
            {
                return 1;
            }
            else
            {
                return f * fact(f - 1);
            }
        }
    }
}
