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
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompentcy) : this() 
        { 
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
            string result = "";
            result += "\n"; //blank line before job information

            result += "\nID: ";
            result += Id;

            result += "\nName: ";
            if (Name !=null && Name !="")
            {
                result += Name;
            }
            else
            {
                result += "Data not available";
            }

            result += "\nEmployer: ";
           if (EmployerName.Value !=null && EmployerName.Value !="")
            {
                result += EmployerName.Value;
            }
            else
            {
                result += "Data not available";
            }

            result += "\nLocation: ";
           if (EmployerLocation.Value !=null && EmployerLocation.Value !="")
            {
                result += EmployerLocation.Value;
            }
            else
            {
                result += "Data not available";
            }

            result += "\nPosition Type: ";
           if (JobType.Value !=null && JobType.Value !="")
            {
                result += JobType.Value;
            }
            else
            {
                result += "Data not available";
            }
  
            result += "\nCore Competency: ";
            if (JobCoreCompetency.Value !=null && JobCoreCompetency.Value !="")
            {
                result += JobCoreCompetency.Value;
            }
            else
            {
                result += "Data not available";
            }

            result += "\n"; //blank line after job information

            return result;
        }
    }
}
