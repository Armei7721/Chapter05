using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class MainApp
    {
        static void Main(string[] args)
        {/*
            int i = 10;
            while(i >0)
            {
                Console.WriteLine($"i : {i--}");
            }
            */
            while(true)
            {
                Console.Write("계속할까요?(예/아니요) : ");
                string answer = Console.ReadLine();

                if (answer == "아니요")
                    System.Environment.Exit(0);
                    //Process.GetCurrentProcess().Kill();
            }
        }
    }
}
