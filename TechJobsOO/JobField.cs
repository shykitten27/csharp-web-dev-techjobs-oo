﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class JobField
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        //empty constructory
        public JobField()
        {
            Id = nextId;
            nextId++;
        }

        //overloaded second constructor to this class 
        public JobField(string value) : this()
        {
            Value = value; 
        }
        public override bool Equals(object obj)
        {
            return obj is JobField jobField &&
                   Id == jobField.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Value);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
