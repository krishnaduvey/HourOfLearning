using NUnit.Framework;
using AssignmentOne;
using System;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System.IO;
using NUnit.Framework.Interfaces;

namespace UnitTestProjectForAssignmentOne
{
    [TestFixture]
    public class UnitTestForAddition
    {

        protected ExtentReports _extent;
        protected ExtentTest _test;

        [OneTimeSetUp]
        public void BeforeClass()
        {
            try
            {
                //To create report directory and add HTML report into it
                _extent = new ExtentReports();
                var dir = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
                DirectoryInfo di = Directory.CreateDirectory(dir + "\\Test_Execution_Reports");
                var htmlReporter = new ExtentHtmlReporter(dir + "\\Test_Execution_Reports" + "\\Automation_Report" + ".html");
                _extent.AddSystemInfo("Environment", "Quality BDD Env");
                _extent.AddSystemInfo("User Name", "Krishankant");
                _extent.AttachReporter(htmlReporter);
            }
            catch (Exception e)
            {
                throw (e);
            }

        }

        [SetUp]
        public void BeforeTest()
        {
            try
            {
                _test = _extent.CreateTest(TestContext.CurrentContext.Test.Name);
            }
            catch (Exception e)
            {
                throw (e);
            }
        }



        [Test]
        public void SumTestWithValidCondition()
        {
            var sum = Addition.AdditionOfTwoNumbers(15, 10);
            Console.WriteLine(sum);
            NUnit.Framework.Assert.AreEqual(25, sum);
        }

        [Test]
        public void SumTestWithInValidCondition() 
        {
            var sum = Addition.AdditionOfTwoNumbers(10, 10);
            Console.WriteLine(sum);
            NUnit.Framework.Assert.AreEqual(25, sum);
        }

       [Test]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            PrimeService primeService = CreatePrimeService();
            var result = primeService.IsPrime(1);

            NUnit.Framework.Assert.IsFalse(result, "1 should not be prime");
        }

        private PrimeService CreatePrimeService()
        {
            return new PrimeService();
        }

        [TearDown]
        public void AfterTest()
        {
            try
            {
                var status = TestContext.CurrentContext.Result.Outcome.Status;
                var stacktrace = "" +TestContext.CurrentContext.Result.StackTrace + "";
                var errorMessage = TestContext.CurrentContext.Result.Message;
                Status logstatus;
                switch (status)
                {
                    case TestStatus.Failed:
                        logstatus = Status.Fail;
                        //string screenShotPath = Capture(driver, TestContext.CurrentContext.Test.Name);
                        _test.Log(logstatus, "Test ended with " +logstatus + " – " +errorMessage);
                        //_test.Log(logstatus, "Snapshot below: " +_test.AddScreenCaptureFromPath(screenShotPath));
                        break;
                    case TestStatus.Skipped:
                        logstatus = Status.Skip;
                        _test.Log(logstatus, "Test ended with " +logstatus);
                        break;
                    default:
                        logstatus = Status.Pass;
                        _test.Log(logstatus, "Test ended with " +logstatus);
                        break;
                }
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        ///To flush extent report
        ///To quit driver instance
        /// /// Author: Sanoj
        /// Since: 23-Sep-2018
        [OneTimeTearDown]
        public void AfterClass()
        {
            try
            {
                _extent.Flush();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
    }

}
