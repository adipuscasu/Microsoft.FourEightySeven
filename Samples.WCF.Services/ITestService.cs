using Samples.DataModel;
using System;
using System.ServiceModel;

namespace Samples.WCF.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Namespace = "http://www.williamgryan.mobi/Books/70-487")]
    public interface ITestService
    {
        [OperationContract]
        AnswerDetails GetAnswerDetails(int questionNumber);

        [OperationContract]
        AnswerSet[] GetQuestionAnswers(int questionNumber);

        [OperationContract]
        [FaultContract(typeof(IndexOutOfRangeException))]
        string GetQuestionText(int questionNumber);

        [OperationContract]
        string[] GetExamOutline(string examName);

    }


}
