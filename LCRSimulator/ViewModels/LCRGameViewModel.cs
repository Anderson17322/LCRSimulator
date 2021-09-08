using LCRSimulator.Commands;
using LCRSimulator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LCRSimulator.ViewModels
{
    class LCRGameViewModel : ViewModelBase
    {
        InputDataModel _inputDataModel = null;
        OutputDataModel _outputDataModel = null;
        string _runButtonLabel = "";
        string _closeButtonLabel = "";
        public LCRGameViewModel()
        {
            _inputDataModel = new InputDataModel
            {
                NumberGames = 100,
                NumberPlayers = 3,
                InputHeader = "Input Data",
                NumPlayersLabel = "Number of Players",
                NumGamesLabel = "Number of Games"
            };
            _outputDataModel = new OutputDataModel
            {
                AvarageLengthGame=0,
                LongestLengthGame=0,
                ShortestLengthGame=0
            };
            _runButtonLabel = "Run";
            _closeButtonLabel = "Close";
        }
        public OutputDataModel OutputDataModel
        {
            get
            {
                return _outputDataModel;
            }
            set
            {
                if (_outputDataModel != value)
                {
                    _outputDataModel = value;
                    RaisePropertyChanged(() => OutputDataModel);
                }
            }
        }
        public InputDataModel InputDataModel
        {
            get
            {
                return _inputDataModel;
            }
            set
            {
                if (_inputDataModel != value)
                {
                    _inputDataModel = value;
                    RaisePropertyChanged(() => InputDataModel);
                }
            }
        }
        public string RunButtonLabel
        {
            get
            {
                return _runButtonLabel;
            }
            set
            {
                if (_runButtonLabel != value)
                {
                    _runButtonLabel = value;
                    RaisePropertyChanged(() => RunButtonLabel);
                }
            }
        }
        public string CloseButtonLabel
        {
            get
            {
                return _closeButtonLabel;
            }
            set
            {
                if (_closeButtonLabel != value)
                {
                    _closeButtonLabel = value;
                    RaisePropertyChanged(() => CloseButtonLabel);
                }
            }
        }
        public ICommand CloseCommand
        {
            get
            {
                return new DelegatingCommand(o => Close((Window)o));
            }
        }
        
        void Close(Window w)
        {
            if (w != null)
                w.Close();
        }

        public ICommand RunCommand
        {
            get
            {
                return new DelegatingCommand(o => RunSimulator());
            }
        }
        SimulatorModel _Simulator = null;
        void RunSimulator()
        {
             _Simulator = new SimulatorModel(_inputDataModel.NumberPlayers, _inputDataModel.NumberGames);
            if(!_Simulator.ValidateInput())
            {
                MessageBox.Show("Invalid Input");
            }
            if(_Simulator.RunSimulator())
            {
                OutputDataModel = _Simulator.GetOutputData();
            }
        }
    }
}
