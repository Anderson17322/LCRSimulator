using LCRSimulator.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace LCRSimulator.Models
{
    internal class SimulatorModel : IGameSimulatorModel
    {
        int _numberPlayers { get; set; } = 0;
        int _numberGames { get; set; } = 0;
 
        OutputDataModel _OutputDataModel = null;
        List<PlayerModel> _players = null;
        List<int> _numTurns { get; set; }
       
        public SimulatorModel(int numberPlayers, int numGames)
        {
  
            _numberPlayers = numberPlayers;
            _numberGames = numGames;
            _players = new List<PlayerModel>();
            for(int inum =0;inum< numberPlayers;inum++)
            {
                _players.Add(new PlayerModel());
            }
        }
        public void CalculateOutput()
        {
            
        }
        int iTurnsCounter = 0;
        bool GameOver()
        {
            
            for (int iNum = 0; iNum < _players.Count; iNum++)
            {
                PlayerModel player = _players[iNum];
                if(player.NumberOfChips > 0)
                {
                    iTurnsCounter++;
                }
            }
            if(iTurnsCounter == 1)
            {

            }
            return iTurnsCounter == 1;
        }
        RollRandomDie _rollRandomDie = null;
        void PlayOneTurn(PlayerModel player, int iNumIndex)
        {
            _rollRandomDie  = new RollRandomDie();
            // going left means give to the next player in the list
            // going right means give to the previous player in the list
            
            for (int i=0;i< player.NumberOfChips;i++) 
            {
                if (player.NumberOfChips > 0)
                {
                    player.NumberOfDice = player.NumberOfChips;
                    for (int j = 0; j < player.NumberOfDice; j++)
                    {
                        if (player.NumberOfChips == 0)
                            break;
                        DieSides onedie = (DieSides)_rollRandomDie.RollDie();
                        //
                        if (onedie == DieSides.Dot1 || onedie == DieSides.Dot2 || onedie == DieSides.Dot3)
                        {

                        }
                        else
                        {
                            if (onedie == DieSides.Left)
                            {
                                UpdatePlayer(iNumIndex == _players.Count - 1 ? iNumIndex + 1 : 0);
                            }
                            else if (onedie == DieSides.Right)
                            {
                                UpdatePlayer(iNumIndex == 0 ? 1 : iNumIndex - 1);
                            }
                            else if (onedie == DieSides.Center)
                            {

                            }
                            player.NumberOfChips--;
                            
                        }
                    }
                    break;
                }
            }
        }
        void UpdatePlayer(int iNumIndex)
        {
            if(_players.Count > iNumIndex)
            {
                _players[iNumIndex].NumberOfChips++;
            }
            
        }
        public bool RunOneGame()
        {
            try
            {


                iTurnsCounter = 0;
                for (int iNum = 0; iNum < _numberPlayers; iNum++)
                {
                    PlayerModel player = _players[iNum];
                    PlayOneTurn(player, iNum);
                    if (GameOver())
                    {
                        return true;
                    }
                    else
                    {
                        if (iTurnsCounter > 0)
                            _numTurns.Add(iTurnsCounter);
                    }
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool ValidateInput()
        {
            if(_numberPlayers < 3)
            {
                MessageBox.Show("Number of players must be at least 3");
                return false;
            }
            if (_numberGames == 0)
            {
                MessageBox.Show("Number of games must be greater than zero");
                return false;
            }
            return true;
        }

        public bool RunSimulator()
        {
            try
            {
                _numTurns = new List<int>();
                _OutputDataModel = new OutputDataModel();
                for (int iTurn = 0; iTurn < _numberGames; iTurn++)
                {
                    
                    if (RunOneGame())
                    {
                        
                    }
                }
                if (_numTurns.Count > 0)
                {
                    _OutputDataModel.ShortestLengthGame = _numTurns.Min();
                    _OutputDataModel.LongestLengthGame = _numTurns.Max();
                    _OutputDataModel.AvarageLengthGame = (int)_numTurns.Average();
                }
                else
                {

                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public OutputDataModel GetOutputData()
        {
            return _OutputDataModel;
        }
    }
}
