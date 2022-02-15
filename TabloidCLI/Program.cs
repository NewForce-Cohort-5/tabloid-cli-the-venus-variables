using System;
using TabloidCLI.UserInterfaceManagers;

namespace TabloidCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($@"
_|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|
___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|__
_|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|
___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|__
_|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|
___|___|___|___|___|___|___|   ,,,   |___|___|___|___|___|___|___|___|
_|___|___|___|___|___|___|    (o o)    |___|___|___|___|___|___|___|__
                      ----oOO--( )--OOo----
___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|__
_|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|
___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|__
_|___|___|___|___|___ WELCOME TO TABLOID 720 ___|___|___|___|___|___|
___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|__
_|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|
___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|__
_|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|
___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|__
_|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|
___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|__
_|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|
___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|__
            ");


            // Get an array with the values of ConsoleColor enumeration members.
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            // Save the current background color.
            ConsoleColor currentBackground = Console.BackgroundColor;
            // Display each background color except the one that matches the current foreground color.
            Console.WriteLine("Choose a color to set the background color. Press '0' to keep the color as is.");
            // int choice;
            for (var i = 0; i < colors.Length; i++)
            {
                if (colors[i] == currentBackground) continue;
                Console.WriteLine($"{i}) {colors[i]}");

            }

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "0":
                    break;
                case "1": 
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Clear();
                    break;
                case "2":
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Clear();
                    break;
                case "3":
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.Clear();
                    break;
                case "4":
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    break;
                case "5":
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.Clear();
                    break;
                case "6":
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "7":
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.Clear();
                    break;
                case "8":
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.Clear();
                    break;
                case "9":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    break;
                case "10":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Clear();
                    break;
                case "11":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.Clear();
                    break;
                case "12":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    break;
                case "13":
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.Clear();
                    break;
                case "14":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "15":
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }

            // MainMenuManager implements the IUserInterfaceManager interface
            IUserInterfaceManager ui = new MainMenuManager();
            while (ui != null)
            {
                // Each call to Execute will return the next IUserInterfaceManager we should execute
                // When it returns null, we should exit the program;
                ui = ui.Execute();
            }
        }
    }
}
