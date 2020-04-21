using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace SFF.Datasource.Model
{
    public class IEntity
    {

        [Key]
        public int Id { get; set; }
    }
}
