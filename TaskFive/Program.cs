using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFive
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 14; i++)
            {
                for (int j = 1; j <= 4; j++) Console.Write("*");
                if (i == 1 || i == 14) for (int k = 1; k <= 15; k++) Console.Write("*");
               if (i == 2 || i == 13) for (int k = 1; k <= 15; k++) Console.Write("*");
                if (i == 3 || i == 12)
                 {
                     for (int k = 1; k <= 11; k++) Console.Write(" ");
                     for (int l = 7; l <= 10; l++) Console.Write("*");
                 }
                 if (i == 4 || i == 11)
                 {
                     for (int k = 1; k <= 11; k++) Console.Write(" ");
                     for (int l = 8; l <= 11; l++) Console.Write("*");
                 }
                 if (i == 5 || i == 10)
                 {
                     for (int k = 1; k <= 11; k++) Console.Write(" ");
                     for (int l = 9; l <= 12; l++) Console.Write("*");
                 }
                if (i == 8 )
                {
                    for (int k = 1; k <= 8; k++) Console.Write(" ");
                    for (int l = 9; l <= 18; l++) Console.Write("*");
                }
                if (i == 9)
                {
                    for (int k = 1; k <= 8; k++) Console.Write(" ");
                    for (int l = 9; l <= 18; l++) Console.Write("*");
                }



                Console.WriteLine();
               

            }

            Console.WriteLine();
            for (int i = 1; i <= 14; i++)
            {

                for (int j = 1; j <= 4; j++) Console.Write("*");
                if (i == 1 || i == 14) for (int k = 1; k <= 15; k++) Console.Write("*");
                if (i == 2 || i == 13) for (int k = 1; k <= 15; k++) Console.Write("*");
                if (i==3 || i==4 || i==5 || i==6 || i==7 || i==8 || i==9 || i==10 || i==11 || i==12) {
                    for (int k = 1; k <= 11; k++) Console.Write(" ");
                    for (int l = 7; l <= 10; l++) Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 1; i <= 14; i++)
            {

                for (int j = 1; j <= 4; j++) Console.Write("*");
                if (i == 1 || i == 14) for (int k = 1; k <= 15; k++) Console.Write("*");
                if (i == 2 || i == 13) for (int k = 1; k <= 15; k++) Console.Write("*");
                if (i == 3 || i == 4 || i == 5 || i == 6 || i == 7 || i == 8 || i == 9 || i == 10 || i == 11 || i == 12)
                {
                    for (int k = 1; k <= 11; k++) Console.Write(" ");
                    for (int l = 7; l <= 10; l++) Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 1; i <= 14; i++)
            {
                for (int j = 1; j <= 4; j++) Console.Write("*");
                if (i == 1 || i == 14) for (int k = 1; k <= 7; k++) Console.Write("*");
                if (i == 2 || i == 13) for (int k = 1; k <= 9; k++) Console.Write("*");
                if (i == 3 || i == 12)
                {
                    for (int k = 1; k <= 6; k++) Console.Write(" ");
                    for (int l = 7; l <= 10; l++) Console.Write("*");
                }
                if (i == 4 || i == 11)
                {
                    for (int k = 1; k <= 7; k++) Console.Write(" ");
                    for (int l = 8; l <= 11; l++) Console.Write("*");
                }
                if (i == 5 || i == 10)
                {
                    for (int k = 1; k <= 8; k++) Console.Write(" ");
                    for (int l = 9; l <= 12; l++) Console.Write("*");
                }
                if (i == 6 || i == 9)
                {
                    for (int k = 1; k <= 9; k++) Console.Write(" ");
                    for (int l = 10; l <= 13; l++) Console.Write("*");
                }
                if (i == 7 || i == 8)
                {
                    for (int k = 1; k <= 10; k++) Console.Write(" ");
                    for (int l = 11; l <= 14; l++) Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
