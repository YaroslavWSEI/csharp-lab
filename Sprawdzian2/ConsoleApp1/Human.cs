using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Human
    {
        
        public virtual string Name { get; set; }
        public virtual string EatSnack()
        {
            return "Ice cream!";
        }
    }
}
