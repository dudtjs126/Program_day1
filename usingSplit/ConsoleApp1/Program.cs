namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //변수와 자료형
            {
                int num = 10;
                float f = 3.14f;
                char c = 'A';
                string str = "Hello, World!";

                int num1 = 0x10;
                int num2 = 0b1010;
                long num3 = 100000000000000L;
            }



            // Console.ReadLine 기능 이용하기
            {
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Hello, {0}!", name);
            }



            // 배열, Split 기능 이용하기
            {
                Console.Write("Enter two numbers: ");
                string input = Console.ReadLine();

                string[] numbers = input.Split(' ');
                int num1 = int.Parse(numbers[0]);
                int num2 = int.Parse(numbers[1]);

                int sum = num1 + num2;

                Console.WriteLine("The sum of {0} and {1} is {2}.", num1, num2, sum);
            }

        }
    }
}
