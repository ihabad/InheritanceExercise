using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public string Type { get; set; }
        public bool Backbone { get; set; }
        public bool TwoLegs { get; set; }
        public int Wings { get; set; }
    }

    public Reptile(
       string Name, int Age, int Eyes,
        bool HasHead, string Type,
        bool Backbone, bool TwoLegs, int Wings)
    {
        Name = name;
        Age = age;
        HasHead = HasHead;
        Type = Type;
        Backbone = Backbone;
        TwoLegs = TwoLegs;
    }
}
