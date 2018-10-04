namespace org.telegram.api.input.messages.filter
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessagesFilterDocument : TLAbsMessagesFilter
    {
        public const int CLASS_ID = -1629621880;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(6)]
        public TLMessagesFilterDocument()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessagesFilterDocument(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -1629621880;

        public override string toString() => 
            "inputMessagesFilterDocument#9eddf188";
    }
}

