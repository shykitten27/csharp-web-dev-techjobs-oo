﻿using System;
namespace TechJobsOO
{
    public class Location
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }
        //public string ZipCode { get; set; } //string in case we implement for Canada or other countries that are alphanumeric zipcodes

        //empty constructory
        public Location()
        {
            Id = nextId;
            nextId++;
        }

        // TODO: Add a second constructor to this class that uses the Location() constructor and sets the value of the value field as well as new zipCode field.
        public Location(string value) : this()
        {
            Id = Location.nextId++;
            Value = value; //aka city
            //ZipCode = zipCode;
        }

        public override bool Equals(object obj)
        {
            return obj is Location location &&
                   Id == location.Id;
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
