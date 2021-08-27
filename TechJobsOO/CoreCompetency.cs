using System;
namespace TechJobsOO
{
    public class CoreCompetency
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        // TODO: Change the fields to auto-implemented properties. Complete

        //empty constructory
        public CoreCompetency()
        {
            Id = nextId;
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
                   Id == competency.Id;
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