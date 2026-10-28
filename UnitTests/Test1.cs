using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
// made changes
namespace UnitTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
        public void CalculationsConstructorTest()
        {
            Calculations calcObject = new Calculations();
        }

        public void AddNumbersTest()
        {
            Calculations calcObject = new Calculations();
            int result = calcObject.Add(3, 4);
            int expectedValue = 7;
            Assert.AreEqual(expectedValue, result);
        }
        public void SubtractNumbersTest()
        {
            Calculations calcObject = new Calculations();
            double result = calcObject.Subtract(32, 4);
            Assert.AreEqual(28, result);
        }
        public void DivideByZeroTest()
        {
            Calculations calcObject = new Calculations();
            Assert.Throws<ArgumentOutOfRangeException>(() => calcObject.Divide(32, 0));
        }

        public void MidRandomTest1()
        {
            Calculations calcObject = new Calculations();
            int result = calcObject.Mid(1, 2, 3);
            Assert.AreEqual(2, result);
        }

        public void NormalDevisionTest()
        {
            Calculations calcObject = new Calculations();
            double result = calcObject.Divide(32, 4);
            Assert.AreEqual(8, result);
        }

        public void MidStatementCoverageTest1()
        {
            Calculations calcObject = new Calculations();
            int result = calcObject.Mid(7, 6, 8);
            Assert.AreEqual(7, result);
        }
        [TestMethod]
        public void MidDomainPartitioningTest1()

        {

        Calculations calcObject = new Calculations();
        Assert.AreEqual(2, calcObject.Mid(2, 1, 3));

        }
 

        [TestMethod]

        public void MidDomainPartitioningTest2()

        {

        Calculations calcObject = new Calculations();
        Assert.AreEqual(2, calcObject.Mid(2, 3, 1));

        }




        [TestMethod]

        public void MidDomainPartitioningTest3()

        {
  
        Calculations calcObject = new Calculations();
        Assert.AreEqual(2, calcObject.Mid(1, 2, 3));
   
        }




            [TestMethod]

            public void MidDomainPartitioningTest4()

            {
   
            Calculations calcObject = new Calculations();
            Assert.AreEqual(2, calcObject.Mid(3, 2, 1));
    
            }



            [TestMethod]

            public void MidDomainPartitioningTest5()

            {  
            Calculations calcObject = new Calculations();
            Assert.AreEqual(2, calcObject.Mid(1, 3, 2)); 
            }



            [TestMethod]

                public void MidDomainPartitioningTest6()

                {
    
                Calculations calcObject = new Calculations();
                Assert.AreEqual(2, calcObject.Mid(3, 1, 2));
    
                }

}

}
    
