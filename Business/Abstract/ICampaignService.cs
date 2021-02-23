using Core.Utilities;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICampaignService
    {
        IResult Add(Campaign campaign);
        IResult Delete(Campaign campaign);
        IResult Update(Campaign campaign);
        IDataResult<List<Campaign>> GetAll();
    }
}
