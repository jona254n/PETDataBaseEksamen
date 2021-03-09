using System;
using System.Collections.Generic;
using System.Text;

namespace PETDataBase.Domain.Models
{
    public class Report : DomainObject
    {
        #region Properties
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime DateSubmitted { get; set; }

        public Informant Author { get; set; }

        //To be replaced 
        public object Subject { get; set; }
        //To be replaced
        public List<object> Comments { get; set; }
        #endregion
    }
}
