using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Concrete
{
   public class Gamer:IEntity
    {
      
        public int Id { get; set; }
        public string IdentityNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
    }
}
