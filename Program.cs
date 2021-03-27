using System;

namespace MethodExercise
{
    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //var usrName = Console.ReadLine();

            //Console.WriteLine($"Hello, {usrName}. Welcome!");

            //Console.WriteLine("What is your favorite color?");
            //var usrColor = Console.ReadLine();

            //Console.WriteLine($"You chose the color, {usrColor}. What a good choice!");

            //Console.WriteLine("What is your favorite animal?");
            //var usrAnimal = Console.ReadLine();

            //Console.WriteLine($"You chose the animal," +
            //    $" {usrAnimal}. I wonder why it wasn't a tiger?");

            //Console.WriteLine("What is your favorite band?");
            //var usrBand = Console.ReadLine();

            //Console.WriteLine($"You chose the band, {usrBand}. We won't try and guess why. Have you heard of tacos?\n \n");

            //Console.WriteLine($"There once was a person named  {usrName}. \n They enjoyed the color {usrColor} the most. \n Their favorite animal was usually {usrAnimal} \n The reason it's not a tiger is still not known. \n  {usrBand} is also their favorite band. \n They likely need several tacos, also. ");

            Console.WriteLine("Pick a number...");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Pick a second number...");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"We added them for you. The result is: {sum}");

            Console.WriteLine("Pick a number.....");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Pick a second number....");
            int y = int.Parse(Console.ReadLine());

            int product = Product(x , y);
            Console.WriteLine($"We just multiplied them for you. The result is: {product}");
        }
        //public static int Sum(int num1, int num2)
        public static int Sum(params int[] list)
        {

            //int sum = num1 + num2
            //return sum
            int sum = 0;
            for (int i = 0; i < list.Length; i++) 
            {
             sum = sum + list[i];
            }
            return sum;
         //  return num1 + num2; 
        }

        public static int Product(int x, int y)
        {
            return x * y;
        }
}
}
