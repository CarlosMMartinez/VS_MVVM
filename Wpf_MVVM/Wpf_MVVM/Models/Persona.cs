using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_MVVM.Models
{
    public class Persona
    {
        public class PersonaCollection : ObservableCollection<Persona>
        {
            //No hace falta declarar nada mas, es simplemente para tener una lista de peronas para ocupar un listbox
        }

        //propfull tab tab
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private DateTime _fechaNac;

        public DateTime FechaNac
        {
            get { return _fechaNac; }
            set { _fechaNac = value; }
        }

        public Persona()
        {

        }

        public Persona(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        //Sobreescribimos el metodo ToString
        public override string ToString()
        {
            return Nombre;
        }


    }
}
