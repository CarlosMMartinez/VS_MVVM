using System;
using System.Windows.Input;
using Wpf_MVVM.Core.Commands;
using Wpf_MVVM.Models;
using static Wpf_MVVM.Models.Persona;

namespace Wpf_MVVM.ViewModels
{
    //Con iGeneric damos acceso a la implementacion del propertyChange

    public class PersonaViewModel : IGeneric
    {
        private PersonaCollection _listaPersonas = new PersonaCollection();

        public PersonaCollection ListaPersonas
        {
            get { return _listaPersonas; }

            set
            {
                _listaPersonas = value;
                RaisePropertyChange("ListaPersonas");
            }
        }
        
        //Prop para la seleccion de persona
        private Persona _currentPersona;

        public Persona CurrentPersona
        {
            get {return _currentPersona; }
            set
            {
                _currentPersona = value;
                RaisePropertyChange("CurrentPersona");
            }

        }
        
        //Reemplazamos el evento click con el Command, evitando crear code behind
        private ICommand _listarPersonasCommand;

        public ICommand ListarPersonasCommand
        {

            get
            {
                if (_listarPersonasCommand == null)
                    _listarPersonasCommand = new RelayCommand(new Action(ListarPersonas));
                return _listarPersonasCommand;
            }

        }
        //Metodo mandado por el command hacia la view
        private void ListarPersonas()
        {
            ListaPersonas = App.DbConnector.listarPersonas();

        }

        //ctor tab tab
        public PersonaViewModel()
        {

        }
    }
}
