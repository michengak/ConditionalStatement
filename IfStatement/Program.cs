using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {

            // raw use of if satement with the use of && / || percent 

            //Console.WriteLine("Please enter a number");

            //int UserNumber = int.Parse(Console.ReadLine());

            //if (UserNumber == 1)
            //{
            //    Console.WriteLine("Your number is one");

            //}
            //else if (UserNumber == 2)
            //{
            //    Console.WriteLine("Your number is two");

            //}
            //else if (UserNumber == 3)
            //{
            //    Console.WriteLine("Your number is three");

            //}
            //else 
            //{
            //    Console.WriteLine("Your number is not between 1 and 3");

            //}

            //Better use version of if statement


            //Console.WriteLine("Please enter a number");

            //int UserNumber = int.Parse(Console.ReadLine());

            //if (UserNumber == 1)
            //{
            //    Console.WriteLine("Your number is one");

            //}
            //else if (UserNumber == 2)
            //{
            //    Console.WriteLine("Your number is two");

            //}
            //else if (UserNumber == 3)
            //{
            //    Console.WriteLine("Your number is three");

            //}
            //else
            //{
            //    Console.WriteLine("Your number is not between 1 and 3");

            //}



            // rewrite using Switch statement

            Console.WriteLine("Please enter a number");
            int UserNumer = int.Parse(Console.ReadLine());

            switch (UserNumer)
            {
                case 10:
                    Console.WriteLine("Your number is 10");
                    break;

                case 20:
                    Console.WriteLine("Your number is 20");
                    break;

                case 30:
                    Console.WriteLine("Your number is 30");
                    break;
                default:
                    Console.WriteLine("Your number is not 10, 20, 30);
                    break;
            }


        }
    }
}
