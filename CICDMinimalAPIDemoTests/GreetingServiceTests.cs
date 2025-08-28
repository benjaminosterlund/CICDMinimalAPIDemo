using Microsoft.VisualStudio.TestTools.UnitTesting;
using CICDMinimalAPIDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CICDMinimalAPIDemo.Tests
{
    [TestClass()]
    public class GreetingServiceTests
    {
        [TestMethod()]
        public void GetGreetingTest()
        {
            //Arrange
            var greetingService = new GreetingService("Test");
            
            //Act
            var actualGreeting = greetingService.GetGreeting();

            //Assert
            Assert.AreEqual("Hello Test!", actualGreeting);
        }
    }
}