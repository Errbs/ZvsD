using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieVSDinosaurs
{
    class Dinosaur: Creature
    {
       
      
        protected override void StatGenerator()
        {
            intelligence = randomizer.Next(10);
            resistance = randomizer.Next(5);
            strenght = randomizer.Next(13);
        }

        public override int ChessGame(int chessResult)
        {
            return base.ChessGame(chessResult);
        }
        public override int Wrestling(int wrestlingResult)
        {
            return base.Wrestling(wrestlingResult);
        }
        public override int ArmWrestling(int armwrestlingResult)
        {
            return base.ArmWrestling(armwrestlingResult);
        }
    }
    
}
