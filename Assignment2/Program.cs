using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isDone = false;
            bool showMessage = true;
            string answer = "";
            string measurement = "";
            string measurement2 = "";

            do
            {
                if (true)
                {
                    Console.Clear();
                    Console.Write("Menu:\n1. Square: S \n2. Rectangle: R\n3. Circle: C\n4. Ellipse: E \n5. Pentagon: P\n>>> "); //Get user input for what shape to be created'
                    answer = Console.ReadLine();
                    if (checkEmpty(answer) == true)
                    {
                        displayErr();
                        showMessage = false;
                        //   showMessage = false;
                    }

                    else
                    { 
                        answer.ToLower();
                    }

                }

                /*else
                {
                    Console.Clear();
                    Console.Write(">>> ");
                    answer = Console.ReadLine();
                    
                }*/

                if(answer == "s" || answer == "square")//test user input and create appropriate shape object 
                {
                    Console.Write("\n\nEnter Side length\n>>> ");
                    measurement = Console.ReadLine();
                    if (checkEmpty(measurement) == true)
                    {
                        displayErr();
                    }

                    else
                    {
                        double sideLength = Double.Parse(measurement);

                        Square square = new Square(sideLength);
                        Console.WriteLine("Square: parameter: " + square.perameter() + " Area: " + square.area());
                    }

                }

                else if (answer == "r" || answer == "rectangle")//test user input and create appropriate shape object 
                {
                    Console.Write("\n\nEnter first side length\n>>> ");
                    measurement = Console.ReadLine();

                    if (checkEmpty(measurement) == true)
                    {
                        displayErr();
                    }

                    else
                    {
                        double sideLength1 = Double.Parse(measurement);

                        Console.Write("\n\nEnter second side\n>>> ");
                        measurement2 = Console.ReadLine();

                        if (checkEmpty(measurement) == true)
                        {
                            displayErr();
                        }
                        else
                        {
                            double sideLength2 = Double.Parse(measurement2);

                            Rectangle rectangle = new Rectangle(sideLength1, sideLength2);

                            Console.WriteLine("Rectangle: parameter: " + rectangle.Parameter() + " Area: " + rectangle.Area());
                        }
                    }

                }

                else if(answer == "c" || answer == "circle")
                {
                    Console.Write("Enter radius \n>>>");
                    measurement = Console.ReadLine();

                    if (checkEmpty(measurement) == true)
                    {
                        displayErr();
                    }
                    else
                    {
                        double radius = Double.Parse(measurement);

                        Circle circle = new Circle(radius);

                        Console.Write("Circle: Circumference/Perimeter: " + Math.Round(circle.circumference(), 2) + " Area: " + Math.Round(circle.area(), 2));
                    }    
                }

                else if(answer == "e" || answer == "elipse")
                {
                    Console.Write("Enter minor radius \n>>>");
                    measurement = Console.ReadLine();

                    if (checkEmpty(measurement) == true)
                    {
                        displayErr();
                    }
                    else
                    {
                        double minRad = Double.Parse(measurement);

                        Console.Write("\nEnter major radius \n>>");
                        measurement2 = Console.ReadLine();

                        if (checkEmpty(measurement2) == true)
                        {
                            displayErr();
                        }

                        else
                        {
                            double majRad = Double.Parse(measurement2);

                            Elipse elipse = new Elipse(minRad, majRad);

                            Console.Write("Elipse: Parimeter: " + Math.Round(elipse.perimeter(), 4) + " Area: " + Math.Round(elipse.area()));
                        }
                    }
                }

                else if(answer == "p" || answer == "pentagon")
                {
                    Console.Write("Enter side length \n>>>");
                    measurement = Console.ReadLine();

                    if (checkEmpty(measurement) == true)
                    {
                        displayErr();
                    }
                    else
                    {
                        double sidelength = Double.Parse(measurement);

                        Pentagon pentagon = new Pentagon(sidelength);

                        Console.Write("Pentagon: Perimeter: " + Math.Round(pentagon.perimeter(), 2) + " Area: " + Math.Round(pentagon.area(), 2));
                    }
                }

                else
                {
                    if (showMessage == true)
                    {
                        answer = "";
                        displayErr();
                        showMessage = true;
                    }
                }




                Console.Write("\nAgain? y or n\n>>>");//ask if user wnat to quit or not. if not break out of loop. 
                string val = Console.ReadLine();
                val.ToLower();

                if(val == "yes" || val == "y")
                {
                    continue;
                }

                else
                {
                    Console.WriteLine("Goodbye ");
                    isDone = true;
                }
        
            } while (isDone == false);


        }
        public static bool checkEmpty(string str)
        {
            return String.IsNullOrEmpty(str);
        }   

        static void displayErr()
        {
            Console.WriteLine("Invalid input\n");
        }
    }
}