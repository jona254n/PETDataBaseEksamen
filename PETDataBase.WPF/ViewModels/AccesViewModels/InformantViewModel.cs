using System;
using System.Windows;
using System.Collections.Generic;
using System.Text;
using PETDataBase.WPF.Views;
using PETDataBase.Domain.Models;

namespace PETDataBase.WPF.ViewModels
{
    public class InformantViewModel : PublicViewModel
    {
        public InformantViewModel(Informant user) : base()
        {
            ReportVisibility = Visibility.Visible;
            GroupVisibility = Visibility.Visible;
            ObservantView = new ObservantView(new FullAccesObservantViewModel());
            ReportView = new ReportView(new ReportViewModel(user));
        }

        #region Views
        public ReportView ReportView { get; set; }
        #endregion
    }
}
