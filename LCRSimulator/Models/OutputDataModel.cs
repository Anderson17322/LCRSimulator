using LCRSimulator.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCRSimulator.Models
{
    internal class OutputDataModel : ViewModelBase
    {
        int _shortestLengthGame { get; set; } = 0;
        int _longestLengthGame { get; set; } = 0;
        int _avarageLengthGame { get; set; } = 0;

        string _outputLabel { get; set; } = "";
        string _shortestLengthGameLabel { get; set; } = "";
        string _longestLengthGameLabel { get; set; } = "";
        string _avarageLengthGameLabel { get; set; } = "";

        public OutputDataModel()
        {
            _avarageLengthGameLabel = "No. Average Length";
            _longestLengthGameLabel = "No. Longest Length";
            _shortestLengthGameLabel = "No. Shortest Length";
            _outputLabel = "Output Data";
        }

        public int ShortestLengthGame
        {
            get
            {
                return _shortestLengthGame;
            }
            set
            {
                if (_shortestLengthGame != value)
                {
                    _shortestLengthGame = value;
                    RaisePropertyChanged(() => ShortestLengthGame);
                }
            }
        }
        
        public int LongestLengthGame
        {
            get
            {
                return _longestLengthGame;
            }
            set
            {
                if (_longestLengthGame != value)
                {
                    _longestLengthGame = value;
                    RaisePropertyChanged(() => LongestLengthGame);
                }
            }
        }
        public int AvarageLengthGame
        {
            get
            {
                return _avarageLengthGame;
            }
            set
            {
                if (_avarageLengthGame != value)
                {
                    _avarageLengthGame = value;
                    RaisePropertyChanged(() => AvarageLengthGame);
                }
            }
        }

        public string ShortestLengthGameLabel
        {
            get
            {
                return _shortestLengthGameLabel;
            }
            set
            {
                if (_shortestLengthGameLabel != value)
                {
                    _shortestLengthGameLabel = value;
                    RaisePropertyChanged(() => ShortestLengthGameLabel);
                }
            }
        }

        public string LongestLengthGameLabel
        {
            get
            {
                return _longestLengthGameLabel;
            }
            set
            {
                if (_longestLengthGameLabel != value)
                {
                    _longestLengthGameLabel = value;
                    RaisePropertyChanged(() => LongestLengthGameLabel);
                }
            }
        }
        public string AvarageLengthGameLabel
        {
            get
            {
                return _avarageLengthGameLabel;
            }
            set
            {
                if (_avarageLengthGameLabel != value)
                {
                    _avarageLengthGameLabel = value;
                    RaisePropertyChanged(() => AvarageLengthGameLabel);
                }
            }
        }
        public string OutputLabel
        {
            get
            {
                return _outputLabel;
            }
            set
            {
                if (_outputLabel != value)
                {
                    _outputLabel = value;
                    RaisePropertyChanged(() => OutputLabel);
                }
            }
        }
    }
}
