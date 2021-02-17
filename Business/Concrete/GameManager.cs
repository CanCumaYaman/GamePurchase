using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class GameManager : IGameService
    {
        IGameDal _gameDal;
        public GameManager(IGameDal gameDal)
        {
            _gameDal = gameDal;
        }
        public void Add(Game game)
        {
            _gameDal.Add(game);
            Console.WriteLine(game.Name+" added successfully");
        }

        public void Delete(Game game)
        {
            _gameDal.Delete(game);
            Console.WriteLine(game.Name + " deleted successfully");
        }

        public List<Game> GetAll()
        {
            return _gameDal.GetAll();
        }

        public void SellGame(Game game, Gamer gamer, Campaign campaign)
        {
            _gameDal.SellGame(game, gamer, campaign);
        }

        public void Update(Game game)
        {
            _gameDal.Update(game);
            Console.WriteLine(game.Name + " updated successfully");
        }
    }
}
