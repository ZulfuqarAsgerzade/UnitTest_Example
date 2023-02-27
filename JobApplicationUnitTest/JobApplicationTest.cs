using JobApplicationLibrary;
using JobApplicationLibrary.Models;

namespace JobApplicationUnitTest
{
    public class JobApplicationTest
    {
        [Test]
        public void FunctionUnderTest_WithUnderAge_UnderCondition()
        {
            // Arrange
            ApplicationEvaluator evaluator = new ApplicationEvaluator();
            JobApplication form = new JobApplication()
            {
                Applicant = new Applicant()
                {
                    Age = 18
                }
            };

            // Act
            var result = evaluator.Evaluate(form);

            // Assert
            Assert.AreEqual(ApplicationResult.AutoAccepted, result);
        }
    }
}
