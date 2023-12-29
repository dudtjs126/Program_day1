namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // WriteLine 사용
            Console.WriteLine("① WriteLIne 사용");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("My Name Is Kero");

            Console.WriteLine(10);
            Console.WriteLine(3.141592);
            Console.WriteLine(3 + 3);


            // Write 사용
            Console.WriteLine("\n\n② Write 사용");
            Console.Write("Hello! ");
            Console.Write("We are Learning ");
            Console.WriteLine("at TeamSparta");


            // 이스케이프 시퀀스 사용
            /* 1. \n 사용 */
            Console.WriteLine("\n\n③ 이스케이프 시퀀스 사용");
            Console.WriteLine("Hello\nWorld");
            
            /* 2. \t 사용 */
            Console.WriteLine("Name\tAge");
            Console.WriteLine("Kero\t30");
            Console.WriteLine("Young\t25");

            /* 3. \" 사용 */
            Console.WriteLine("We learn \"C# Programming\"");

            /* 4. \' 사용 */
            Console.WriteLine("He said, \'Hello\' to me.");

            /* 5. \\ 사용 */
            Console.WriteLine("C:\\myDocuments\\Project\\");

        }
    }
}
