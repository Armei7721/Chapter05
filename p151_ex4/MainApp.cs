using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p151_ex4
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("정수 한 개를 입력하세요 : ");
            string a = Console.ReadLine();
            int score = int.Parse(a);

            if (score %3==0)
            {
                Console.WriteLine($"입력하신 정수 {score}은(는) 3의 배수 입니다.");
            }
            else if (score %3 !=0)
            {
                Console.WriteLine($"입력하신 숫자 {score}은(는) 3의 배수가 아닙니다.");
            }
        }
    }
}
