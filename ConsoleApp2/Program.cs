using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Developer("Max", "122");
            Worker worker2 = new Manager("Kyrylo", "123");
            Team dreamTeam = new Team("Dream Team");
            dreamTeam.AddTeammate(worker1);
            dreamTeam.AddTeammate(worker2);
            dreamTeam.GetDetailTeamInfo();
            dreamTeam.GetTeamInfo();
            worker2.FillWorkDay();
        }
    }
}
