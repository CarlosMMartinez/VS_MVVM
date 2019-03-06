using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_MVVM.Models;
using static Wpf_MVVM.Models.Persona;

namespace Wpf_MVVM.Connectors
{
    public class DbConnector
    {
        public PersonaCollection listarPersonas()
        {
            PersonaCollection lista = new PersonaCollection();
            lista.Add(new Persona(1, "Juan"));
            lista.Add(new Persona(2, "Luis"));
            lista.Add(new Persona(3, "Pedro"));
            lista.Add(new Persona(4, "Raul"));
            return lista;
        }
    }
}
