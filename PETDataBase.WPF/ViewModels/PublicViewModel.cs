using PETDataBase.WPF.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace PETDataBase.WPF.ViewModels
{
    public class PublicViewModel : ViewModelBase
    {
        public PublicViewModel()
        {
            ObservantView = new ObservantView();
        }
        #region Views
        public ObservantView ObservantView { get; set; }
        #endregion
    }
}
