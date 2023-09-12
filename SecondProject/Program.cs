namespace SecondProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä x");

            var x = Console.ReadLine();

            Console.WriteLine("Syötä y");

            var y = Console.ReadLine();

            //parses string to int and adds them together
            var result = int.Parse(x) + int.Parse(y);

            
            Console.WriteLine("Combine result + is " + result);
            Console.WriteLine(string.Format("String format result is {0}", result));
            Console.WriteLine($"Interpolation result $ is {result}");


            Console.WriteLine("Combine example: Result " + x + " +  " + y + " = " + result);
            Console.WriteLine(string.Format("string.Format example: Result {0} + {1} = {2}", x, y, result));
            Console.WriteLine($"Interpolation example: Result {x} + {y} = {result}");
        }
    }
}