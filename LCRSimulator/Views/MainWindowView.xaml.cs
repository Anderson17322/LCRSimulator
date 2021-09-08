using LCRSimulator.ViewModels;
using System.Windows;


namespace LCRSimulator.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new LCRGameViewModel();
        }
    }
}
