using System;

namespace task3
{
    internal static class Program
    {
        private static void Main()
        {
            var citizens = new UserCollection() {[0] = new Student(), [1] = new Worker()};
            citizens.Add(new Pensioner());
            Console.WriteLine(citizens[0]);
        }
    }
}