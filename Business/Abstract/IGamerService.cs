using Core.Utilities;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IGamerService
    {
        IResult Add(Gamer gamer);
        IResult Delete(Gamer gamer);
        IResult Update(Gamer gamer);
        IDataResult<List<Gamer>> GetAll();
    }
}
