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

       

    }
}
