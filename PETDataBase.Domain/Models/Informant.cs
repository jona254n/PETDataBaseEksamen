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
        public string UserName { get; set; }
        public string Password { get; set; }
        #endregion
        #region Methods
        public bool Login(string userName, string password)
        => userName == UserName && password == Password;
        #endregion
    }
}
