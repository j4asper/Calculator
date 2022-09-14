

namespace Calculator
{
    internal class Program
    {
        static void Main()
        {
            Calculator calc = new();

            while (true)
            {
                Console.Clear();
                PrintMenu();
                
                Console.Write("Selection number: ");
                int menu;
                try
                {
                    menu = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input.\nPress Enter to return to main menu.");
                    Console.ReadLine();
                    continue;
                }

                if (menu >= 1 && menu <= 4)
                {
                    SelectMenu(menu);

                    double a;
                    double b;
                    try
                    {
                        Console.Write("Input first number: ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("Input second number: ");
                        b = double.Parse(Console.ReadLine());
                    } catch (FormatException)
                    {
                        Console.WriteLine("Invalid input.\nPress Enter to return to main menu.");
                        Console.ReadLine();
                        continue;
                    }
                    

                    if (menu == 1)
                    {
                        Console.WriteLine($"Result: {a}+{b}={calc.Add(a,b)}");
                    }
                    if (menu == 2)
                    {
                        Console.WriteLine($"Result: {a}-{b}={calc.Subtract(a,b)}");
                    }
                    if (menu == 3)
                    {
                        Console.WriteLine($"Result: {a}/{b}={calc.Divide(a,b)}");
                    }
                    if (menu == 4)
                    {
                        Console.WriteLine($"Result: {a}*{b}={calc.Multiply(a,b)}");
                    }
                    Console.WriteLine("\nPress ENTER to return to main menu.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Calculation method doesn't exist.\nPress Enter to return to main menu.");
                    Console.ReadLine();
                }
            }
        }

        private static void PrintMenu()
        {
            Console.WriteLine("  _____      _            _       _             \n / ____|    | |          | |     | |            \n| |     __ _| | ___ _   _| | __ _| |_ ___  _ __ \n| |    / _` | |/ __| | | | |/ _` | __/ _ \\| '__|\n| |___| (_| | | (__| |_| | | (_| | || (_) | |   \n \\_____\\__,_|_|\\___|\\__,_|_|\\__,_|\\__\\___/|_|\n");
            Console.WriteLine("+---------------------------------+");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|        Select Calculation       |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|        [1] Add                  |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|        [2] Subtract             |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|        [3] Divide               |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|        [4] Multiply             |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("+---------------------------------+");
        }

        private static void SelectMenu(int menuNumber)
        {
            Console.Clear();

            Console.WriteLine("  _____      _            _       _             \n / ____|    | |          | |     | |            \n| |     __ _| | ___ _   _| | __ _| |_ ___  _ __ \n| |    / _` | |/ __| | | | |/ _` | __/ _ \\| '__|\n| |___| (_| | | (__| |_| | | (_| | || (_) | |   \n \\_____\\__,_|_|\\___|\\__,_|_|\\__,_|\\__\\___/|_|\n");
            Console.WriteLine("+---------------------------------+");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|        Select Calculation       |");
            Console.WriteLine("|                                 |");
            if (menuNumber == 1)
            {
                Console.WriteLine("|     -> [1] Add                  |");
            } else
            {
                Console.WriteLine("|        [1] Add                  |");
            }
            Console.WriteLine("|                                 |");
            if (menuNumber == 2)
            {
                Console.WriteLine("|     -> [2] Subtract             |");
            }
            else
            {
                Console.WriteLine("|        [2] Subtract             |");
            }
            Console.WriteLine("|                                 |");
            if (menuNumber == 3)
            {
                Console.WriteLine("|     -> [3] Divide               |");
            }
            else
            {
                Console.WriteLine("|        [3] Divide               |");
            }
            Console.WriteLine("|                                 |");
            if (menuNumber == 4)
            {
                Console.WriteLine("|     -> [4] Multiply             |");
            }
            else
            {
                Console.WriteLine("|        [4] Multiply             |");
            }
            Console.WriteLine("|                                 |");
            Console.WriteLine("+---------------------------------+");
        }
    }
}