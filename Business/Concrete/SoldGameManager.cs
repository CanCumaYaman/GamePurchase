using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SoldGameManager : ISoldGameService
    {
        ISoldGameDal _soldGameDal;
        public SoldGameManager(ISoldGameDal soldGameDal)
        {
            _soldGameDal = soldGameDal;
        }
        public void Add(SoldGame soldGame)
        {

            if (soldGame.CampaignEndDate < DateTime.Now)
            {
                Console.WriteLine("This campaign has expired");
            }
            else
            {
                _soldGameDal.Add(soldGame);
                Console.WriteLine(soldGame.GameName + " has been sold to " + soldGame.GamerName + " " + soldGame.GamerLastName + " at " + soldGame.SoldDate);
            }
           
        }

        public void Delete(SoldGame soldGame)
        {
            _soldGameDal.Delete(soldGame);
            Console.WriteLine(soldGame.GameName+" sold to "+ soldGame.GamerName+" "+soldGame.GamerLastName+" has been deleted");
        }

        public void Update(SoldGame soldGame)
        {
            _soldGameDal.Update(soldGame);
            Console.WriteLine(soldGame.GameName + " sold to " + soldGame.GamerName + " " + soldGame.GamerLastName + " has been updated");
        }
    }
}
