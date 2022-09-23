using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Developer : Worker
    {
        public Developer(string Name, string WorkDay) : base(Name, Position:"Developer", WorkDay) {}

        public override void FillWorkDay()
        {
            WriteCode();
            Call();
            Relax();
            WriteCode();
        }
    }
}
