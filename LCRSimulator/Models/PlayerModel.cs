using LCRSimulator.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCRSimulator.Models
{
    internal class PlayerModel 
    {
        public int NumberOfDice { get; set; } = 3;
        public int NumberOfChips { get; set; } = 3;

        public PlayerModel()
        {
        }
    }
    internal class RollRandomDie
    {
        private Random _randomSide;
        private int _sidesNum;

        public RollRandomDie()
        {
            _sidesNum = 6;
            _randomSide = new Random();
        }
    
        public int RollDie()
        {
            return _randomSide.Next(1, _sidesNum + 1);
        }
    }
}
