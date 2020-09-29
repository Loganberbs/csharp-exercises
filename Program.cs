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

                Console.WriteLine("How longs your 'rectangle'? :");
                input = Console.ReadLine();
                length = double.Parse(input);
            
                Console.WriteLine("What kind of girth is your 'tangle workin with? :");
                input = Console.ReadLine();
                width = double.Parse(input);

                area = length * width;
                
                Console.WriteLine("The area of your tangle is: " + area);
                Console.ReadLine();
            }
        }
    }

