using System;
using System.Collections.Generic;
using System.Text;

namespace PETDataBase.Domain.Models
{
    public class Informant : Person
    {
        public Informant(string @UserName, string @Password)
        {
        }
        #region Properties
        public PaymentMethod PaymentMethod { get; set; }
        public Currency Currency { get; set; }
        private string UserName { get; set; }
        private string Password { get; set; }
        #endregion
    }
}
