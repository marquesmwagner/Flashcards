using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards
{
    internal class UserCommands
    {
        internal static void MainMenu()
        {
            bool closeApp = false;
            while(!closeApp)
            {
                Console.WriteLine("\n\nMAIN MENU");
                Console.WriteLine("\nWhat you would like to do?");
                Console.WriteLine("\n0 - Close Application");
                Console.WriteLine("\n1 - Manage Flashcards");
                Console.WriteLine("\n2 - Study");

                string commandInput = Console.ReadLine();
                while (string.IsNullOrEmpty(commandInput) || !int.TryParse(commandInput, out _) 
                {
                    Console.WriteLine("\nInvalid choice. Please enter a valid input.\n");
                    commandInput = Console.ReadLine();
                }

                int command = Convert.ToInt32(commandInput);

                switch (command)
                {
                    case 0:
                        closeApp = true;
                        break;
                    case 1:
                        //Call StacksMenu();
                        break;
                    case 2:
                        //Call StudyMenu();
                        break;
                    default:
                        Console.WriteLine()
                }
            }
        }
    }
}
