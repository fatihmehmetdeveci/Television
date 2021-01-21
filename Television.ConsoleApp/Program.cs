using System;
using System.Collections.Generic;
using System.Linq;
using Television.Business.Abstract;
using Television.Business.CrossCuttingConcerns.DependencyResolvers.Ninject;

namespace Television.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{"TvID",-10}{"Name",-20}{"Frequency",-20}{"IsNewsChannel",-10}");
            var televisionService = InstanceFactory.GetInstance<ITelevisionService>();
            televisionService.GetAll().ForEach(g => Console.WriteLine(g));
            //var list = new List<Entities.Concrete.Television>()
            //{
            //    new Entities.Concrete.Television()
            //    {
            //        Name="test",
            //        Frequency=5,
            //        IsNewsChannel=true
            //    },
            //    new Entities.Concrete.Television()
            //    {
            //        Name="deneme",
            //        Frequency=15,
            //        IsNewsChannel=false
            //    }
            //};
            //foreach (var item in list)
            //{
            //    televisionService.Add(item);
            //}
            var postService = InstanceFactory.GetInstance<IpostService>();
            postService.GetAll().ForEach(g => Console.WriteLine(g));
            postService.Add(new Entities.Concrete.post() {Title="deneme" });

        }
    }
}
