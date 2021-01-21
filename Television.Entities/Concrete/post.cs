using System;
using System.Collections.Generic;
using System.Text;
using Television.Entities.Abstract;

namespace Television.Entities.Concrete
{
    public class post : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public post()
        {

        }
        public post(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return $"{Id,-5}{Title,-10}";
        }
    }
}
