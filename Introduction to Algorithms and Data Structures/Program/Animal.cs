﻿using System;
using System.Collections.Generic;
using System.Text;
namespace Program
{
    public class Animal
    {
        private string type;
        private int weight;
        public Animal(string type, int weight)
        {
            Type = type;
            Weight = weight;
        }
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
        public override string ToString()
        {
            return $"Animal {Type} weights {Weight} kg.";
        }
    }
}