using PETDataBase.WPF.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace PETDataBase.WPF.ViewModels
{
    public class PublicViewModel : ViewModelBase
    {
        public PublicViewModel()
        {
            ObservantView = new ObservantView();

        }
        #region Views
        public ObservantView ObservantView { get; set; }
        #endregion


        #region Tab Visibility

        public Visibility GroupVisibility { get; protected set; } = Visibility.Hidden;
        public Visibility ReportVisibility { get; protected set; } = Visibility.Hidden;

        public Visibility InformantVisibility { get; protected set; } = Visibility.Hidden;

        public Visibility AgentVisibility { get; protected set; } = Visibility.Hidden;
        #endregion
    }
}
