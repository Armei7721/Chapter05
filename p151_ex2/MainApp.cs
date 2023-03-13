using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p151_ex2
{
    class MainApp
    {
        static void Main(string[] args)
        {

            Console.Write("점수를 입력하세요. :");
            string a= Console.ReadLine();
            int score = int.Parse(a);
            
            if(score>=90)
            {
                Console.WriteLine($"입력하신 점수는 {score}는(은) A 학점 입니다.");
            }
            else if(score>=80)
            {
                Console.WriteLine($"입력하신 점수는 {score}는(은) B 학점 입니다.");
            }
            else if(score>=70)
            {
                Console.WriteLine($"입력하신 점수는 {score}는(은) C 학점 입니다.");
            }
            else
            {
                Console.WriteLine($"입력하신 점수는 {score}는(은) F 학점 입니다.");
            }
        }
    }
}
