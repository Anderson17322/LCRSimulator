using LCRSimulator.ViewModels;


namespace LCRSimulator.Models
{
    class InputDataModel : ViewModelBase
    {
        int _numberPlayers { get; set; }
        public int NumberPlayers
        {
            get
            {
                return _numberPlayers;
            }
            set
            {
                if (_numberPlayers != value)
                {
                    _numberPlayers = value;
                    RaisePropertyChanged(() => NumberPlayers);
                }
            }
        }
        int _numberGames { get; set; }
        public int NumberGames
        {
            get
            {
                return _numberGames;
            }
            set
            {
                if (_numberGames != value)
                {
                    _numberGames = value;
                    RaisePropertyChanged(() => NumberGames);
                }
            }
        }

        string _inputHeader { get; set; }
        public string InputHeader
        {
            get
            {
                return _inputHeader;
            }
            set
            {
                if (_inputHeader != value)
                {
                    _inputHeader = value;
                    RaisePropertyChanged(() => InputHeader);
                }
            }
        }
        string _numPlayersLabel { get; set; }
        public string NumPlayersLabel
        {
            get
            {
                return _numPlayersLabel;
            }
            set
            {
                if (_numPlayersLabel != value)
                {
                    _numPlayersLabel = value;
                    RaisePropertyChanged(() => NumPlayersLabel);
                }
            }
        }
        string _numGamesLabel { get; set; }
        public string NumGamesLabel
        {
            get
            {
                return _numGamesLabel;
            }
            set
            {
                if (_numGamesLabel != value)
                {
                    _numGamesLabel = value;
                    RaisePropertyChanged(() => NumGamesLabel);
                }
            }
        }
    }

    
}
