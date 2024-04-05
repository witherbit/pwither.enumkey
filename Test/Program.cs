using pwither.enumkey;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
                                //     return "one"           return "two"             return "Three"            return null
            Console.WriteLine($"{TestEnum.One.GetKey()} {TestEnum.Two.GetKey()} {TestEnum.Three.GetKey()} {TestEnum.Four.GetKey()}");
            Console.ReadLine();
        }
    }
}
