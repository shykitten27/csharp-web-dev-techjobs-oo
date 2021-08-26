using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TechJobsOO;

namespace TechJobsTests
{

    public class JobTests
    {
        Job test_job1; 
        Job test_job2; 
        Job test_job3;
        Job test_job4;

        [TestInitialize]
        //create the object
        public void CreateJobObject()
        {
            //emtpy constructors will create two jobs with different Ids
            test_job1 = new Job();
            test_job2 = new Job();
            //full constructors will create two jobs with different Ids even if all other fields are identical
            test_job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            test_job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.IsFalse(test_job1.Id == test_job2.Id); //Ids are NOT equal
            Assert.IsTrue(test_job2.Id == (test_job1.Id + 1)); //second id is greater by 1
        }

        [TestMethod]
        //assertions for each property
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual(test_job3.Name, "Product tester");
            Assert.AreEqual(test_job3.EmployerName.Value, "ACME");
            Assert.AreEqual(test_job3.EmployerLocation.Value, "Desert");
            Assert.AreEqual(test_job3.JobType.Value, "Quality control");
            Assert.AreEqual(test_job3.JobCoreCompetency, "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(test_job3.Equals(test_job4));
        }

/*        [TestMethod]
        public void TestJobToString()
        {
            test_job1.ToString();
            Assert.AreEqual(test_job1.ToString(), "Data not available");
        }*/
    }
}
