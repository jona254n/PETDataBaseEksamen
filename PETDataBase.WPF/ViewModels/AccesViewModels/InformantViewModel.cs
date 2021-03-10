using System;
using System.Windows;
using System.Collections.Generic;
using System.Text;
using PETDataBase.WPF.Views;

namespace PETDataBase.WPF.ViewModels
{
    public class InformantViewModel : PublicViewModel
    {
        public InformantViewModel() : base()
        {
            ReportVisibility = Visibility.Visible;
            GroupVisibility = Visibility.Visible;
            ObservantView = new ObservantView(new FullAccesObservantViewModel());
        }
    }
}
