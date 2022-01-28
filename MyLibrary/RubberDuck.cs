using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class RubberDuck: Duck, Quackable
    {
        public override string display()
        {
            return "display " + this.GetType();
        }
        public string Quack()
        {
            return "Quack" + " " + this.GetType();
            
        }
    }
}
