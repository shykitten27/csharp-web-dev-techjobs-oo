﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        Job test_job1; 
        Job test_job2; 
        Job test_job3;
        Job test_job4;
        Job test_job5;
        Job test_job6;

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
            test_job5 = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));
            test_job6 = new Job(null, new Employer(null), new Location(null), new PositionType(null), new CoreCompetency(null));
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
            Assert.AreEqual(test_job3.JobCoreCompetency.Value, "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(test_job3.Equals(test_job4));
        }

        [TestMethod]
        public void TestJobToString()
        {
            //test with an object that uses the FULL constructor and use empty string or nulls to test
            test_job3.ToString();
            Assert.IsTrue(test_job3.ToString().StartsWith("\n"));
            Assert.IsTrue(test_job3.ToString().Contains("\nID: 3\nName: Product tester\nEmployer: ACME\nLocation: Desert\nPosition Type: Quality control\nCore Competency: Persistence"));
            Assert.IsTrue(test_job3.ToString().EndsWith("\n"), "\n");

            test_job5.ToString();
            Assert.IsTrue(test_job5.ToString().StartsWith("\n"));
            Assert.IsTrue(test_job5.ToString().Contains("\nID: 5\nName: Data not available\nEmployer: Data not available\nLocation: Data not available\nPosition Type: Data not available\nCore Competency: Data not available"));
            Assert.IsTrue(test_job5.ToString().EndsWith("\n"), "\n");

            test_job6.ToString();
            Assert.IsTrue(test_job6.ToString().StartsWith("\n"));
            Assert.IsTrue(test_job6.ToString().Contains("\nID: 6\nName: Data not available\nEmployer: Data not available\nLocation: Data not available\nPosition Type: Data not available\nCore Competency: Data not available"));
            Assert.IsTrue(test_job6.ToString().EndsWith("\n"), "\n");
        }
    }
}
