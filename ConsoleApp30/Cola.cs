using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp30
{
    public class Cola : IElement
    {
        public string? Name => "Cola";

        public decimal Cost => 5;
    }
}