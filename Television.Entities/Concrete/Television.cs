﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Television.Entities.Abstract;

namespace Television.Entities.Concrete
{
    public class Television :IEntity
    {
        [Key]
        public int TvID { get; set; }
        public string Name { get; set; }
        public double Frequency { get; set; }
        public bool IsNewsChannel { get; set; }
        public Television()
        {

        }

        public Television(string name, double frequency, bool isNewsChannel)
        {
            Name = name;
            Frequency = frequency;
            IsNewsChannel = isNewsChannel;
        }

        public override string ToString()
        {
            return $"{TvID,-10}{Name,-20}{Frequency,-20}{IsNewsChannel,-10}";
        }
    }
}
