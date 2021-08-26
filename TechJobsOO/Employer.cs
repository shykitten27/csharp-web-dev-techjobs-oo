using System;
namespace TechJobsOO
{
    public class Employer
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; } //the employer value aka name
        public string Address { get; set; }
        public string PrimaryContact { get; set;}
        public List<Jobs> AvailableJobs { get; set;}

        public Employer()
        {
            Id = nextId;
            nextId++;
        }

        public Employer(string value) : this()
        {
            Value = value; //the employer value aka employer name
            Address = Address;
            PrimaryContact = primaryContact;
            AvailableJobs = AvailableJobs;
        }

        public override bool Equals(object obj)
        {
            return obj is Employer employer &&
                   Id == employer.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
