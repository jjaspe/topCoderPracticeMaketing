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
    public class SolverTest
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
            Solver target = new Solver(); // TODO: Initialize to an appropriate value
            bool[,] expected = {}; // TODO: Initialize to an appropriate value
            bool[,] actual;
            actual = target.getGrid(0);
            Assert.IsTrue(areArraysEqual(expected, actual));
        }

        [TestMethod]
        public void getGridDimOneTest()
        {
            Solver target = new Solver(); // TODO: Initialize to an appropriate value
            bool[,] expected = {{false} }; // TODO: Initialize to an appropriate value
            bool[,] actual;
            actual = target.getGrid(1);
            Assert.IsTrue(areArraysEqual(expected, actual));
        }

        [TestMethod]
        public void getGridDimTwoTest()
        {
            Solver target = new Solver(); // TODO: Initialize to an appropriate value
            bool[,] expected = { { false,false },{false,false} }; // TODO: Initialize to an appropriate value
            bool[,] actual;
            actual = target.getGrid(2);
            Assert.IsTrue(areArraysEqual(expected, actual));
        }
        #endregion

        #region SplitArray Tests
        [TestMethod]
        public void splitArrayTestDefault()
        {
            Solver target = new Solver(); // TODO: Initialize to an appropriate value
            string data = "1"; // TODO: Initialize to an appropriate value
            String[] expected = {"1"}; // TODO: Initialize to an appropriate value
            String[] actual;
            actual = target.getSplitArray(data);
            Assert.IsTrue(areArraysEqual(expected, actual));
        }

        [TestMethod]
        public void splitArrayTestTwo()
        {
            Solver target = new Solver(); // TODO: Initialize to an appropriate value
            string data = "1 2"; // TODO: Initialize to an appropriate value
            String[] expected = { "1","2" }; // TODO: Initialize to an appropriate value
            String[] actual;
            actual = target.getSplitArray(data);
            Assert.IsTrue(areArraysEqual(expected, actual));
        }

        [TestMethod]
        public void splitArrayTestThree()
        {
            Solver target = new Solver(); // TODO: Initialize to an appropriate value
            string data = "1 2 4 5 10 34 45"; // TODO: Initialize to an appropriate value
            String[] expected = { "1", "2", "4","5","10","34","45"}; // TODO: Initialize to an appropriate value
            String[] actual;
            actual = target.getSplitArray(data);
            Assert.IsTrue(areArraysEqual(expected, actual));
        }
        #endregion

        #region Count Non-Conflicts Tests
        [TestMethod]
        public void countNonConflictsTest1()
        {
            Solver target = new Solver(); // TODO: Initialize to an appropriate value
            bool[,] data = { }; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.countNonConflicts(data);
            Assert.AreEqual(actual,expected);
        }

        [TestMethod]
        public void countNonConflictsTest2()
        {
            Solver target = new Solver(); // TODO: Initialize to an appropriate value
            bool[,] data = {{false}}; // TODO: Initialize to an appropriate value
            int expected = 1; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.countNonConflicts(data);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void countNonConflictsTest3()
        {
            Solver target = new Solver(); // TODO: Initialize to an appropriate value
            bool[,] data = { { false,false },{false,false} }; // TODO: Initialize to an appropriate value
            int expected = 2; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.countNonConflicts(data);
            Assert.AreEqual(expected,actual );
        }

        [TestMethod]
        public void countNonConflictsTest3False()
        {
            Solver target = new Solver(); // TODO: Initialize to an appropriate value
            bool[,] data = { { false, true }, { false, false } }; // TODO: Initialize to an appropriate value
            int expected = 2; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.countNonConflicts(data);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void countNonConflictsTest4()
        {
            Solver target = new Solver(); // TODO: Initialize to an appropriate value
            bool[,] data = { { false, true,false }, { false, false,true },{false,false,false }}; // TODO: Initialize to an appropriate value
            int expected = 1; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.countNonConflicts(data);
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region Load Data Tests
        /// <summary>
        ///A test for loadDataAsBooleans
        ///</summary>
        [TestMethod()]
        public void loadDataAsBooleanDefaultTest()
        {
            Solver target = new Solver(); // TODO: Initialize to an appropriate value
            string[] data = {}; // TODO: Initialize to an appropriate value
            bool[,] expected = {}; // TODO: Initialize to an appropriate value
            bool[,] actual;
            actual = target.loadDataAsBooleans(data);
            Assert.IsTrue(areArraysEqual(expected, actual));
        }

        [TestMethod]
        public void loadDataAsBooleanDataTest()
        {
            Solver target = new Solver(); // TODO: Initialize to an appropriate value
            string[] data = {""}; // TODO: Initialize to an appropriate value
            bool[,] expected = { {false}}; // TODO: Initialize to an appropriate value
            bool[,] actual;
            actual = target.loadDataAsBooleans(data);
            Assert.IsTrue(areArraysEqual(expected, actual));
        }

        [TestMethod]
        public void loadDataAsBooleanDataTest1()
        {
            Solver target = new Solver(); // TODO: Initialize to an appropriate value
            string[] data = {"",""}; // TODO: Initialize to an appropriate value
            bool[,] expected = {{false,false},{false,false}}; // TODO: Initialize to an appropriate value
            bool[,] actual;
            actual = target.loadDataAsBooleans(data);
            Assert.IsTrue(areArraysEqual(expected, actual));
        }

        [TestMethod]
        public void loadDataAsBooleanDataTest2()
        {
            Solver target = new Solver(); // TODO: Initialize to an appropriate value
            string[] data = { "1", "" }; // TODO: Initialize to an appropriate value
            bool[,] expected = { { false, true }, { true, false } }; // TODO: Initialize to an appropriate value
            bool[,] actual;
            actual = target.loadDataAsBooleans(data);
            Assert.IsTrue(areArraysEqual(expected, actual));
        }

        [TestMethod]
        public void loadDataAsBooleanDataTest3()
        {
            Solver target = new Solver(); // TODO: Initialize to an appropriate value
            string[] data = { "1", "2","0" }; // TODO: Initialize to an appropriate value
            bool[,] expected = { { false, true,true }, { true, false,true },{true,true,false} }; // TODO: Initialize to an appropriate value
            bool[,] actual;
            actual = target.loadDataAsBooleans(data);
            Assert.IsTrue(areArraysEqual(expected, actual));
        }

        [TestMethod]
        public void expectedLengthTest1()
        {
            Solver target = new Solver(); // TODO: Initialize to an appropriate value
            string[] data = { "1", "2", "0" }; // TODO: Initialize to an appropriate value
            int expected = 3*3;

            int actual=target.loadDataAsBooleans(data).Length;
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region solverTests
        [TestMethod()]
        public void solveDefaultTest()
        {
            Solver target = new Solver(); // TODO: Initialize to an appropriate value
            string[] data = { }; // TODO: Initialize to an appropriate value
            double expected =-1; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.solve(data);
            Assert.AreEqual(expected,actual);
        }

        [TestMethod()]
        public void solveTest1()
        {
            Solver target = new Solver(); // TODO: Initialize to an appropriate value
            string[] data = {""}; // TODO: Initialize to an appropriate value
            double expected = 2; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.solve(data);
            Assert.AreEqual(expected, actual);
        }
        #endregion

        bool areArraysEqual(IComparable[] array1, IComparable[] array2)
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
            int rowLength = (int)Math.Sqrt(array1.Length),colLength=rowLength;
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength ; j++)
                {
                    if (array1[i,j]!=array2[i,j])
                        return false;
                }
            }
            return true;
        }
    }
}
