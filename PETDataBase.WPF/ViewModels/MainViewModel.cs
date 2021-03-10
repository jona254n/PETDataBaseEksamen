using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using PETDataBase.Domain.Models;
using PETDataBase.WPF.Models;
using PETDataBase.WPF.Views;
using PETDataBase.WPF.Views.Windows;

namespace PETDataBase.WPF.ViewModels
{
    public class MainViewModel : ObservableObject 
    {
        private Repository.Repository repo;
        public MainViewModel()
        {
            repo = new Repository.Repository();
            Update();
        }

        #region Fields
        /// <summary>
        /// Private field for <see cref="CurrentUser"/>
        /// </summary>
        private Informant _currentUser;
        #endregion

        #region Properties
        private List<Informant> Employees { get; set; }

        /// <summary>
        /// Property for current user
        /// <para>
        /// Value is null if no one is logged in</para>
        /// </summary>
        public Informant CurrentUser 
        {
            get => _currentUser;
            set
            {
                _currentUser = value;
                OnPropertyChanged("CurrentViewModel");
            }
        }
        /// <summary>
        /// Returns ViewModel depending on <see cref="CurrentUser"/>
        /// </summary>
        public PublicViewModel CurrentViewModel
        {
            get
            {
                if(CurrentUser != null)
                {
                    switch(CurrentUser)
                    {
                        case Admin a:
                            return new AdminViewModel();
                        case Agent ag:
                            return new AgentViewModel();
                        case Informant i:
                            return new InformantViewModel();
                    }
                }
                return new PublicViewModel();

            }
        }

        public string UserName { get; set; } = "";
        public string Password { get; set; } = "";

        #endregion
        #region Methods

        /// <summary>
        /// Opens Login window
        /// </summary>
        public void OpenLoginWindow()
        {
            LoginWindow login = new LoginWindow(this);

            login.Show();
        }

        /// <summary>
        /// Tries to log in
        /// </summary>
        /// <param name="sender">
        /// The Login Window the call came from
        /// </param>
        public void TryLogIn(LoginWindow sender)
        {
            
            Informant result = Employees.Find((e) => e.Login(UserName, Password));

            if(result != CurrentUser)
                CurrentUser = result;
            
            if(result == null)
                MessageBox.Show("Forkert adgangskode eller brugernavn");

            sender.Close();
        }
        /// <summary>
        /// Updates <see cref="Employees"/>
        /// </summary>
        public void Update()
        {
            Employees = new List<Informant>(repo.GetAll<Informant>());
            Employees.AddRange(repo.GetAll<Agent>());
            Employees.AddRange(repo.GetAll<Admin>());
        }

        #endregion
    }
}
