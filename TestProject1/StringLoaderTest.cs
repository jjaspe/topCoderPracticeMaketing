using topCoderPracticeMarketing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for StringLoaderTest and is intended
    ///to contain all StringLoaderTest Unit Tests
    ///</summary>
    [TestClass()]
    public class StringLoaderTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
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


        #region Grid tests
        [TestMethod]
        public void getGridDefaultTest()
        {
            StringLoader target = new StringLoader(); // TODO: Initialize to an appropriate value
            bool[,] expected = {}; // TODO: Initialize to an appropriate value
            bool[,] actual;
            actual = target.getGrid(0);
            Assert.IsTrue(areArraysEqual(expected, actual));
        }

        [TestMethod]
        public void getGridDimOneTest()
        {
            StringLoader target = new StringLoader(); // TODO: Initialize to an appropriate value
            bool[,] expected = {{false} }; // TODO: Initialize to an appropriate value
            bool[,] actual;
            actual = target.getGrid(1);
            Assert.IsTrue(areArraysEqual(expected, actual));
        }

        [TestMethod]
        public void getGridDimTwoTest()
        {
            StringLoader target = new StringLoader(); // TODO: Initialize to an appropriate value
            bool[,] expected = { { false,false },{false,false} }; // TODO: Initialize to an appropriate value
            bool[,] actual;
            actual = target.getGrid(2);
            Assert.IsTrue(areArraysEqual(expected, actual));
        }
        #endregion

        /// <summary>
        ///A test for loadDataAsBooleans
        ///</summary>
        [TestMethod()]
        public void loadDataAsBooleanDefaultTest()
        {
            StringLoader target = new StringLoader(); // TODO: Initialize to an appropriate value
            string[] data = {}; // TODO: Initialize to an appropriate value
            bool[,] expected = {}; // TODO: Initialize to an appropriate value
            bool[,] actual;
            actual = target.loadDataAsBooleans(data);
            Assert.IsTrue(areArraysEqual(expected, actual));
        }

        [TestMethod]
        public void loadDataAsBooleanData1Test()
        {
            StringLoader target = new StringLoader(); // TODO: Initialize to an appropriate value
            string[] data = {"",""}; // TODO: Initialize to an appropriate value
            bool[,] expected = {{false,false},{false,false}}; // TODO: Initialize to an appropriate value
            bool[,] actual;
            actual = target.loadDataAsBooleans(data);
            Assert.IsTrue(areArraysEqual(expected, actual));
        }

        bool areArraysEqual(bool[] array1, bool[] array2)
        {
            if (array1.Length != array2.Length)
                return false;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i].CompareTo(array2[i]) != 0)
                    return false;
            }
            return true;
        }

        bool areArraysEqual(bool[,] array1, bool[,] array2)
        {
            if (array1.Length != array2.Length || array1.Rank!=array2.Rank)
                return false;
            for (int i = 0; i < array1.Rank; i++)
            {
                for (int j = 0; j < array1.Length / array1.Rank; j++)
                {
                    if (array1[i,j]!=array2[i,j])
                        return false;
                }
            }
            return true;
        }
    }
}
