using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac;
using Core.Utilities;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerDal _gamerDal;
        public GamerManager(IGamerDal gamerDal)
        {
            _gamerDal = gamerDal;
        }
        [ValidationAspect(typeof(GamerValidator))]
        public IResult Add(Gamer gamer)
        {
           var result= _gamerDal.Get(gamer);
            foreach (var item in result)
            {
                if (item.IdentityNumber == gamer.IdentityNumber)
                {
                    return new ErrorResult("This gamer already exist");
                }
            }
            _gamerDal.Add(gamer);
            return new SuccessResult();

        }

        public IResult Delete(Gamer gamer)
        {
            _gamerDal.Delete(gamer);
            return new SuccessResult();
        }

        public IDataResult<List<Gamer>> GetAll()
        {
            return new SuccessDataResult<List<Gamer>>(_gamerDal.GetAll());
        }
        [ValidationAspect(typeof(GamerValidator))]
        public IResult Update(Gamer gamer)
        {
            _gamerDal.Update(gamer);
            return new SuccessResult();
        }
    }
}
