using Core.Utilities;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IGameService
    {
        IResult Add(Game game);
        IResult Delete(Game game);
        IResult Update(Game game);
        IDataResult<List<Game>> GetAll();
    }
}
