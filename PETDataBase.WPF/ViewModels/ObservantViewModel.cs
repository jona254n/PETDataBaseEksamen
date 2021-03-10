using PETDataBase.Domain.Models;
using PETDataBase.WPF.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PETDataBase.WPF.ViewModels
{
    public class ObservantViewModel : ViewModelBase
    {

        #region Fields
        private Observant _selectedObservant;
        #endregion
        #region Properties
        public bool IsReadOnly { get; protected set; } = true;

        public ObservableCollection<Observant> Observants { get; set; }

        public Observant SelectedObservant
        {
            get => _selectedObservant;
            set
            {
                _selectedObservant = value;
                if(PersonDisplay == null)
                {
                    PersonDisplay = new PersonDisplay(new PersonDisplayViewModel(IsReadOnly, value));
                }
                else
                {
                    PersonDisplay.DisplayModel = new PersonDisplayViewModel(IsReadOnly, value);
                    OnPropertyChanged("DisplayModel");
                }
            }
        }
        
        public PersonDisplay PersonDisplay { get; set; }
        #endregion
        #region Virtual Methods
        public virtual void Add() { }
        public virtual void Delete() { }
        #endregion
    }
    public class FullAccesObservantViewModel : ObservantViewModel
    {
        public FullAccesObservantViewModel()
        {
            IsReadOnly = false;
        }
    }
}
