using System;
using System.Collections.Generic;
using System.Text;

namespace PETDataBase.Domain.Models
{
    public class Comment : DomainObject
    {
        #region Properties

        public string Body { get; set; }

        public Agent Author { get; set; }

        public DateTime LastEdit { get; set; }
        #endregion
    }
}
