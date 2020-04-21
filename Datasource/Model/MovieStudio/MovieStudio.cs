using System;
using System.Collections.Generic;
using System.Text;

namespace SFF.Datasource.Model
{
    public class MovieStudio : IEntity
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
    }
}
