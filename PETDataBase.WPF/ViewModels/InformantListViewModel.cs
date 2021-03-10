using PETDataBase.Domain.Models;
using PETDataBase.WPF.Views;
using PETDataBase.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PETDataBase.WPF.ViewModels
{
    public class InformantListViewModel : ViewModelBase
    {
        protected Repository.Repository repo;
        public InformantListViewModel()
        {
            repo = new Repository.Repository();

            Update();
        }
        #region Fields
        private Informant _selectedInformant;
        
        #endregion
        #region Properties

       

        public ObservableCollection<Informant> Informants { get; set; }

        public Informant SelectedInformant
        {
            get => _selectedInformant;
            set
            {
                _selectedInformant = value;

                PersonDisplay = new PersonDisplay(new PersonDisplayViewModel(false, value));

                OnPropertyChanged("PersonDisplay");
                OnPropertyChanged("SelectedInformant");
            }
        }

        public PersonDisplay PersonDisplay { get; set; }
        #endregion
        #region Methods

        /// <summary>
        /// Updates <see cref="Informants"/>
        /// </summary>
        public void Update()
        {
            Informants = new ObservableCollection<Informant>(new List<Informant>(repo.GetAll<Informant>()).FindAll((i)=>i.GetType()==typeof(Informant)));
            OnPropertyChanged("Informants");
        }

        #endregion
        #region Methods
        public void Add()
        {
            repo.Add((Informant)PersonDisplay.DisplayModel.Person);
            Update();
            SelectedInformant = Informants[Informants.Count - 1];
        }

        public void Delete()
        {
            repo.Delete((Informant)PersonDisplay.DisplayModel.Person);
            Update();
        }

        public void Edit()
        {
            repo.Edit((Informant)PersonDisplay.DisplayModel.Person);
            Update();
        }

        public void New()
        {

            SelectedInformant = new Informant();
            Update();
        }
        #endregion
    }
}
