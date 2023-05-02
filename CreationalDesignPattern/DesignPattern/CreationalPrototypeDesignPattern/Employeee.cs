﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPrototypeDesignPattern
{
    public abstract class Employeee
    {
        //The Prototype Abstract Class
        //This is an abstract class which is used for the types of object that can be cloned itself.
        public string Name { get; set; }
        public string Department { get; set; }
        public string Type { get; set; }
        public abstract Employeee GetClone();
        public abstract void ShowDetails();
    }
}
