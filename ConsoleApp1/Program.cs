namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("산술 연산자");
            int num1 = 20, num2 = 10;

            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine(num1 % num2);

            Console.WriteLine(); //빈줄 출력



            Console.WriteLine("관계 연산자");
            Console.WriteLine(num1 == num2);
            Console.WriteLine(num1 != num2);
            Console.WriteLine(num1 < num2);
            Console.WriteLine(num1 > num2);
            Console.WriteLine(num1 <= num2);
            Console.WriteLine(num1 >= num2);

            Console.WriteLine(); //빈줄 출력



            Console.WriteLine("논리 연산자");
            int num3 = 15;

            Console.WriteLine(0 <= num3 && num3 <= 20);   //0과 20 사이에 포함되면
            Console.WriteLine(0 > num3 || num3 > 20);     //0과 20 사이에 포함되지 않으면

            Console.WriteLine( !(0 <= num3 && num3 <= 20) ); // OR와 동일한 코드
        }
    }
}
