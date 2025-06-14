using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class UI
    {
        public void displayResult(Result result)
        {
            Console.Clear();
            Console.WriteLine(result.Message);
        }
        public IAction chooseAction(List<IAction> actions)
        {
            while (true) {
                //Console.WriteLine("Select action:");
                for (int i = 0; i < actions.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {actions[i].Name}");
                }
                string select = Console.ReadLine();
                if (int.TryParse(select, out int id))
                {
                    if(id > actions.Count) { Console.WriteLine($"DEBUG: The selected action is null"); return null; } //temp
                    return actions[id-1];
                }
            }
            
        }

    }
}
