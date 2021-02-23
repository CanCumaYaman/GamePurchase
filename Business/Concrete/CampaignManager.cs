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
    public class CampaignManager : ICampaignService
    {
        ICampaignDal _campaignDal;
        public CampaignManager(ICampaignDal campaignDal)
        {
            _campaignDal = campaignDal;
        }
        [ValidationAspect(typeof(CampaignValidator))]
        public IResult Add(Campaign campaign)
        {
            _campaignDal.Add(campaign);
            return new SuccessResult();
        }

        public IResult Delete(Campaign campaign)
        {
            _campaignDal.Delete(campaign);
            return new SuccessResult();
        }

        public IDataResult<List<Campaign>> GetAll()
        {
            return  new SuccessDataResult<List<Campaign>>(_campaignDal.GetAll()) ;
            
        }
        [ValidationAspect(typeof(CampaignValidator))]
        public IResult Update(Campaign campaign)
        {
            _campaignDal.Update(campaign);
            return new SuccessResult();
        }
    }
}
