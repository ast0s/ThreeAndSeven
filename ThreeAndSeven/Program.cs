using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeAndSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            CheckForBoth cfb = CheckForThree;
            cfb += CheckForSeven;

            for (int i = 0; i < array.Length; i++)
                cfb(array[i], i);
        }
        public delegate void CheckForBoth(int number, int index);
        static public void CheckForThree(int number, int index)
        {
            if (number % 3 == 0)
                Console.WriteLine(index + ". -- " + number);
        }
        static public void CheckForSeven(int number, int index )
        {
            if (number % 7 == 0)
                Console.WriteLine(index + ". -- " + number);
        }
    }
}
