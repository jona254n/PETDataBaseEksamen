using System;
using System.Collections.Generic;
using System.Text;

namespace PETDataBase.Domain.Models
{
    public class PaymentMethod : DomainObject
    {
        #region Properties
        public string PaymentDescription { get; set; }
        #endregion
    }
}
