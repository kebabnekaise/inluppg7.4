using System;

namespace inluppg7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "hej", "svejs", "ja", "nej", "geggamoja" };
            if (FinnsTecknetIAllaStrangar(strings, 'g'))
            {
                Console.WriteLine($"g finns i alla orden i listan");
            }
            else
            {
                Console.WriteLine("g finns inte i alla orden i listan");
            }
        }

        static bool FinnsTecknetIAllaStrangar(string[] ord, char character)
        {
            for (int i = 0; i < ord.Length; i++)
            {
                if (!ord[i].Contains(character))
                {
                    return false;
                }
            }
            return true;
        }
    }
}