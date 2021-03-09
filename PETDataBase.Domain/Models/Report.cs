using PETDataBase.Domain.Interfaces;
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

        
        public IObservant Subject { get; set; }
        public List<Comment> Comments { get; set; }
        #endregion
    }
}
