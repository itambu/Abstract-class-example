using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp30
{
    public class Nail : Item, IElement
    {
        public Nail() : base("Nail", 10)
        {
        }
    }
}