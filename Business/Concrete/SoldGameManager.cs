using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac;
using Core.Utilities;
using Core.Utilities.Business;
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
        [ValidationAspect(typeof(SoldGameValidator))]
        public IResult Add(SoldGame soldGame)
        {
            IResult result = BusinessRules.Run(CheckCampaignEndDate(soldGame.CampaignEndDate));
            if (result!=null)
            {
                return result;
            }
            
                _soldGameDal.Add(soldGame);
                return new SuccessResult(soldGame.GameName + " has been sold to " + soldGame.GamerName + " " + soldGame.GamerLastName + " at " + soldGame.SoldDate);
            
           
        }

        private IResult CheckCampaignEndDate(DateTime? campaignEndDate)
        {
            if (campaignEndDate < DateTime.Now)
            {
                return new ErrorResult(Messages.CampaignEndDateExpired);
            }
            return new SuccessResult();
        }

        public IResult Delete(SoldGame soldGame)
        {
            _soldGameDal.Delete(soldGame);
            return new SuccessResult(soldGame.GameName + " sold to " + soldGame.GamerName + " " + soldGame.GamerLastName + " has been deleted");        }

        public IDataResult<List<SoldGame>> GetAll()
        {
            return new SuccessDataResult<List<SoldGame>>(_soldGameDal.GetAll());
        }
        [ValidationAspect(typeof(SoldGameValidator))]
        public IResult Update(SoldGame soldGame)
        {
            _soldGameDal.Update(soldGame);
            return new SuccessResult(soldGame.GameName + " sold to " + soldGame.GamerName + " " + soldGame.GamerLastName + " has been updated");
        }
    }
}
