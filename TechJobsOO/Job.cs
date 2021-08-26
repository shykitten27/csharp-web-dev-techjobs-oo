using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors. 
        //empty constructory
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        //overloaded second constructor to this class that uses Job() constructor and sets the value of the
        // name, employerName, employerLocation, jobType and jobCoreCompetency fields
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompentcy)
        {
            Id = Job.nextId++; //combine into one statement
            //nextId++;
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompentcy;
        }

        
        // TODO: Generate Equals() and GetHashCode() methods. 
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, EmployerName, EmployerLocation, JobType, JobCoreCompetency);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
