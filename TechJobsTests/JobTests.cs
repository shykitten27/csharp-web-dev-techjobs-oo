using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TechJobsOO;

namespace TechJobsTests
{
    class JobTests
    {
        Job test_job; //variable is declared

        [TestInitialize]
        //create the object
        public void CreateJobObject() 
        {
            test_job = new Job("Developer", new Employer("EHI"), new Location("Clayton"), new PositionType("C# Developer"), new CoreCompetency("C#"));
        }
        [TestMethod]
        //assertions for each property
        public void TestJobName()
        {           
            Assert.AreEqual(test_job.Name, "Developer");
            Assert.AreEqual(test_job.EmployerName.Value, "EHI");
            Assert.AreEqual(test_job.EmployerLocation.Value, "Clayton");
            Assert.AreEqual(test_job.JobType.Value, "C# Developer");
            Assert.AreEqual(test_job.JobCoreCompetency, "C#");
        }



    }
}
