using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using PETDataBase.Domain.Models;
using PETDataBase.WPF.Views;

namespace PETDataBase.WPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        #region Fields
        /// <summary>
        /// Private field for <see cref="CurrentUser"/>
        /// </summary>
        private Informant _currentUser;
        #endregion

        #region Properties
        public Informant CurrentUser 
        {
            get => _currentUser;
            set
            {
                _currentUser = value;
                OnPropertyChanged("CurrentView");
            }
        }
        /// <summary>
        /// Returns View depending on <see cref="CurrentUser"/>
        /// </summary>
        public UserControl CurrentView
        {
            get
            {
                if(CurrentUser != null)
                {
                    switch(CurrentUser)
                    {
                        case Admin a:
                            return new AdminView();
                        case Agent ag:
                            return new AgentView();
                        case Informant i:
                            return new InformantView();
                    }
                }
                return new PublicView();

            }
        }
        #endregion
    }
}
