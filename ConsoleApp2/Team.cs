using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Team
    {
        private string TeamName {get; set;}
        private List<Worker> workers = new List<Worker>();
        
        public Team(string TeamName)
        {
            this.TeamName = TeamName;
        }

        public void AddTeammate(Worker worker)
        {
            workers.Add(worker);
        }

        public void GetTeamInfo()
        {
            Console.WriteLine("Team name: " + TeamName);
            Console.WriteLine("Workers info: ");
            foreach (Worker worker in workers)
            {
                Console.WriteLine(worker.Name);
            }
        }

        public void GetDetailTeamInfo()
        {
            Console.WriteLine("Team name: " + TeamName);
            Console.WriteLine("Workers info: ");
            foreach (Worker worker in workers)
            {
                Console.WriteLine(worker.Name + " - " + worker.Position + " - " + worker.WorkDay);
            }
        }
    }
}
