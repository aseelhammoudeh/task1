using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the program!! \nThis program made 3 things, which are calculating the area of a rectangle, square and triangle.\nAlso, it has a simple calculator which take 2 inputs,operator , and find the result of it.\nAnd finally it has a login window takes a user name and password, check if they're already exist or not,if not add it as a new user\nSo, let's start!\n ");
            string[] menuItems = {
                "Calculate the area of a rectangle, square, or triangle.",
                "Simple calculator make an operation choosen for two numbers",
                "Login window.",
                "Exit from the program.",
                "Clear the console."
            };

            MainMenu mainmenu = new MainMenu();

            var selection = mainmenu.ShowMenu(menuItems);

            while (true)
            {
                if (selection == 1)
                {
                    SubMenu submenu = new SubMenu();
                    Console.WriteLine("Choose one of these options to find the area of it.\n");
                    string[] subMenuItems = {
                "The area of the rectangle",
                "The area of the triangle",
                "The area of the square",
                "back to main menu",
                "exit from the program"
            };
                    var select = submenu.ShowMenu(subMenuItems);


                    if (select == 1)
                    {
                        Console.Write("enter length: ");
                        string lengthString = Console.ReadLine();

                        Console.Write("enter width: ");
                        string widthString = Console.ReadLine();
                        double length, width;

                        if (Double.TryParse(lengthString, out length))
                        {

                            if (Double.TryParse(widthString, out width))
                            {

                                Rectangle r = new Rectangle(length, width);
                                double areaR = r.calculateArea();
                                Console.WriteLine("the area is " + areaR);
                                Console.WriteLine("if you want to back to the menu press q: ");
                                if (Console.ReadKey().KeyChar == 'q')
                                {

                                    Console.WriteLine("Are you sure ? enter y for yes, otherwise it will continue calculate the area of the square\n");
                                    if (Console.ReadKey().KeyChar == 'y')
                                    {
                                        submenu.ShowMenu(subMenuItems);
                                    }

                                }

                            }
                            else
                            {
                                Console.WriteLine("the width is invalid");
                                //      Console.ReadLine();
                            }

                        }
                        else
                        {
                            Console.WriteLine("the length is invalid");
                            //     Console.ReadLine();
                        }

                        submenu.ShowMenu(subMenuItems);

                    }


                    else if (select == 2)
                    {
                        Console.Write("enter base:");
                        string baseString = Console.ReadLine();

                        Console.Write("enter height:");
                        string heightString = Console.ReadLine();

                        double base_triangle, height_triangle;

                        if (Double.TryParse(baseString, out base_triangle))
                        {

                            if (Double.TryParse(heightString, out height_triangle))
                            {
                                Triangle t = new Triangle(base_triangle, height_triangle);
                                double areaT = t.calculateArea();
                                Console.WriteLine("the area is " + areaT);
                                Console.WriteLine("to quit from this enter q");
                                if (Console.ReadKey().KeyChar == 'q')
                                {

                                    Console.WriteLine("Are you sure ? enter y for yes, otherwise it will continue calculate the area of the square\n");
                                    if (Console.ReadKey().KeyChar == 'y')
                                    {
                                        submenu.ShowMenu(subMenuItems);
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("the height is invalid");
                                //  Console.ReadLine();
                            }

                        }
                        else
                        {
                            Console.WriteLine("the base is invalid");
                            //   Console.ReadLine();
                        }

                        submenu.ShowMenu(subMenuItems);

                    }

                    else if (select == 3)
                    {
                        Console.Write("enter side: ");

                        string sideString = Console.ReadLine();
                        double side;

                        if (Double.TryParse(sideString, out side))
                        {
                            Square s = new Square(side);
                            double areaS = s.calculateArea();
                            Console.WriteLine("the area is " + areaS);
                            Console.WriteLine("to quit from this enter q");
                            if (Console.ReadKey().KeyChar == 'q')
                            {

                                Console.WriteLine("Are you sure ? enter y for yes, otherwise it will continue calculate the area of the square\n");
                                if (Console.ReadKey().KeyChar == 'y')
                                {
                                    submenu.ShowMenu(subMenuItems);
                                }

                            }
                        }
                        else
                        {
                            Console.Write("the side is invalid");
                            // Console.ReadLine();
                        }

                        submenu.ShowMenu(subMenuItems);

                    }
                    else if (select == 4)
                    {
                        mainmenu.ShowMenu(menuItems);
                    }
                    else if (select == 5)
                    {
                        Console.WriteLine();
                    }
                    else
                    {

                    }

                }
                else if (selection == 2)
                {
                    // calculator 

                    Console.Write("enter the first number: ");
                    string number1 = Console.ReadLine();

                    Console.Write("enter the operator: ");
                    string operator_ = Console.ReadLine();

                    Console.Write("enter the second operand: ");
                    string number2 = Console.ReadLine();


                    double num1, num2;
                    char op;
                    if (Double.TryParse(number1, out num1))
                    {
                        // save  num1
                        if (Double.TryParse(number2, out num2))
                        {
                            // save num2 


                        }
                        else
                        {
                            Console.WriteLine("number 2 is invalid");
                            //        Console.ReadLine();
                        }


                    }
                    else
                    {
                        Console.WriteLine("number 1 is invalid");
                        //     Console.ReadLine();
                    }

                    if (Double.TryParse(number2, out num2))
                    {
                        double result;
                        // save num2 
                        if (Char.TryParse(operator_, out op))
                        {
                            if (op == '+')
                            {
                                result = num1 + num2;
                                Console.WriteLine("the result is : " + result);
                                //      Console.ReadLine();
                            }
                            else if (op == '-')
                            {
                                result = num1 - num2;
                                Console.WriteLine("the result is : " + result);
                                //     Console.ReadLine();
                            }

                            else if (op == '*')
                            {
                                result = num1 * num2;
                                Console.WriteLine("the result is : " + result);
                                //    Console.ReadLine();
                            }
                            else if (op == '/')
                            {
                                result = num1 / num2;
                                Console.WriteLine("the result is : " + result);
                                //     Console.ReadLine();
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("number 2 is invalid");
                        //    Console.ReadLine();
                    }
                    if (Console.ReadKey().KeyChar == 'q')
                    {

                        Console.WriteLine("Are you sure ? enter y for yes, otherwise it will continue calculate the area of the square\n");
                        if (Console.ReadKey().KeyChar == 'y')
                        {
                            mainmenu.ShowMenu(menuItems);
                        }

                    }

                }

                else if (selection == 3)
                {
                    loginWindow();


                }
                else if (selection == 4)
                {
                    break;
                }

                else if (selection == 5)
                {
                    Console.Clear();

                }

                else
                {
                    Console.WriteLine("the input is invalid");
                    Console.ReadLine();
                }

            
        }
    
        }//for main 

        public static bool length_of_the_string(string s)
        {



            bool valid_string = ((s.Length > 0) && (s.Length < 10) ? false : (s.Length < 0) || (s.Length < 10));
            return valid_string;
        }
        public static void loginWindow()
        {
            List<User> users = new List<User>();

            users.Add(new User("aseel", "12345"));
            users.Add(new User("sana", "45345"));
            users.Add(new User("noor", "00345"));

            //         enter a new user while q is not entered

            Console.WriteLine();
            Console.Write("username : \n");
            string username = Console.ReadLine();

            if (!length_of_the_string(username))
            {
                Console.WriteLine("the username is valid");
                if (Console.ReadKey().KeyChar == 'q')
                {
                    //     go back to user name menu
                    Console.Write("username : \n");
                    Console.ReadLine();
                }

            }
            else
            {
                Console.WriteLine();
                Console.Write("password : \n");
                string password = Console.ReadLine();
                if (length_of_the_string(password))
                {
                    Console.WriteLine("the password is valid");
                    Console.ReadLine();

                }
                else
                {
                    for (int i = 0; i < users.Count; i++)
                    {
                        if (username.Equals(users[i].getUsername()))
                        {

                            if (password.Equals(users[i].getPassword()))
                            {
                                Console.WriteLine("you just login with the user name: " + username + "and password: " + password);
                                Console.ReadLine();

                            }
                            else
                            {
                                Console.WriteLine("you just entered a wrong password");
                                Console.WriteLine("Press enter to exit...");

                                Console.ReadLine();
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Welcome you are a new user! ");
                            User new_user = new User(username, password);
                            users.Add(new_user);
                            Console.ReadLine();
                        }
                    }
                }
            }
        }
        
    }

}