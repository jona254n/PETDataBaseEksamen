using System;
using System.Collections.Generic;
using System.Text;

namespace PETDataBase.Domain.Models
{
    public class Observant : Person
    {
        public List<Report> Reports { get; set; }
    }
}
