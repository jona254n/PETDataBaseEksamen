using System;
using System.Collections.Generic;
using System.Text;
using PETDataBase.Domain.Models;

namespace PETDataBase.WPF.ViewModels
{
    public class PersonDisplayViewModel : ViewModelBase
    {
        public PersonDisplayViewModel(bool isReadOnly, Person person)
        {
            IsReadOnly = isReadOnly;
            Person = person;
        }

        #region Properties
        public bool IsReadOnly { get; set; }
        public Person Person { get; set; }
        #endregion
    }
}
