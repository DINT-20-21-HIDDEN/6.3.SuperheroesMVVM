using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SuperheroesMVVM
{
    class MainWindowVM : INotifyPropertyChanged
    {
        public Superheroe NuevoSuperheroe { get; set; }
        public ObservableCollection<Superheroe> ListaSuperheroes { get; set; }
        public int Actual { get; set; }
        public int Total { get; set; }

        public Superheroe SuperheroeActual => ListaSuperheroes[Actual - 1];

        private ServicioSuperheroes _servicio;

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindowVM()
        {
            NuevoSuperheroe = new Superheroe { Heroe = true };

            Actual = 1;

            _servicio = new ServicioSuperheroes();
            ListaSuperheroes = _servicio.GetSamples();
            Total = ListaSuperheroes.Count;
        }

        public void Siguiente()
        {
            if (Actual < Total)
                Actual++;
        }

        public void Anterior()
        {
            if (Actual > 1)
                Actual--;
        }

        public void Añadir()
        {
            ListaSuperheroes.Add(NuevoSuperheroe);
            Total = ListaSuperheroes.Count;
            NuevoSuperheroe = new Superheroe { Heroe = true };
        }

        public void Reiniciar()
        {
            NuevoSuperheroe = new Superheroe { Heroe = true };
        }
    }
}
