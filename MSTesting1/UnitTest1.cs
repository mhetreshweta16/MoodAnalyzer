using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzarProblem;
using System;

namespace MSTesting1
{
    [TestClass]
    public class UnitTest1
    {
        ModeAnalyserFactory factory = null;

        [TestInitialize]
        public void SetUp()
        {
            factory = new ModeAnalyserFactory();
        }

        [TestMethod]
        public void AnalyseHappyMood()
        {
            // Test Case 1
            //Arrange
            string message = null;
            string expected = "happy";

            //Act
            ModeAnalyzer modeAnalyzer = new ModeAnalyzer(message);
            string actual = modeAnalyzer.AnalyzeMood();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void getCustomNullException()
        {
            //Arrange
            string expected = "Message Should Not Be Null";
            ModeAnalyzer modeAnalyzer = new ModeAnalyzer(null);

            try
            {
                //Act
                string actual = modeAnalyzer.AnalyzeMood();

            }
            catch(CustomException ex)
            {

                //Assart
                Assert.AreEqual(expected, ex.Message);
            }

        }

        /// <summary>
        /// UC4
        /// Reflections the using default constructor.
        /// </summary>
        /// <exception cref="System.Exception"></exception>
        [TestMethod]
        public void ReflectionUsingDefaultConstructor()
        {
            ModeAnalyzer expected = new ModeAnalyzer();
            object obj = null;
            try
            {
                obj = factory.createMoodAnalyserObject("MoodAnalyzarProblem.ModeAnalyzer", "ModeAnalyzer");

            }
            catch (CustomException ex1)
            {
                throw new Exception(ex1.Message);
            }
            obj.Equals(expected);
        }

        /// <summary>
        /// UC5
        /// Gets the mood analyser using parametre constructor.
        /// </summary>
        /// <exception cref="System.Exception"></exception>
        [TestMethod]
        public void getMoodAnalyserUsingParametreConstructor()
        {
            string message = "I am in happy mood";
            ModeAnalyzer expected = new ModeAnalyzer(message);
            object actual = null;
            try
            {
                ModeAnalyserFactory factory = new ModeAnalyserFactory();
                //act
                actual = factory.CreateMoodAnalyserParameterObject("ModeAnalyzer", "ModeAnalyzer", message);

            }
            catch (CustomException exception)
            {
                throw new Exception(exception.Message);
            }
            actual.Equals(expected);
        }

    }
}
