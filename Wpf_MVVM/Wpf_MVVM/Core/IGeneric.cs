using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_MVVM
{
    public class IGeneric : IEnlace
    {
        #region Aqui implementamos en prpertychange

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChange(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));

        }

        #endregion


    }
}
