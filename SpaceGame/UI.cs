using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class UI
    {
        public void DisplayResult(Result result)
        {
            Console.Clear();
            if (!result.Succes) { Console.ForegroundColor = ConsoleColor.Red; }
            Console.WriteLine(result.Message);
            //Console.ResetColor();
        }
        public IAction ChooseAction(List<IAction> actions)
        {
            while (true) {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("=================");
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < actions.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {actions[i].Name}");
                }
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("=================");
                Console.ResetColor();
                var select = Console.ReadLine();
                if (int.TryParse(select, out int id))
                {
                    if (id > actions.Count || id < 1) 
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Invalid selection. Try again");
                        continue;
                    } 
                    return actions[id-1];
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not a number");
                    continue;
                }
            }
            
        }
        public int SelectSize(int sizeMax,int sizeMin)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Please select Universe size {sizeMin}-{sizeMax} (number of systems):");
                var userInput = Console.ReadLine();
                int.TryParse(userInput, out int select);
                if(select > sizeMax || select <sizeMin)
                {
                    Console.Clear();
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Select valid number (3-200)");
                    Console.WriteLine("Any to continue");
                    Console.ReadLine();
                    Console.Clear() ;
  
                    continue;

                }
                Console.ResetColor();
                return select;
            }
        }

        public void WelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            
            
            string footer = "Press any to continu";
            string title = @"
              _________                             ________                       
             /   _____/__________    ____  ____    /  _____/_____    _____   ____  
             \_____  \\____ \__  \ _/ ___\/ __ \  /   \  ___\__  \  /     \_/ __ \ 
             /        \  |_> > __ \\  \__\  ___/  \    \_\  \/ __ \|  Y Y  \  ___/ 
            /_______  /   __(____  /\___  >___  >  \______  (____  /__|_|  /\___  >
                    \/|__|       \/     \/    \/          \/     \/      \/     \/ 

            ";
            int windowWidth = Console.WindowWidth;
            int botLength = footer.Length;
            int titleLen = title.Length;
            int spacesTitle = (windowWidth - titleLen) / 2;
            int spacesBot = (windowWidth - botLength) / 2;
            if (spacesTitle < 0) spacesTitle = 0; 
            if (spacesBot < 0) spacesBot = 0;
            Console.WriteLine(new string(' ', spacesTitle) + title);
            Console.WriteLine(new string(' ', spacesBot) + footer);
            Console.ReadLine();
            Console.Clear();
        }

    }
}
