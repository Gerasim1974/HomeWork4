namespace appHomeWork4
{
    using System.Collections.Generic;
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Ener an integer");
                int RancArr = int.Parse(Console.ReadLine());
                Console.WriteLine($"Rank to array = {RancArr}");
                int[] arrInt = new int[RancArr];
                for (int i = 0; i < arrInt.Length; i++)
                {
                    Console.WriteLine($"Enter an integer as {i+1} item array:");
                    arrInt[i] = int.Parse(Console.ReadLine()); 
                }
                int nMin = arrInt[0];
                int nSum = 0;
                for(int i = 0; i < arrInt.Length; i++)
                {
                    if (arrInt[i] < nMin)
                    {
                        nMin = arrInt[i];
                    }
                    if (i % 2 == 0)
                    {
                        nSum += arrInt[i];
                    }
                }
                Console.WriteLine($"Sum of odd array elements = {nSum}");
                Console.WriteLine($"Minimum array element = {nMin}");

                Stack<int> stkStack = new Stack<int>(arrInt);
                Console.WriteLine("Array in reverse order:");
                string s = "";
                foreach(int i in stkStack)
                {
                    s = s + "  " + i;
                }
                Console.WriteLine(s.TrimStart());
                Console.WriteLine("To exit the application, enter <ESC>");
                Console.WriteLine("To continue the application, press any key");
            } while ((int)((Console.ReadKey().Key)) != 27);
        }
    }
}