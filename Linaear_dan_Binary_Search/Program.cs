using System;

namespace Linaear_dan_Binary_Search
{
    class Program
    {
        //array to be searched
        int[] arr = new int[20];

        //member of element in the array
        int n;

        //get the number of element to store in the array
        int i;

        public void input()
        {
            while (true)
            {
                Console.Write("Enter of Numbers of Element in the Array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.Write("\n Array should have minimun 1 and maximum 20 element. \n");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
