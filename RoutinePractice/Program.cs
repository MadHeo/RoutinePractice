using System;

namespace PracticeNote
{
    class Program
    {
        static void Main(string[] args)
        {

            // if, else, else if 문
            //Console.WriteLine("숫자를 입력하세요 : ");

            //string input = Console.ReadLine();
            //int number = Int32.Parse(input);

            //if (number > 0)
            //    Console.WriteLine("음수");
            //else if (number < 0)
            //    Console.WriteLine("양수");
            //else
            //    Console.WriteLine("0");

            //if (number % 2 == 0)
            //    Console.WriteLine("짝수");
            //else
            //    Console.WriteLine("홀수");


            //switch 문
            //object obj = null;

            //string s = Console.ReadLine();
            //if (int.TryParse(s, out int out_i))
            //    obj = out_i;
            //else if (float.TryParse(s, out float out_f))
            //    obj = out_f;
            //else
            //    obj = s;

            //switch (obj)
            //{
            //    case int i:
            //        Console.WriteLine($"{i}는 int 형식입니다.");
            //        break;
            //    case float f when f >= 0:
            //        Console.WriteLine($"{f})는 양의 float 형식입니다.");
            //        break;
            //    case float f:
            //        Console.WriteLine($"{f})는 음의 float 형식입니다.");
            //        break;
            //    default:
            //        Console.WriteLine($"{obj}는 모르는 형식입니다.");
            //        break;
            //}

            //while 문 
            //int a = 10;

            //while (a > 0)
            //{
            //    Console.WriteLine($"a : {--a}");

            //}

            //for 문
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }

            //    Console.WriteLine();
            //}


            //for 문과 while 문을 사용해서 무한 반복 만들기
            //int i = 0;

            //for(; ; )
            //{
            //    Console.WriteLine(i++);
            //}

            //while (true)
            //{
            //    Console.WriteLine(i++);
            //}


            //* 다섯개만들고 점점 줄어드는 함수
            //for (int a = 0; a < 5 ; a++)
            //{
            //    for (int j = a; j < 5; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}

            //* 한개 이후에 점점 늘어나는 함수
            //for (int a = 0; a < 5; a++)
            //{
            //    for (int b = 0; b <= a; b++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //while 문으로  별 쌓기
            //int i = 0;
            //int a = 0;

            //while (i < 5)
            //{
            //    a = 0;
            //    while(a <= i)
            //    {
            //        Console.Write("*");
            //        a++;
            //    }
            //    Console.WriteLine();
            //    i++;
            //}

            Console.WriteLine("반복 횟수를 입력하세요 :");
            string input = Console.ReadLine();
            int number = Int32.Parse(input);



            if (number <= 0)
            {
                Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");

            }
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    for (int j = 1; j <= i; j++)
                        Console.Write("*");
                    Console.WriteLine();
                }

            }

        }
    }
}