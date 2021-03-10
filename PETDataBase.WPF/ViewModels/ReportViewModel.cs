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
            UpdateReports();
            UpdateObservants();
        }
        #region Fields
        private Report _selectedReport;
        #endregion
        #region Properties

        public Visibility CommentVisibility { get; protected set; } = Visibility.Hidden;

        public ObservableCollection<Observant> Observants { get; set; }

        public Observant SelectedObservant
        {
            get
            {
                if(SelectedReport != null)
                {
                    return SelectedReport.Subject.Observant;
                }
                else
                {
                    return null;
                }
                
            }
            set
            {
                if(SelectedReport == null)
                {
                    SelectedReport = new Report();
                }

                SelectedReport.Subject = new Subject() { Observant = value };
                
                OnPropertyChanged("SelectedObservant");
            }
        }

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
        public void UpdateObservants()
        {
            Observants = new ObservableCollection<Observant>(repo.GetAll<Observant>());
            OnPropertyChanged("Observants");
        }
        public void UpdateReports()
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
            //Sets Author of report
            SelectedReport.Author = CurrentUser;

            //Sets DateSubmitted to current time
            SelectedReport.DateSubmitted = DateTime.Now;

            //Sets SelectedObservants list if it is null
            if(SelectedObservant.Reports == null)
            {
                SelectedObservant.Reports = new List<Report>();
            }

            //Adds SelectedReport to SelectedObservants reports
            SelectedObservant.Reports.Add(SelectedReport);

            repo.Edit(SelectedObservant);
            UpdateReports();
            SelectedReport = Reports[Reports.Count - 1];
        }
        public void Delete()
        {
            repo.Delete(SelectedReport);
            UpdateReports();
            SelectedReport = new Report();
        }
        public void Edit()
        {
            repo.Edit(SelectedReport);
            UpdateReports();
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
