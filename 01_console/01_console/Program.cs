using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< Updated upstream
            Console.WriteLine("Hello World!");
            Console.ReadKey();
=======
            Console.WriteLine("Hello World!"); // "Hello World!"를 출력하는 코드
            Console.WriteLine("김건");
            string str = Console.ReadLine();   // 키보드 입력을 받아서 str이라는 string 변수에 저장한다.

            // 변수 : 변하는 숫자. 컴퓨터에서 사용할 데이터를 저장할 수 있는 곳
            // 변수의 종류 : 데이터 타입(Data type)
            // int : 인티저. 정수. 소수점 없는 숫자. 32bit
            // float : 플로트. 실수. 소수점 있는 숫자. 32bit
            // string : 스트링. 문자열. 글자들을 저장.
            // bool : 불 또는 불리언. true/false를 저장.

            int a = 10; // a라는 인티저 변수에 10이라는 데이터를 넣는다.
            long b = 50000000000; // C#에서 빨간줄이 떴다는 건 무조건 틀렸다는 뜻, 50억은 int에 넣을 수 없다. => int는 32비트이고 32비트로 표현 가능한 숫자의 갯수는 2^32개이기 떄문이다.
            int c = -100; // -21억에서 +21까지가 인티저로 나타낼 수 있는 숫자
            int d = 2000000000;
            int e = 2000000000;
            int f = d + e;
            Console.WriteLine(f);

            //float의 단점 : 태생적으로 오차가 있을 수 밖에 없다.
            float aa = 0.000123f;
            float ab = 0.999999999f; // 계산결과 1이 들있을 수도 있음.
            float ac = 0.000000000001f;
            float ad = ab + ac; // 결과가 1이 아닐 수도 있다.
            Console.WriteLine(ad);

            string str1 = "Hello";
            string str2 = "안녕!";
            string str3 = $"Hello {a}"; // "Hello 10"
            Console.WriteLine(str3);
            string str4 = str1 + str2; // "Hello안녕!"
            Console.WriteLine(str4);

            bool b1 = true;
            bool b2 = false;

            //int level = 1;
            //int hp = 10;
            //float exp = 0.9f;
            //string name = "너굴맨";
            //string str5 = $"{name}의 레벨은 {level}이고 HP는 {hp}이고 exp는 {exp}다";
            //// 너굴맨의 레벨은 1이고 HP는 10이고 exp는 0.9다.
            //Console.WriteLine(str3);
            //Console.WriteLine($"이름 : {name}\n레벨 : {level}\nHP : {hp}\nexp : {exp*100:F2}%");

            //Console.Write("이름을 입력하세요 : ");
            //name = Console.ReadLine();
            //Console.Write($"{name}의 레벨을 입력하세요 : ");
            //string temp = Console.ReadLine();
            ////level = int.Parse(temp);    // string을 int로 변경해주는 코드(숫자로 바꿀 수 있을 때만 가능).간단하지만 위험함
            //int.TryParse(temp, out level); // string을 int로 변경해주는 코드(숫자로 바꿀 수 없으면 0으로 만든다.)
            ////level = Convert.ToInt32(temp); //string을 int로 변경해주는 코드(숫자로 바꿀 수 있을 때만 가능). 더 세세하게 변경

            Console.ReadKey();

            // 너굴맨의 레벨은 1이고 HP는 10이고 exp는 90%다.

            string result;
            string name = "너굴맨";
            int level = 3;
            int hp = 2;
            float exp = 0.1f;

            //Console.Write("이름을 입력하세요");
            //name = Console.ReadLine();

            //string temp;
            //Console.Write("레벨을 입력하세요 : ");
            //temp = Console.ReadLine();
            //int.TryParse(temp, out level);

            //Console.Write("HP를 입력하세요 : ");
            //temp = Console.ReadLine();
            //int.TryParse(temp, out hp);

            //Console.Write("경험치를 입력하세요 : ");
            //temp = Console.ReadLine();
            //float.TryParse(temp, out exp);

            //result = $"{name}의 레벨은 {level}이고 HP는 {hp}이고 exp는 {exp * 100:f3}%다.\n";
            //Console.Write(result);

            // 변수 끝--------------------------

            // 제어문(control statement)

            // 실행되는 코드 라인을 변경할 수 있는 코드
            hp = 5;
            if( hp < 3 )    //  hp가 2이기 때문에 참이다. 따라서 중괄호 사이에 코드가 실행된다.
            {
                Console.WriteLine("HP가 부족합니다");
            }
            else
            {
                Console.WriteLine("HP가 충분합니다."); // 거짓일때 나온다.

            }
            Console.ReadKey();                 // 키 입력 대기하는 코드
>>>>>>> Stashed changes
        }
    }
}
