using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieVSDinosaurs
{
    abstract class Creature
    {
        protected int intelligence;
        protected int resistance;
        protected int strenght;
        protected int randomNumber;
        protected int maxValue;
        protected static Random randomizer = new Random();

        abstract protected void StatGenerator(); 
        //An abstract method each creature has that randomizes it's stats.
       

        public virtual int ChessGame(int chessResult) 
            //A public int that can be overrid and that randomizes the results of a chess game for each creature based on a random number between 0-1 + the creatures inteligence score
        {
            randomNumber = randomizer.Next(10);
            chessResult = randomNumber + intelligence;
            if (20 < chessResult)
            {
                return 20;
            }
            else
            {
                return chessResult;
            }
            
        }
        public virtual int Wrestling(int wrestlingResult)
        //A public int that can be overrid and that randomizes the results of a wrestling match for each creature based on a random number between 0-1 + the creatures resistance score 
        {
            {
                randomNumber = randomizer.Next(10);
                wrestlingResult = randomNumber + resistance;
                if (20 < wrestlingResult)
                {
                    return 20;
                }
                else
                {
                    return wrestlingResult;
                }
            }
            
        }
        public virtual int ArmWrestling(int armwrestlingResult)
        {
            randomNumber = randomizer.Next(10);
            armwrestlingResult = randomNumber + strenght;
            if (20 < armwrestlingResult)
            {
                return 20;
            }
            else
            {
                return armwrestlingResult;
            }
           
        }
    }
}
