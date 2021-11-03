using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzarProblem;

namespace MSTesting1
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]
        public void AnalyseHappyMood()
        {
            // Test Case 1
            //Arrange
            string message = "I am in sad mood";
            string expected = "SAD";

            //Act
            ModeAnalyzer modeAnalyzer = new ModeAnalyzer();
            string actual = modeAnalyzer.AnalyzeMood(message);

            //Assert
            Assert.AreEqual(expected, actual);

        }

       

    }
}
