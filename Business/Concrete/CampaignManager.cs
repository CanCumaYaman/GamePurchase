using Business.Abstract;
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
        public void Add(Campaign campaign)
        {
            _campaignDal.Add(campaign);
            Console.WriteLine(campaign.Name+" campaign added");
        }

        public void Delete(Campaign campaign)
        {
            _campaignDal.Delete(campaign);
            Console.WriteLine(campaign.Name + " campaign deleted");
        }

        public void Update(Campaign campaign)
        {
            _campaignDal.Update(campaign);
            Console.WriteLine(campaign.Name + " campaign updated");
        }
    }
}
