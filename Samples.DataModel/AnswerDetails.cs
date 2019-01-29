using System;
using System.Runtime.Serialization;

namespace Samples.DataModel
{
    [DataContract(Namespace ="http://www.williamgryan.mobi/Book/70-487")]
    [Flags]
    public enum AnswerDetails: int
    {
        [EnumMember(Value = "1")]
        A = 0x0,
        [EnumMember(Value = "2")]
        B = 0x1,
        [EnumMember(Value = "3")]
        C = 0x2,
        [EnumMember(Value = "Bill")]
        D = 0x4,
        [EnumMember(Value = "Ryan")]
        All = 0x8
    }
}
