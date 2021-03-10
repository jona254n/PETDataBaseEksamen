using System;
using System.Windows;
using System.Collections.Generic;
using System.Text;
using PETDataBase.Domain.Models;
using PETDataBase.WPF.Views;

namespace PETDataBase.WPF.ViewModels
{
    public class AgentViewModel : InformantViewModel
    {
        public AgentViewModel(Agent user) : base(user)
        {
            InformantVisibility = Visibility.Visible;
            ReportView = new ReportView(new FullAccesReportViewModel(user));
            InformantView = new InformantView();
        }
        #region Views
        public InformantView InformantView 
        { get; set; }
        #endregion
    }
}
