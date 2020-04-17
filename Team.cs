using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieVSDinosaurs
{
    class Team
    {
        private List<Zombie> zombies = new List<Zombie>();
        private List<Dinosaur> dinosaurs = new List<Dinosaur>();
        public void SetTeamMembersZombie(int amount)
        {
         
            for(int i = 0; i<amount; i++)
            {
                zombies.Add(new Zombie());
                
            }
        }
        public void SetTeamMembersDinosaurs(int amount)
        {

            for (int i = 0; i < amount; i++)
            {
               
                dinosaurs.Add(new Dinosaur());
            }
        }
        
    }
}
