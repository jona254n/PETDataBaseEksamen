using System;
using System.Collections.Generic;
using System.Text;

namespace PETDataBase.Domain.Models
{
    public class Informant : Person
    {
        public Informant(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
        #region Properties
        public string PaymentMethod { get; set; }
        public string Currency { get; set; }
        private string UserName { get; set; }
        private string Password { get; set; }
        #endregion
    }
}
