using System;
using System.Runtime.Serialization;

namespace Samples.DataModel
{
    [DataContract(Namespace = "487Sample")]
    [KnownType(typeof(EnglishQuestion))]
    [KnownType(typeof(MathQuestion))]
    public class QuestionManager
    {
        [DataMember] private Guid QuestionSetId;

        [DataMember] private QuestionBase ExamQuestion;
    }
}
