using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the user's menu choice.
            //int area = Console.ReadKey();
            int menuAnswer = GetMenu();
            

            //Console.WriteLine("getmenu atbilde : " + GetMenu());
            switch (menuAnswer) {
                case 1:
                    CalculateCircleArea();
                    break;
                case 2:
                    CalculateRectangleArea();
                    break;
                case 3:
                    CalculateTriangleArea();
                    break;
                case 4:

                    break;
                default:
                    Console.WriteLine("Invalid input : " + menuAnswer);
                    break;
            }

            Console.ReadKey();
            Console.ReadKey();
        }

        public static int GetMenu()
        {

            int userChoice = 0;
            

            // Display the menu.
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            int keyboard = Convert.ToInt32(Console.ReadLine());
            // get input from user
            userChoice = keyboard;

            // validate input

            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            // Get input from user
            Console.WriteLine("What is the circle's radius? ");
            //todo
            int radius = Convert.ToInt32(Console.ReadLine());

            // Display output
            Console.WriteLine("The circle's area is "
                    + Geometry.AreaOfCircle(radius));
           
        }

        public static void CalculateRectangleArea()
        {
            decimal length = 0;
            decimal width = 0;

            // Get input from user

            // Get length
            Console.WriteLine("Enter length? ");
            //todo
            length = Convert.ToInt32(Console.ReadLine());

            // Get width
            Console.WriteLine("Enter width? ");
            //todo
            width = Convert.ToInt32(Console.ReadLine());
            // Display output
            //Console.WriteLine("The rectangle's area is "
            //+ Geometry.AreaOfTriangle(length, width));
            Console.WriteLine("The rectangle`s area is " + length * width);
        }

        public static void CalculateTriangleArea()
        {
            decimal ground = 0;
            decimal height = 0;

            // Get input from user

            // Get the base
            Console.WriteLine("Enter length of the triangle's base? ");
            //todo
            ground = Console.Read();
            //read key value

            // Get the height
            Console.WriteLine("Enter triangle's height? ");
            //todo
            height = Console.Read();
            //read key value

            // Display the triangle's area.
            Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfRectangle(ground, height));
        }
    }
}
