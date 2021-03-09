using System;
using System.Collections.Generic;
using System.Text;

namespace PETDataBase.Domain.Models
{
    public class Admin : Agent
    {
        public Admin(string UserName, string Password) : base(UserName, Password)
        {
        }
    }
}
