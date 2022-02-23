using System;

namespace GenericMaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find the maximum number");
            int output = MaximumNumber.MaximumValueofThree(2, 3, 4);
            Console.WriteLine(output);
        }
    }
}