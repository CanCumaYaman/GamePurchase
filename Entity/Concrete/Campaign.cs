

using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Concrete
{
    public class Campaign:IEntity
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public  DateTime StartingDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
