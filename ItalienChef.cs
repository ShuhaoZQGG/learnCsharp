using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnCsharp
{
    internal class ItalienChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("The chef makes pasta");
        }

        public override void MakeSpecialDish() // override in the child class, virtual in the parent class
        {
            Console.WriteLine("The chef makes pizza");
        }
    }
}
