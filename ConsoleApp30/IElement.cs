using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp30
{
    public interface IElement : ICostable
    {
        string? Name { get; }
    }
}