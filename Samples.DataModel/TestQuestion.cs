using System.Runtime.Serialization;

namespace Samples.DataModel
{
    [DataContract(Namespace ="http://www.williamgryan.mobi/Book/70-487")]
    public class TestQuestion
    {
        [DataMember]
        public int QuestionId { get; set; }

        [DataMember]
        public string QuestionText { get; set; }

        [DataMember]
        public AnswerSet[] AvailableAnswers { get; set; }

        [DataMember]
        public AnswerDetails Answers { get; set; }
    }
}
