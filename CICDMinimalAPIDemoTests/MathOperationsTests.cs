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
    public class MathOperationsTests
    {
        [TestMethod()]
        public void AddTest()
        {
            //Act
            var result = MathOperations.Add(2, 3);

            //Assert
            Assert.AreEqual(5,result);
        }
    }
}