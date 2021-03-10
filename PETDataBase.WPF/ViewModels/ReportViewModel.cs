using PETDataBase.Domain.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;

namespace PETDataBase.WPF.ViewModels
{
    public class ReportViewModel : ViewModelBase
    {
        private Repository.Repository repo;
        public ReportViewModel(Informant User)
        {
            CurrentUser = User;
            repo = new Repository.Repository();
            Update();
        }
        #region Fields
        private Report _selectedReport;
        #endregion
        #region Properties

        public Visibility CommentVisibility { get; protected set; } = Visibility.Hidden;


        public ObservableCollection<Report> Reports { get; set; }

        public Report SelectedReport
        {
            get => _selectedReport;
            set
            {
                _selectedReport = value;
                OnPropertyChanged("SelectedReport");
            }
        }

        public Informant CurrentUser { get; set; }

        #endregion

        #region Methods
        public void Update()
        {
            Reports = new ObservableCollection<Report>(repo.GetAll<Report>());
            OnPropertyChanged("Reports");
        }
        public void New()
        {
            SelectedReport = new Report();
        }
        public void Add()
        {
            repo.Add(SelectedReport);
            Update();
            SelectedReport = Reports[Reports.Count - 1];
        }
        public void Delete()
        {
            repo.Delete(SelectedReport);
            Update();
            SelectedReport = new Report();
        }
        public void Edit()
        {
            repo.Edit(SelectedReport);
            Update();
        }
        #endregion
    }
    public class FullAccesReportViewModel : ReportViewModel
    {
        public FullAccesReportViewModel(Informant User) : base(User)
        {
            CommentVisibility = Visibility.Visible;
        }
    }
}
