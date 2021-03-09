using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PETDataBase.Domain.Models
{
    public class Person : DomainObject
    {
        #region Properties

        // Base info

        public string FullName { get; set; }
        public string Adress { get; set; }
        public List<Keyword> KeyWords { get; set; }


        // Apperance

        public float Height { get; set; }
        public string EyeColor { get; set; }
        public string HairColor { get; set; }
        public string SkinColor { get; set; }
        public string Ethnicity { get; set; }
        public Nationality Nationality { get; set; }
        public byte[] Photo { get; set; }



        #endregion
    }
}
