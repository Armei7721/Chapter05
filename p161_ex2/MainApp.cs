using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p161_ex2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정수 2개와 연산기호를 입력해주세요!");
            Console.Write("첫 번째 정수를 입력해주세요. : ");
            string a =Console.ReadLine();
            Console.Write("두 번째 정수를 입력해주세요. : ");
            string b = Console.ReadLine();
            Console.Write("연산기호를 입력해주세요. ex)+,-,*,/,% : ");
            string c = Console.ReadLine();

            int nb1 = int.Parse(a);
            int nb2 = int.Parse(b);
            int d = 0;
            switch (c)
            {
                case "+":
                    d = nb1 + nb2;
                    break;
                case "-":
                    d = nb1 - nb2;
                    break;
                case "*":
                    d = nb1 * nb2;
                    break;
                case "/":
                    d = nb1 / nb2; 
                    break;
                case "%":
                    d = nb1 % nb2;
                    break;
                default :
                    Console.WriteLine("입력하신 연산기호는 잘못되었습니다. 확인 후 다시 실행해 주세요.");
                    return;
            }
            Console.WriteLine($"입력하신 {nb1}%{nb2}의 결과값은 {d} 입니다.");


        }
    }
}
