using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_QA
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            EnterHeightAgain:
            Console.WriteLine("Please enter height of the rectangle(integer only greater than 0)");
            var height = Console.ReadLine();
            if(!int.TryParse(height, out int rectHeight) || rectHeight <= 0)
            {
                Console.WriteLine("Please Enter correct height of rectangle");
                goto EnterHeightAgain;
            }
            rectangle.SetHeight(rectHeight);
            EnterWidthAgain:
            Console.WriteLine("Please enter width of the rectangle(integer only greater than 0)");
            var width = Console.ReadLine();
            if (!int.TryParse(width, out int rectWidth) || rectWidth <= 0)
            {
                Console.WriteLine("Please Enter correct width of rectangle");
                goto EnterWidthAgain;
            }
            rectangle.SetWidth(rectWidth);
            EnterLengthAgain:
            Console.WriteLine("Please enter length of the rectangle(integer only greater than 0)");
            var length = Console.ReadLine();
            if (!int.TryParse(length, out int rectLength) || rectLength <= 0)
            {
                Console.WriteLine("Please Enter correct length of rectangle");
                goto EnterLengthAgain;
            }
            rectangle.SetLength(rectLength);
            PlayMenuOptions:
            Console.WriteLine("Please Select an option number to proceed!!!!");
            Console.WriteLine("1. Get Rectangle Length");
            Console.WriteLine("2. Change Rectangle Length");
            Console.WriteLine("3. Get Rectangle Width");
            Console.WriteLine("4. Change Rectangle Width");
            Console.WriteLine("5. Get Rectangle Height");
            Console.WriteLine("6. Change Rectangle Height");
            Console.WriteLine("7. Get Rectangle Volume");
            Console.WriteLine("8. Exit");
            var optionSelected = Console.ReadLine();
            if(!int.TryParse(optionSelected, out int correctOptionSelected))
            {
                Console.WriteLine("Please enter correct menu option");
                goto PlayMenuOptions;
            }
            switch (correctOptionSelected)
            {
                case 1:
                    Console.WriteLine("Rectangle Length" + rectangle.GetLength());
                    break;
                case 2:
                    ReenterRectangleLength:
                    Console.WriteLine("Enter new rectangle length(integer only greater than 0)");
                    var newLength = Console.ReadLine();
                    if(!int.TryParse(newLength, out int newRectLength))
                    {
                        Console.WriteLine("Please enter correct rectangle length");
                        goto ReenterRectangleLength;
                    }
                    rectangle.SetLength(newRectLength);
                    Console.WriteLine("Length set");
                    break;
                case 3:
                    Console.WriteLine("Rectangle Width" + rectangle.GetWidth());
                    break;
                case 4:
                    ReenterRectangleWidth:
                    Console.WriteLine("Enter new rectangle width(integer only greater than 0)");
                    var newWidth = Console.ReadLine();
                    if (!int.TryParse(newWidth, out int newRectWidth))
                    {
                        Console.WriteLine("Please enter correct rectangle width");
                        goto ReenterRectangleWidth;
                    }
                    rectangle.SetWidth(newRectWidth);
                    Console.WriteLine("Width set");
                    break;
                case 5:
                    Console.WriteLine("Rectangle Height" + rectangle.GetHeight());
                    break;
                case 6:
                    ReenterRectangleHeight:
                    Console.WriteLine("Enter new rectangle height(integer only greater than 0)");
                    var newHeight = Console.ReadLine();
                    if (!int.TryParse(newHeight, out int newRectHeight))
                    {
                        Console.WriteLine("Please enter correct rectangle width");
                        goto ReenterRectangleHeight;
                    }
                    rectangle.SetHeight(newRectHeight);
                    Console.WriteLine("Height set");
                    break;
                case 7:
                    Console.WriteLine(rectangle.GetVolume());
                    break;
                case 8:
                    Environment.Exit(0);
                    break;
            }
            goto PlayMenuOptions;
        }
    }
}
