using AssertionTestingProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AssertionTestSpec
{

    [TestClass()]
    public class AssertionTestClassTest
    {

        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        [TestMethod()]
        public void AssertionTestClassConstructorTest()
        {
            AssertionTestClass target = new AssertionTestClass();
        }

        [TestMethod()]
        public void TestAssertAreEqual()
        {
            AssertionTestClass target = new AssertionTestClass();
            int expected = 1;
            int actual = target.GoingToReturnOne();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestAssertIsInstanceOfType()
        {
            AssertionTestClass target = new AssertionTestClass();
            Assert.IsInstanceOfType(target.GoingToReturnEmptyString(), typeof(String));
        }

        [TestMethod()]
        public void TestAssertFailedExceptions()
        {
            throw new AssertFailedException("We must own our failures, and this failure is my own!");
        }

        [TestMethod()]
        public void TestAssertFail()
        {
            Assert.Fail("We must own our failures, and this failure is my own!");
        }

        [TestMethod()]
        public void TestCollectionAssertAllItemsAreInstancesOfType()
        {
            AssertionTestClass target = new AssertionTestClass();
            CollectionAssert.AllItemsAreInstancesOfType(target.GetIntegerArray(), typeof(int));
        }

        [TestMethod()]
        public void TestCollectionAssertAllItemsAreEqual()
        {
            AssertionTestClass target = new AssertionTestClass();
            Array expected = new int[]{1,2,3,4,5};
            CollectionAssert.AreEqual(expected, target.GetIntegerArray());
        }

        [TestMethod()]
        public void TestCollectionAssertAllItemsAreEquivalent()
        {
            AssertionTestClass target = new AssertionTestClass();
            Array expected = new int[] { 1, 2, 3, 4, 5 };
            CollectionAssert.AreEquivalent(expected, target.GetIntegerArray());
        }

        [TestMethod()]
        public void TestCollectionAssertContains()
        {
            AssertionTestClass target = new AssertionTestClass();
            int mustContain = 5;
            CollectionAssert.Contains(target.GetIntegerArray(), mustContain);
        }

        [TestMethod()]
        public void TestStringAssertStartsWith()
        {
            AssertionTestClass target = new AssertionTestClass();
            string expected = "Superman";
            StringAssert.StartsWith(target.GetSupermanBatman(), expected);
        }

        [TestMethod()]
        public void TestStringAssertContains()
        {
            AssertionTestClass target = new AssertionTestClass();
            string expected = "manBat";
            StringAssert.Contains(target.GetSupermanBatman(), expected);
        }
    }
}
