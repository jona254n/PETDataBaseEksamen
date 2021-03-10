using PETDataBase.Domain.Models;
using PETDataBase.WPF.Views;
using PETDataBase.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PETDataBase.WPF.ViewModels
{
    public class ObservantViewModel : ViewModelBase
    {
        private Repository.Repository repo;
        public ObservantViewModel()
        {
            repo = new Repository.Repository();
            Observant ob = new Observant()
            {
                FullName = "testperson1",
                HairColor = "Brown",
                EyeColor = "Brown",
                Height = 1.83f,
                SkinColor = "White"
            };
            //repo.Add(ob);
            Update();
        }
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
                    OnPropertyChanged("PersonDisplay");
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
        #region Methods

        /// <summary>
        /// Updates <see cref="Observants"/>
        /// </summary>
        public void Update()
        {
            Observants = new ObservableCollection<Observant>(repo.GetAll<Observant>());
            //OnPropertyChanged("Observants");
        }

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
