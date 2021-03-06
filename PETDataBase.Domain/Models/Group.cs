using System;
using System.Collections.Generic;
using System.Text;


namespace PETDataBase.Domain.Models
{
    public class Group : Subject
    {
        #region Properties
        public string GroupName { get; set; }
        public List<Observant> Members { get; set; }
        #endregion
    }
}
