using PETDataBase.Domain.Models;
using PETDataBase.WPF.Views;
using PETDataBase.Repository;
using System;
using System.Windows;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PETDataBase.WPF.ViewModels
{
    public class ObservantViewModel : ViewModelBase
    {
        protected Repository.Repository repo;
        public ObservantViewModel()
        {
            repo = new Repository.Repository();

            Update();
        }
        #region Fields
        private Observant _selectedObservant;
        private Report _selectedReport;
        #endregion
        #region Properties
        public Visibility ButtonVisibility { get; set; } = Visibility.Hidden;
        public bool IsReadOnly { get; protected set; } = true;

        public Report SelectedReport
        {
            get => _selectedReport;
            set
            {
                _selectedReport = value;
                OnPropertyChanged("SelectedReport");
            }
        }

        public ObservableCollection<Observant> Observants { get; set; }

        public Observant SelectedObservant
        {
            get => _selectedObservant;
            set
            {
                _selectedObservant = value;

                PersonDisplay = new PersonDisplay(new PersonDisplayViewModel(IsReadOnly, value));

                OnPropertyChanged("PersonDisplay");
                OnPropertyChanged("SelectedObservant");
            }
        }
        
        public PersonDisplay PersonDisplay { get; set; }
        #endregion
        #region Methods

        /// <summary>
        /// Updates <see cref="Observants"/>
        /// </summary>
        public void Update()
        {
            Observants = new ObservableCollection<Observant>(repo.GetAll<Observant>());
            OnPropertyChanged("Observants");
        }

        #endregion
        #region Virtual Methods
        public virtual void Add() { }
        public virtual void Delete() { }
        public virtual void Edit() { }
        public virtual void New() { }
        #endregion
    }
    public class FullAccesObservantViewModel : ObservantViewModel
    {
        public FullAccesObservantViewModel()
        {
            IsReadOnly = false;
            ButtonVisibility = Visibility.Visible;
        }
        #region Overrides
        public override void Add()
        {
            repo.Add((Observant)PersonDisplay.DisplayModel.Person);
            Update();
            SelectedObservant = Observants[Observants.Count-1];
        }

        public override void Delete()
        {
            repo.Delete((Observant)PersonDisplay.DisplayModel.Person);
            Update();
        }

        public override void Edit()
        {
            repo.Edit((Observant)PersonDisplay.DisplayModel.Person);
            Update();
        }

        public override void New()
        {

            SelectedObservant = new Observant();
            Update();
        }
        #endregion
    }
}
