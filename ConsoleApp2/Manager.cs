using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Manager : Worker
    {
        private Random random = new Random();
        public Manager(string Name, string WorkDay) : base(Name, Position: "Manager", WorkDay) { }
        public override void FillWorkDay()
        {
            int rand1 = random.Next(1, 11);
            int rand2 = random.Next(1, 6);

            for (int i = 1; i < rand1; i++)
            {
                Call();
            }
            Relax();
            for (int i = 1; i < rand2; i++)
            {
                Call();
            }
        }
    }
}
