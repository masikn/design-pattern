﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class DecoyDuck : Duck
    {
        public override string display()
        {
            return "display " + " " + this.GetType();
        }
    }
}