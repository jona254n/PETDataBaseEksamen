using System;
using System.Collections.Generic;
using System.Text;

namespace PETDataBase.Domain.Models
{
    public class Informant : Person
    {
        
        #region Properties
        public PaymentMethod PaymentMethod { get; set; }
        public Currency Currency { get; set; }
        public string UserName { private get; set; }
        public string Password { private get; set; }
        #endregion
    }
}
