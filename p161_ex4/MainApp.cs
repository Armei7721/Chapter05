using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p161_ex4
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("알고싶은 월을 입력해주세요. : ");
            string m = Console.ReadLine();
           
            switch (m)
            {
                case "1": case "2":
                case "12":
                Console.WriteLine($"입력하신 {m}월은 겨울 입니다. ");
                    break;
                case "3": 
                case "4": 
                case "5" :
                        Console.WriteLine($"입력하신 {m}월은 봄 입니다. ");
                    break;
                case "6": 
                case "7": 
                case "8":
                        Console.WriteLine($"입력하신 {m}월은 여름 입니다. ");
                    break;
                case "9":
                case "10":
                case "11":
                    Console.WriteLine($"입력하신 {m}월은 가을 입니다. ");
                    break;
                default:
                    Console.WriteLine("정상적인 입력값이 아닙니다. 확인 후 다시 실해해 주세요.");
                    return;



            }

        }

    }

}
