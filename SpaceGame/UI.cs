using System;
using System.Collections.Generic;
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
            Console.WriteLine(result.Message);
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
                    if (id > actions.Count) { Console.WriteLine($"DEBUG: The selected action is null"); return null; } //temp
                    return actions[id-1];
                }
            }
            
        }
        public int SelectSize()
        {
            Console.WriteLine("Please select Universe size (number of systems):");
            var userInput = Console.ReadLine();
            int.TryParse(userInput, out int select);
            return select;
        }

    }
}
