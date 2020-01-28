using System;

namespace _1._28._20
{
    class Nullable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int? num = null;

            Nullable<Guid> test = new Guid();
            Console.WriteLine(test.Value);

            Console.WriteLine(num.GetValueOrDefault(0));

            if (num.HasValue)
            {
                Console.WriteLine($"int num = {num.Value}");
                int num2 = num.Value;
            }
            else Console.WriteLine("int num = null");

            int num3 = num.HasValue ? num.Value : 0;


        }
    }
}
