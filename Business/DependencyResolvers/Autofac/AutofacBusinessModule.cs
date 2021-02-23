using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
   public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<GamerManager>().As<IGamerService>().SingleInstance();
            builder.RegisterType<EfGamerDal>().As<IGamerDal>().SingleInstance();

            builder.RegisterType<GameManager>().As<IGameService>().SingleInstance();
            builder.RegisterType<EfGameDal>().As<IGameDal>().SingleInstance();

            builder.RegisterType<CampaignManager>().As<ICampaignService>().SingleInstance();
            builder.RegisterType<EfCampaignDal>().As<ICampaignDal>().SingleInstance();

            builder.RegisterType<SoldGameManager>().As<ISoldGameService>().SingleInstance();
            builder.RegisterType<EfSoldGameDal>().As<ISoldGameDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
