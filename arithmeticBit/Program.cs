namespace arithmeticBit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 문자열 연결
            Console.WriteLine("① 문자열 연결 실습");
            string str1 = "Hello, World!";
            string str2 = new string('h', 5);

            string str3 = str1 + " " + str2;
            Console.WriteLine(str3);



            // 문자열 분할
            Console.WriteLine("\n\n② 문자열 분할 실습");
            string[] str4 = str1.Split(',');
            Console.WriteLine(str4[0]);
            Console.WriteLine(str4[1]);



            // 문자열 검색
            Console.WriteLine("\n\n③ 문자열 검색 실습");
            int index = str1.IndexOf("World");
            Console.WriteLine(index);
            /* 문자에서 World 의 W가 시작되는 번호를 검색한다. */



            // 문자열 대체
            Console.WriteLine("\n\n④ 문자열 대체 실습");
            string newStr = str1.Replace("World", "Universe");
            Console.WriteLine(newStr);
            Console.WriteLine(str1);



            // 문자열 변환
            Console.WriteLine("\n\n⑤ 문자열 변환 실습");
            string str5 = "123";
            int num = int.Parse(str5);
            Console.WriteLine(num);

            num += 10;

            Console.WriteLine(num.ToString());



            // 문자열 비교
            Console.WriteLine("\n\n⑥ 문자열 비교 실습");
            Console.WriteLine(str1 == str2);
            Console.WriteLine(string.Compare(str1, str2));



            // 문자열 포맷팅
            Console.WriteLine("\n\n⑦ 문자열 포맷팅 실습");
            string name = "John";
            int age = 30;
            string message = string.Format("My name is {0} and I'm {1} years old.", name, age);
            Console.WriteLine(message);

            message = $"My name is {name} and I'm {age} years old.";
            Console.WriteLine(message);
        }
    }
}
