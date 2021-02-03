﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptiles : Animal
    {
        public Reptiles()
        {
            IsAlive = true;
            LegCount = 4;
            LandSeaAir = "Land";
            Age = 0;
        }

        public bool IsColdBlooded { get; set; }
        public bool IsScaly { get; set; }
        public string Habitat { get; set; }
        public bool CanGrowTail { get; set; }
    }
}
