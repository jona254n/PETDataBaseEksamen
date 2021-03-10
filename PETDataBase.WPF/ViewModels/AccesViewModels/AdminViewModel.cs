using System;
using System.Windows;
using System.Collections.Generic;
using System.Text;

namespace PETDataBase.WPF.ViewModels
{
    public class AdminViewModel : AgentViewModel
    {
        public AdminViewModel() : base()
        {
            AgentVisibility = Visibility.Visible;
        }
    }
}
