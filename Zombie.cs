using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieVSDinosaurs
{
    class Zombie: Creature
    {
        
       
        protected override void StatGenerator()
        {
            intelligence = randomizer.Next(5);
            resistance = randomizer.Next(10);
            strenght = randomizer.Next(7);
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
