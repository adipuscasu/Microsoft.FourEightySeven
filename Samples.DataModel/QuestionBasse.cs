using System.Runtime.Serialization;

namespace Samples.DataModel
{
    [DataContract]
    public class QuestionBase
    {
        [DataMember]
        public string Id { get; set; }
    }
}
