using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            bool isStop = true;

            do
            {
                try
                {
                    Console.WriteLine("/nSelect anyone from below list: /n1. Get Rectangle Length /n2. Change Rectangle Length /n3. Get Rectangle Width /n4. Change Rectangle Width /n5. Get Rectangle Perimeter /n6. Get Rectangle Area /n7. Exit");
                    int selectedIndex = Int16.Parse(Console.ReadLine());

                    switch (selectedIndex)
                    {
                        case 1:
                            Console.WriteLine("Rectangle length: ", rect.GetLength());
                            break;
                        case 2:
                            Console.WriteLine("Enter Rectangle length: ");
                            int length = Int16.Parse(Console.ReadLine());
                            rect.SetLength(length);
                            break;
                        case 3:
                            Console.WriteLine("Rectangle Width: ", rect.GetWidth());
                            break;
                        case 4:
                            Console.WriteLine("Enter Rectangle Width: ");
                            int width = Int16.Parse(Console.ReadLine());
                            rect.SetLength(width);
                            break;
                        case 5:
                            Console.WriteLine("Rectangle Perimeter: ", rect.GetPerimeter());
                            break;
                        case 6:
                            Console.WriteLine("Rectangle Area: ", rect.GetArea());
                            break;
                        case 7:
                            Environment.Exit(0);
                            break;
                        default:
                            isStop = true;
                            Console.WriteLine("Incorrect Input");
                            break;
                    };
                }
                catch
                {
                    isStop = false;
                }
            } while (isStop);

        }
    }
}
