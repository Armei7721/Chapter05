using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class MainApp
    {
        static void Main(string[] args)
        {
            /* ex1
             for (int i = 0; i < 5; i++)
             {
                 for (int j = 0; j <= i; j++)
                 {
                     Console.Write("*");
                 }
                 Console.WriteLine("");
             }*/
            /* ex2
             for(int i =5; i >0; i--)
             {
                 for (int j = 0; j<i; j++)

                 {
                     Console.Write("*");
                 }
                 Console.WriteLine("");
             }
            */
            /*
            int i = 0;
            while(i<5)
            {
                int j = 0;
                while(j<=i)
                {
                    Console.Write("*");
                    j++;    
                }
                Console.WriteLine();
                i++;
            }
            do {
                int j = 0;
                do {
                    Console.Write("*");
                    j++;
                } while (j <= i);
                Console.WriteLine();
                i++;
            } while (i<5);
            */
            /*int i= 0;
            while (i<5 )
            {
                int j = 5;
                while (j > i)
                {
                    Console.Write("*");
                    j--;
                }
                Console.WriteLine();
                i++;
            }
            do
            {
                int j = 5;
                do
                {
                    Console.Write("*");
                    j--;
                } while (j > i);
                Console.WriteLine();
                i++;
            } while (i < 5);
            *//*
            Console.Write("반복 횟수를 입력하세요 : ");
            string banbock = Console.ReadLine();
            int a= int.Parse(banbock);
            if(a>0)
            {
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j <=i ; j++)
                    {
                        Console.Write("*");
                        
                    }
                   
                    Console.WriteLine("");
                    
                }
            }
            else
            {
                Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");
            }*/
        }
    }
}
