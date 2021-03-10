using System;
using System.Windows;
using System.Collections.Generic;
using System.Text;
using PETDataBase.Domain.Models;

namespace PETDataBase.WPF.ViewModels
{
    public class AdminViewModel : AgentViewModel
    {
        public AdminViewModel(Admin user) : base(user)
        {
            AgentVisibility = Visibility.Visible;
        }
    }
}
