using System;
using Television.Business.Abstract;
using Television.Business.CrossCuttingConcerns.DependencyResolvers.Ninject;

namespace Television.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           var televisionService = InstanceFactory.GetInstance<ITelevisionService>();
            televisionService.GetAll().ForEach(h => Console.WriteLine(h));


        }
    }
}
