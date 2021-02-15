using Core.DataAccess;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IGameDal:IEntityRepository<Game>
    {
        void SellGame(Game game, Gamer gamer, Campaign campaign);
    }
}
