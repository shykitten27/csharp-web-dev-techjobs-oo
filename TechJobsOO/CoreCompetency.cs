﻿using System;
namespace TechJobsOO
{
    public class CoreCompetency
    {
        private int id { get; }
        private static int nextId = 1;
        private string value { get; set; }

        // TODO: Change the fields to auto-implemented properties. Complete

        public CoreCompetency()
        {
            id = nextId;
            nextId++;
        }

        public CoreCompetency(string v) : this()
        {
            value = v; //the corecompetency value aka skill
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   id == competency.id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id);
        }

        public override string ToString()
        {
            return value;
        }
    }
}