namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;

            var div = a / b;
            var mod = a % b;

            Console.WriteLine($"{a}/{b} is {div} remainder {mod}");

            Console.WriteLine("What is the radius of your circle?");

            var radius = double.Parse(Console.ReadLine());
            var areaOfCircle = YourArea(radius);

            Console.WriteLine($"The area of a circle with a radius of {radius} is {areaOfCircle}.");


        }

        public static double YourArea(double radius)
        {

            return Math.PI * (radius * radius);

        }



    }
     

}
