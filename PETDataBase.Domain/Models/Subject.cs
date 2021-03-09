using System;
using System.Collections.Generic;
using System.Text;

namespace PETDataBase.Domain.Models
{
    public class Subject : DomainObject
    {
        #region Properties
        public Observant Observant { get; set; }
        #endregion
    }
}
