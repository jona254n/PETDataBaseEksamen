using PETDataBase.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PETDataBase.WPF.Views
{
    /// <summary>
    /// Interaction logic for ReportView.xaml
    /// </summary>
    public partial class ReportView : UserControl
    {
        public ReportViewModel ViewModel { get; set; }
        public ReportView(ReportViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;
            DataContext = ViewModel;
        }
        private void Ny_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.New();
        }

        private void Gem_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.Add();
        }

        private void Rediger_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.Edit();
        }

        private void Slet_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.Delete();
        }
    }
}
