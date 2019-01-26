using System;
using System.Runtime.Serialization;

namespace Samples.DataModel
{
    [DataContract(Name ="Answers", Namespace ="http://www.williamgryan.mobi/Book/70-487")]
    public class AnswerSet
    {
        [DataMember(Name ="QuestionId", IsRequired =true)]
        public int QuestionId { get; set; }

        [DataMember]
        public Guid AnswerId { get; set; }

        [DataMember]
        public string AnswerTest { get; set; }
    }
}
