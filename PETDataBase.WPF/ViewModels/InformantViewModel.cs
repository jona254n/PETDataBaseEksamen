using System;
using System.Windows;
using System.Collections.Generic;
using System.Text;

namespace PETDataBase.WPF.ViewModels
{
    public class InformantViewModel : PublicViewModel
    {
        public InformantViewModel() : base()
        {
            ReportVisibility = Visibility.Visible;
            GroupVisibility = Visibility.Visible;
        }
    }
}
