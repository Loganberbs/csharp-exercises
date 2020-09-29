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

            Console.WriteLine("The fuel efficency of your vehicle is: "+mpg+"mpg, or Miles Per Gallon.");


        }
        }
    }

