using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //GameOperations();
            //GamerOperations();
            //CampaignOperations();
            SoldGameOperatons();
        }

        private static void SoldGameOperatons()
        {
            SoldGameManager soldGameManager = new SoldGameManager(new EfSoldGameDal());
            soldGameManager.Add(new SoldGame { GameName = "PUBG", GamerName = "Can Cuma", GamerLastName = "YAMAN", GamerIdentityNumber = "11683333333", CampaignName = "Teacher", CampaignEndDate=new DateTime(2022,04,04), SoldDate = new DateTime(2021, 02, 06) });
        }

        private static void CampaignOperations()
        {
            CampaignManager campaignManager = new CampaignManager(new EfCampaignDal());
            campaignManager.Add(new Campaign { Name = "Teacher", StartingDate = new DateTime(2018, 01, 01), EndDate = new DateTime(2022, 04, 04) });
        }

        private static void GamerOperations()
        {
            GamerManager gamerManager = new GamerManager(new EfGamerDal());
            gamerManager.Add(new Gamer { Name = "Can Cuma", LastName = "YAMAN", Dob = new DateTime(1998, 07, 16), IdentityNumber = "11683333333" });
        }

        private static void GameOperations()
        {
            GameManager gameManager = new GameManager(new EfGameDal());
            gameManager.Add(new Game { Name = "PUBG", Price = 300 });
        }
    }
}
