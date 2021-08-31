using System;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Show example use case of ItemBox
            ItemBox<Program> arr = new ItemBox<Program>();
            arr.Add(2);
            arr.Remove(3);
            arr.Get(4);

        }
    }

}
