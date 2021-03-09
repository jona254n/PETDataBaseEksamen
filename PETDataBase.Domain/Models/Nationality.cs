using System;
using System.Collections.Generic;
using System.Text;

namespace PETDataBase.Domain.Models
{
    public class Nationality : DomainObject
    {
        #region Properties
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string NationalityName { get; set; }
        #endregion
    }
}
