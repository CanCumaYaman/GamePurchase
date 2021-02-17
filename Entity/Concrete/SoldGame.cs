using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
   public class SoldGame:IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string GamerName { get; set; }
        public string GamerLastName { get; set; }
        public string GamerIdentityNumber { get; set; }
        public string CampaignName { get; set; }
        public DateTime? CampaignEndDate { get; set; }
        public DateTime SoldDate { get; set; }
    }
}
