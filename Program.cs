namespace Topic_3___Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Joshua F
            // Part 1
            string courseName = "Computer Science";
            int roomNumber = 29;
            double price = 2.99;

            Console.WriteLine("This is room #" + roomNumber);
            Console.WriteLine("The price is " + price);
            Console.WriteLine("I am learning a bit about " + courseName + "!");
            Console.WriteLine();

            // Part 2
            string fullName = "Joshua Figueiredo";
            int gradYear = 2026;
            Console.WriteLine("My name is " + fullName + " and I am expected to graduate in " + gradYear + "!");
            Console.WriteLine();

            // Part 3
            int radius = 5;
            double area = (Math.PI * (radius * radius));
            Console.WriteLine("We are going to find the area of a circle where the radius is " + radius + " and pi is " + Math.PI);
            Console.WriteLine("The area of that circle would be " + Math.Round(area, 1));
            Console.ReadLine();
        }
    }
}
