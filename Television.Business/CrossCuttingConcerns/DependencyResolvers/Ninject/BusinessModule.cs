﻿using Television.Business.Abstract;
using Television.Business.Concrete;
using Television.DataAccess.Abstract;
using Television.DataAccess.Concrete.Entity;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;
using Television.DataAccess.Concrete.ADONET;

namespace Television.Business.CrossCuttingConcerns.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ITelevisionService>().To<TelevisionManager>().InSingletonScope();
           //Bind<ITelevisionDal>().To<AdoTelevisionDal>().InSingletonScope();
            Bind<ITelevisionDal>().To<EfTelevisionDal>().InSingletonScope();
        }
    }
}
