using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    internal class Result
    {
        public string Message { get; set; }
        public List<IAction> followUpActions = new List<IAction>();

        public Result(string message, List<IAction> followUpActions)
        {
            Message = message;
            this.followUpActions = followUpActions ?? new List<IAction>();
        }
        public Result(string message)
        {
            Message = message;
            this.followUpActions =  new List<IAction>();
        }


    }
}
