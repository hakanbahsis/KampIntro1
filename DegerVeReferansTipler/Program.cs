using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int refValue = 5;
            int outValue;

            ChangeMethod(out outValue, ref refValue);
            Console.WriteLine("Methottan sonra refValue : "+refValue);
            Console.WriteLine("Methottan sonra outValue : "+outValue);
            Console.ReadKey();
        }

        static void ChangeMethod(out int i,ref int j)
        {
            i = 8;
            j = j + 4;
        }
    }
}
