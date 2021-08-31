using System;
using System.Linq;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var text = "aaabbcc";
            
            var result = text.Rotate(2);
            Console.WriteLine(result);
        }
    }
    public static class StringExtension
    {
        public static string Rotate(this String val, int n)
        {
           // string pastval;
           int ln = val.Length;
           int last = n % ln;
           int f = 1;
           string final = null;
           
           while (f<=last)
           {
               final += val[ln - f];
               f++;
           }

           string final2=null;
           for (int i = final.Length - 1; i >= 0; i--)
           {
               final2 += final[i];
           }
          // Console.WriteLine(final);  
           for (int i = 0; i <= ln - f; i++)
               final2 += val[i];
           
          
           
            return final2;
        }
    }
   
}
