using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using Core.Utilities;
using DataAccess.Abstract;
using Entity.Concrete;
using FluentValidation;
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
        [ValidationAspect(typeof(GameValidator))]
        public IResult Add(Game game)
        {
           
          
            _gameDal.Add(game);
            return new SuccessResult();
        }

        public IResult Delete(Game game)
        {
            _gameDal.Delete(game);
            return new SuccessResult();
        }

        public  IDataResult<List<Game>> GetAll()
        {
            return new SuccessDataResult<List<Game>>(_gameDal.GetAll());
        }

        public IResult SellGame(Game game, Gamer gamer, Campaign campaign)
        {
            _gameDal.SellGame(game, gamer, campaign);
            return new SuccessResult();
        }

        [ValidationAspect(typeof(GameValidator))]
        public IResult Update(Game game)
        {
            _gameDal.Update(game);
            return new SuccessResult();
        }
    }
}
