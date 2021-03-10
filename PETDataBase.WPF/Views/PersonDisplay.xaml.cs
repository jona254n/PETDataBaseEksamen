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
    /// Interaction logic for PersonDisplay.xaml
    /// <para>
    /// Usercontrol for displaying a person
    /// </para>
    /// </summary>
    public partial class PersonDisplay : UserControl
    {
        public PersonDisplayViewModel DisplayModel { get; set; }
        public PersonDisplay(PersonDisplayViewModel viewModel)
        {
            InitializeComponent();
            DisplayModel = viewModel;
            DataContext = DisplayModel;
        }
    }
}
