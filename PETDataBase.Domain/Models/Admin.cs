using System;
using System.Collections.Generic;
using System.Text;

namespace PETDataBase.Domain.Models
{
    public class Admin : Agent
    {
        public Admin(string userName, string password) : base(userName, password)
        {
        }
    }
}
