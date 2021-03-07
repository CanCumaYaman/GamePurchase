using Core.Utilities;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ISoldGameService
    {
        IResult Add(SoldGame soldGame);
        IResult Delete(SoldGame soldGame);
        IResult Update(SoldGame soldGame);
        IDataResult<List<SoldGame>> GetAll();
        IResult AddTransactionalTest(SoldGame soldGame);
    }
}
