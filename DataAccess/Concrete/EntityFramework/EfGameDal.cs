using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfGameDal : EfEntityRepositoryBase<Game, GamePurchaseContext>, IGameDal
    {

        public void SellGame(Game game, Gamer gamer, Campaign campaign)
        {
            using(GamePurchaseContext context=new GamePurchaseContext())
            {
                var soldGame = context.Entry(game);

            }
        }
    }
}
