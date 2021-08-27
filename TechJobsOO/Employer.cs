using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class Employer : JobField
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; } //the employer value aka name
        //public string Address { get; set; }           //FUTURE requirement?
        //public string PrimaryContact { get; set;}     //FUTURE requirement?
        //public List<Job> AvailableJobs { get; set;}   //FUTURE requirement?

        //empty constructory
        public Employer()
        {
            Id = nextId;
            nextId++;
        }

        //overloaded second constructor to this class 
        public Employer(string value) : this()
        {
            Value = value; //aka employer name
        }

        public override bool Equals(object obj)
        {
            return obj is Employer employer &&
                   Id == employer.Id;
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
