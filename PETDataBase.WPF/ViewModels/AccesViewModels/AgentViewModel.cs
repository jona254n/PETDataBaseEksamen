using System;
using System.Windows;
using System.Collections.Generic;
using System.Text;

namespace PETDataBase.WPF.ViewModels
{
    public class AgentViewModel : InformantViewModel
    {
        public AgentViewModel() : base()
        {
            InformantVisibility = Visibility.Visible;
        }
    }
}
