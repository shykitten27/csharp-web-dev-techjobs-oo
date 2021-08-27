﻿using System;
namespace TechJobsOO
{
    public class CoreCompetency
    {
        public int id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        // TODO: Change the fields to auto-implemented properties. Complete

        //empty constructory
        public CoreCompetency()
        {
            id = nextId;
            nextId++;
        }
        //overloaded second constructor
        public CoreCompetency(string v) : this()
        {
            Value = v; //aka skill
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   id == competency.id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, Value);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}