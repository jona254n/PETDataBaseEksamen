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
        protected Repository.Repository repo;
        public ObservantViewModel()
        {
            repo = new Repository.Repository();
            //Admin admin = new Admin()
            //{
            //    FullName = "Admin",
            //    UserName = "admin",
            //    Password = ""
            //};
            //repo.Add(admin);
            //Agent agent = new Agent()
            //{
            //    FullName = "Agent",
            //    UserName = "agent",
            //    Password = ""
            //};
            //repo.Add(agent);
            //Informant informant = new Informant()
            //{
            //    FullName = "Informant",
            //    UserName = "informant",
            //    Password = ""
            //};
            //repo.Add(informant);
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
        public virtual void Edit() { }
        public virtual void New() { }
        #endregion
    }
    public class FullAccesObservantViewModel : ObservantViewModel
    {
        public FullAccesObservantViewModel()
        {
            IsReadOnly = false;
        }
        #region Overrides
        public override void Add()
        {
            repo.Add((Observant)PersonDisplay.DisplayModel.Person);
        }

        public override void Delete()
        {
            repo.Delete((Observant)PersonDisplay.DisplayModel.Person);
        }

        public override void Edit()
        {
            repo.Edit((Observant)PersonDisplay.DisplayModel.Person);
        }

        public override void New()
        {
            PersonDisplay.DisplayModel.Person = new Observant();
        }
        #endregion
    }
}
