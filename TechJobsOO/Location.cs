using System;
namespace TechJobsOO
{
    public class Location
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }
        public string ZipCode { get; set; } //string in case we implement for Canada or other countries that are alphanumeric zipcodes

        public Location()
        {
            Id = nextId;
            nextId++;
        }

        public Location(string value) : this()
        {
            Value = value; //the location value aka city
        }

        public ZipCode(string zipcode) : this()
        {
            ZipCode = zipcode; 
        }

        // TODO: Add a second constructor to this class that uses the Location() constructor and sets the value of the value field.

        public override bool Equals(object obj)
        {
            return obj is Location location &&
                   Id == location.Id;
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
