using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = new string[] { "liza", "Marianna", "Oleg", "Vlad", "Yra", "Anna", "Natasha" };

            Console.WriteLine("The Length Of Array is" + myArray.Length);
            Console.WriteLine();
                                              //left to right
            Console.WriteLine("----------for loop up to down---------");


            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Index =" + i);
                Console.WriteLine("Value = " + myArray[i]);
                Console.WriteLine();

            }
            
            Console.WriteLine("--------------Foreach loop----------------");
            foreach (string s in myArray)
            {
                Console.WriteLine("Value = " + s);
            }

                                             // right to left
            Console.WriteLine("--------------For loop down to up----------------");

            for (int i = myArray.Length - 1; i > -1; i--)
            {
                Console.WriteLine("Index =" + i);
                Console.WriteLine("Value = " + myArray[i]);
                Console.WriteLine();

            }


            Console.WriteLine("--------------How to sort array Alphabetical Order----------------");
            Array.Sort(myArray);
            foreach (string s in myArray)
            {
                Console.WriteLine("Value = " + s);
            }

            Console.WriteLine("--------------How to Reverse array Alphabetical Order----------------");
            Array.Reverse(myArray);
            foreach (string s in myArray)
            {
                Console.WriteLine("Value = " + s);
            }

            Console.WriteLine("--------------how to Boble Sort Array----------------");

            int[] arr = new int[] { 12, 8, 39, 45, 3, 1, 7, 29 };

            bool flag = true;

            while (flag) //while (flag == frue )
            {
                flag = false;
                int current = 0;
                int next = 0;

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    current = arr[i];
                    next = arr[i + 1];
                    if (current > next)

                    {
                        arr[i] = next;
                        arr[i + 1] = current;
                        flag = true;
                    }

                }
            }
            ///////////////////////////////////////////////////////////////////////
                foreach (int i in arr) // too see all the NUmbers
                {
                    Console.WriteLine(i);
                }
         //    reading david from the end "divad"
            string text = "david";

            char [] array = text.ToCharArray();

            text = string.Empty;                    // i-- to start from down to up
            for (int i = array.Length - 1; i > -1; i--) //we know Length ( -1 is because we start counting from 0,1,2,3..)
            {
                text += array[i];
            }
            Console.WriteLine(text);

            ///////////////////////////////////// For each Loop
            int[] numbers = new int[50];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("BuzzFuzz");                 
                }
               else if (i % 5 == 0)
                {
                    Console.WriteLine("Fuzz");                  
                }
               else if (i % 3 == 0)
                {
                    Console.WriteLine("Buzz");              
                }
                else
                {
                    Console.WriteLine(i);
                }
                Console.ReadLine();
               
            }
        }
    }
}
