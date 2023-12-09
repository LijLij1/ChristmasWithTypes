using System;

namespace ChristmasWithTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmas = new Christmas();

            var XmasDay = Christmas.Day.Monday;

            //TODO set Santa's name to Kris Kringle
            xmas.Santa = null;

            xmas.Santa = "Kris Kingle";

            //TODO Insert 3 presents you would like for xmas.  They must be strings
            xmas.Presents = new string[3]{"shoes", "clothes", "toys" };


            //TODO Set the TreeHeight to 10
            xmas.TreeHeight = null;

            xmas.TreeHeight = 10;

            Console.WriteLine($"This year christmas falls on {XmasDay} \n");
            Console.WriteLine($"Our tree will be {xmas.TreeHeight} feet high \n");
            Console.WriteLine($"Here are the presents we would like: {xmas.Presents}");

            foreach (var present in xmas.Presents)
            {
                Console.WriteLine($"    {present}");
            }

            Console.WriteLine($"\n We like to call Santa, {xmas.Santa}");
        }
    }
}
