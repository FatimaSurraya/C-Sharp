﻿namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Concatenation: Joining of two variables
            string firstName = "Fatima";
            string lastName = "Surraya";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
            int p = 30, q = 40;

            var result = p < q ? "p is less than q" : "q is less than p";
            Console.WriteLine(result);

            // Variables
            int age = 23;
            // age = age + 1;
            age++;
            Console.WriteLine($"Age: {age}");
            Console.ReadLine();
            string n = "Lahore";
            Console.WriteLine($"City: {n}");

            Console.WriteLine("I want to be a Successful Developer");
            Console.WriteLine("I am passionately learning C#");
            Console.ReadLine();
            Console.WriteLine("It should end happily");
            Console.ReadLine();

            float ft = 1.5f;
            Console.WriteLine(ft);
            Console.ReadLine();

            //User Input
            string f;
            Console.Write("Please Enter Your Name:");
            f = Console.ReadLine();

            Console.WriteLine("n = {0}", f);
            Console.ReadLine();
            //Converting string to int (Because Arithematic operatioons are not performed on string (e.g string 10 + 10 = 10 10 not 20))

            int age1;
            Console.Write("Enter your age:");
            age1 = int.Parse(Console.ReadLine());
            Console.WriteLine(age1);
            Console.ReadLine();

            Console.WriteLine("If Conition");
            Console.ReadLine();
            int i = 10, j = 20;
            if (i < j)
            {
                Console.WriteLine("i is less than j");
            }

            if (i > j)
            {
                Console.WriteLine("j is less than i");
            }
            Console.ReadLine();
            int a = 10, b = 20;

            if (isGreater(a, b))
            {
                Console.WriteLine("a is less than b");
            }

            if (isGreater(a, b))
            {
                Console.WriteLine("b is greater than a");
            }
        }

        static bool isGreater(int a, int b)
        {
            return a > b;
        }
        //C# includes a decision-making operator ?: which is called the conditional operator or ternary operator.
        //ternary operator starts with a boolean condition
        

    }
}

   
