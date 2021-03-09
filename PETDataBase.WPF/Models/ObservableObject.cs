using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PETDataBase.WPF.Models
{
    /// <summary>
    /// Implements INotifyPropertyChanged
    /// </summary>
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Notifies that <paramref name="propname"/> has changed
        /// </summary>
        /// <param name="propname">
        /// Updates databindings with this propname
        /// </param>
        protected void OnPropertyChanged(string propname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propname));
        }
    }
}
