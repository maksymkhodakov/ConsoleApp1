using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    abstract class Worker
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string WorkDay { get; set; }

        public Worker(string Name, string Position, string WorkDay)
        {
            this.Name = Name;
            this.Position = Position;
            this.WorkDay = WorkDay;
        }

        public void Call()
        {
            Console.WriteLine("Calling!!!");
        }

        public void WriteCode()
        {
            Console.WriteLine("Writing Code!!!");
        }

        public void Relax()
        {
            Console.WriteLine("Relaxing");
        }

        public abstract void FillWorkDay();
    }
}
