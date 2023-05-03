﻿using System;

namespace SolidLiskovInstitiutionPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFruit fruit = new Orange();
            Console.WriteLine($"Color of Orange: {fruit.GetColor()}");
            fruit = new Apple();
            Console.WriteLine($"Color of Apple: {fruit.GetColor()}");
            Console.ReadKey();
        }


        public interface IFruit
        {
            string GetColor();
        }
        public class Apple : IFruit
        {
            public string GetColor()
            {
                return "Red";
            }
        }
        public class Orange : IFruit
        {
            public string GetColor()
            {
                return "Orange";
            }
        }


    }
}
