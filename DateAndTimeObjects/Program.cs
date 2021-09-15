using System;

namespace DateAndTimeObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime current = DateTime.Now;
            Console.WriteLine(current.ToString("dd. MMMM"));
            Console.WriteLine(current.Year);
        }
    }
}
