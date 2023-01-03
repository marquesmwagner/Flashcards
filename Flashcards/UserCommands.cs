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
            while(closeApp == false)
            {
                Console.WriteLine("\n\nMAIN MENU");
                Console.WriteLine("\nWhat you would like to do?");
                Console.WriteLine("\n0 - Close application");
                Console.WriteLine("\n1 - Manage flashcards");
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
                        StacksMenu();
                        break;
                    case 2:
                        //Call StudyMenu();
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice. Please enter a valid input.\n");
                        break;
                }
            }
        }

        public static void StacksMenu()
        {
            Console.WriteLine("\n\nFlashCard Stacks Area\n");
            //StacksController.GetStacks();

            bool closeArea = false;
            while(closeArea == false)
            {
                Console.WriteLine("\nWhat you would like to do?");
                Console.WriteLine("\n0 - Close application");
                Console.WriteLine("\n1 - Return to main menu");
                Console.WriteLine("\n2 - Create new stack");
                Console.WriteLine("\n3 - Manage a stack");

                string commandInput = Console.ReadLine();
                while (string.IsNullOrEmpty(commandInput) || !int.TryParse(commandInput, out _))
                {
                    Console.WriteLine("\nInvalid choice. Please enter a valid input");
                    commandInput = Console.ReadLine();
                }

                int command = Convert.ToInt32(commandInput);

                switch (command)
                {
                    case 0:
                        closeArea = true;
                        break;
                    case 1:
                        //StacksController.CreateStack();
                        break;
                    case 2:
                        //StacksControle.ManageStack();
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice. Please enter a valid input.");
                        break;
                }
            }
        }
    }
}
