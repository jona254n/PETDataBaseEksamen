using PETDataBase.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;


namespace PETDataBase.Domain.Models
{
    public class Group : DomainObject, IObservant
    {
        #region Properties
        public string GroupName { get; set; }
        public List<Observant> Members { get; set; }
        #endregion
    }
}
