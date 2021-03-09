using System;
using System.Collections.Generic;
using System.Text;

namespace PETDataBase.Domain.Models
{
    public class Keyword : DomainObject
    {
        public string KeyWord { get; set; }
        public override string ToString()
        => KeyWord;
    }
}
