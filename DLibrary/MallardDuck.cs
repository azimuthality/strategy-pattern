﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DLibrary
{
    
    public class MallardDuck : Duck
    {
        public override string display()
        {
            return "display" + this.GetType();
        }
    }
}