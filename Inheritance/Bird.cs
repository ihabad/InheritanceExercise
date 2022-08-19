using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{

  
    class Bird : Animal
    {
        public string Type { get; set; }
        public bool Backbone { get; set; }
        public bool TwoLegs { get; set; }
        public int Wings { get; set; }

    }
    public Bird()
    {

    }

    public Bird(
        string Name, int Age, int Eyes,
        bool HasHead, string Type,
        bool Backbone, bool TwoLegs, int Wings)
    {
        Name = name ;
        Age = age;
        HasHead = HasHead;
        Type = Type;
        Backbone = Backbone;
        TwoLegs = TwoLegs;
    }
}
