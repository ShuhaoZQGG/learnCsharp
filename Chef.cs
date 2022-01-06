using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnCsharp
{
    internal class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes chiken");
        }

        public void MakeSalad()
        {
           Console.WriteLine("The Chef makes salad");
        }

        public virtual void MakeSpecialDish() // virtual means child class can overwrite this method
        {
            Console.WriteLine("The Chef makes bbq ribs");
        }
    }
}
