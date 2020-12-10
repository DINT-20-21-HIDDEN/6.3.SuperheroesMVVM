using System.Windows;
using System.Windows.Input;

namespace SuperheroesMVVM
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowVM _vistamodelo;

        public MainWindow()
        {
            InitializeComponent();

            _vistamodelo = new MainWindowVM();
            this.DataContext = _vistamodelo;
        }

        private void AddCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            _vistamodelo.Añadir();
            MessageBox.Show("Superheroe añadido con éxito", "Superhéroes", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ClearCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            _vistamodelo.Reiniciar();
        }

        private void PreviousCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            _vistamodelo.Anterior();
        }

        private void NextCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            _vistamodelo.Siguiente();
        }
    }
}
