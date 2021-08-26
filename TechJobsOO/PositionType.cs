﻿using System;
namespace TechJobsOO
{
    public class PositionType
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        //empty constructory
        public PositionType()
        {
            Id = nextId;
            nextId++;
        }

        //overloaded second constructor
        public PositionType(string value) : this()
        {
            Value = value; //job name
        }
        // TODO: Add custom Equals(), GetHashCode(), and ToString() methods. Complete
        public override bool Equals(object obj)
        {
            return obj is PositionType type &&
                   Id == type.Id;
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
