using System;

namespace Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = BinaryToDecimal("101111000100010010010101101101");
            Console.WriteLine(result);
        }

        public static int BinaryToDecimal(string binaryNumber)
        {
            var sum = 0;
            var pro = 1;
            for (int i = binaryNumber.Length-1; i >=0; i--)
            {
                if (i != binaryNumber.Length - 1)
                    pro *= 2;
                if (binaryNumber[i] == '1')
                    sum += pro;
                

            }

            return sum;
            throw new NotImplementedException();
        }
    }
}
