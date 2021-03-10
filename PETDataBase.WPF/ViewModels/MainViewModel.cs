﻿using System;
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
        
        public string UserName { get; set; }
        public string Password { get; set; }

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

        public void TryLogIn(LoginWindow sender)
        {
            
            Informant result = Employees.Find((e) => e.Login(UserName, Password));

            if(result != CurrentUser)
                CurrentUser = result;
            
            if(result == null)
                MessageBox.Show("Forkert adgangskode eller brugernavn");

            sender.Close();
        }
        #endregion
    }
}
