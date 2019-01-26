using System;
using System.Runtime.Serialization;

namespace Samples.DataModel
{
    [DataContract(Namespace ="http://www.williamgryan.mobi/Book/70-487")]
    [Flags]
    public enum AnswerDetails
    {
        [EnumMember]
        A = 0x0,
        [EnumMember]
        B = 0x1,
        [EnumMember]
        C = 0x2,
        [EnumMember]
        D = 0x4,
        [EnumMember]
        All = 0x8
    }
}
