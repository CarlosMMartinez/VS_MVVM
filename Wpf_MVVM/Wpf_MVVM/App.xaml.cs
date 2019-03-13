using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Wpf_MVVM.Connectors;

namespace Wpf_MVVM
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
    //Para no tener que listar en los distintos tipos de viewModels creamos 
    // en al App este método y así no disponemos de código repetido.
        private static DbConnector _dbConnector = new DbConnector();

        public static DbConnector DbConnector { get => _dbConnector;  }

        
    }   
}
