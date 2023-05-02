﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPrototypeDesignPattern
{
    public class TemporaryEmployee : Employeee
    {
        public int FixedAmount { get; set; }
        public override Employeee GetClone()
        {
            // MemberwiseClone Method Creates a shallow copy of the current System.Object
            // So typecast the Object Appropriate Type
            // In this case, typecast to TemporaryEmployee type
            return (TemporaryEmployee)this.MemberwiseClone();
        }
        public override void ShowDetails()
        {
            Console.WriteLine("Temporary Employee");
            Console.WriteLine($" Name:{this.Name}, Department: {this.Department}, Type:{this.Type}, FixedAmount: {this.FixedAmount}\n");
        }
    }
}