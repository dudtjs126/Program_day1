namespace Homwork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 숙제 1번
            {
                Console.Write("이름을 입력하세요: ");
                string nameInput = Console.ReadLine();

                Console.Write("나이를 입력하세요: ");
                string ageInput = Console.ReadLine();

                int age = int.Parse(ageInput);

                Console.WriteLine("안녕하세요, {0}! 당신은 {1}세 이군요.", nameInput, age);
            }



            // 숙제 2번
            {
                Console.Write("첫 번째 수를 입력하세요: ");
                string numberInput_1 = Console.ReadLine();
                int number_1 = int.Parse(numberInput_1);


                Console.Write("두 번째 수를 입력하세요: ");
                string numberInput_2 = Console.ReadLine();
                int number_2 = int.Parse(numberInput_2);


                int sum = number_1 + number_2;
                int minus = number_1 - number_2;
                int multiply = number_1 * number_2;
                float divide = (float)number_1 / (float)number_2;


                Console.WriteLine("더하기: " + sum);
                Console.WriteLine("빼기: " + minus);
                Console.WriteLine("곱하기: " + multiply);
                Console.WriteLine("나누기: " + divide);
            }



            // 숙제 3번
            {
                Console.Write("섭씨 온도를 입력하세요: ");
                string Input_C = Console.ReadLine();
                int temperature_C = int.Parse(Input_C);

                int temperature_F = (temperature_C * 9 / 5) + 32;

                Console.Write("변환된 화씨 온도: {0}", temperature_F);
            }



            // 숙제 4번
            {
                Console.Write("키(m) 를 입력해 주세요: ");
                string Input_m = Console.ReadLine();
                int height = int.Parse(Input_m);


                Console.Write("체중(kg) 을 입력해 주세요: ");
                string Input_kg = Console.ReadLine();
                int weight = int.Parse(Input_kg);

                float BMI = (float)weight / ((float)height * (float)height);

                Console.WriteLine("당신의 BMI 는 {0} 입니다.", BMI);
            }
        }
    }
}
