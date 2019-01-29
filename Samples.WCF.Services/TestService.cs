using Samples.DataModel;
using System;
using System.ServiceModel;

namespace Samples.WCF.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class TestService : ITestService
    {

        public AnswerSet[] GetQuestionAnswers(int questionNumber)
        {
            AnswerSet[] CurrentAnswers = null;
            // Method implementation
            return CurrentAnswers;
        }

        public string GetQuestionText(int questionNumber)
        {
            if (questionNumber <= 0)
            {
                const string OutOfRangeMessage = "Question Ids must be a positive value greater that 0";
                IndexOutOfRangeException InvalidQuestionId = new IndexOutOfRangeException(OutOfRangeMessage);
                throw new FaultException<IndexOutOfRangeException>(InvalidQuestionId, OutOfRangeMessage);
            }
            string AnswerText = null;
            // Method implementation
            return AnswerText;
        }

        public string[] GetExamOutline(string examName)
        {
            throw new NotImplementedException();
        }

        public AnswerDetails GetAnswerDetails(int questionNumber)
        {
            AnswerDetails CurrentDetails = new AnswerDetails();
            // Method implementation
            return CurrentDetails;
        }
    }
}
