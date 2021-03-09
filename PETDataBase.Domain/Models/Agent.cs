using System;
using System.Collections.Generic;
using System.Text;

namespace PETDataBase.Domain.Models
{
    public class Agent : Informant
    {
        public Agent(string userName, string password) : base(userName, password)
        {
        }
    }
}
