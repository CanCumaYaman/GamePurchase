using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
        void SellGame(Game game, Gamer gamer, Campaign campaign);
    }
}
