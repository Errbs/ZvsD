using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieVSDinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            bool successful = false;
            while (successful == false)
            {
                Console.WriteLine("How many teammembers should each team have?");
                string amountInput = Console.ReadLine();
                int amountResult;
                successful = int.TryParse(amountInput, out amountResult);
                if (successful == true)
                {
                    Team teamZombies = new Team();
                    Team teamDinosaurs = new Team();
                    teamZombies.SetTeamMembersZombie(amountResult);
                    teamDinosaurs.SetTeamMembersDinosaurs(amountResult);
                }
                else
                {
                    Console.WriteLine("Only numbers are valid as input");
                }
            }

            Console.Read();
            

        }
    }
}
