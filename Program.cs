using System;

namespace data_types
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name);

            double area;
            double length;
            double width;
            string input;

            Console.WriteLine("How long's your 'tangle'? :");
            input = Console.ReadLine();
            length = double.Parse(input);

            Console.WriteLine("What kind of girth is your 'tangle workin with? :");
            input = Console.ReadLine();
            width = double.Parse(input);

            area = length * width;

            Console.WriteLine("The area of your tangle is: " + area);


            Console.WriteLine("How many miles have you driven? ");

            double gallons;
            double miles;
            double mpg;

            input = Console.ReadLine();
            miles = double.Parse(input);

            Console.WriteLine("How many gallons of gas was used?");

            input = Console.ReadLine();
            gallons = double.Parse(input);

            mpg = miles / gallons;
            Console.WriteLine("The fuel efficency of your vehicle is: " + mpg + "mpg, or Miles Per Gallon.");
            Console.WriteLine("Enter a word from the passage below: ");
            string message = Message.GetMessage(string);
            
            Console.WriteLine(message);

        }
    }

   public class Message
    {
        
        public static string GetMessage(string[])
        {
            string str = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
        }
        

    }
}

