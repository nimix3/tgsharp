namespace org.telegram.api.input.messages.filter
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessagesFilterPhotos : TLAbsMessagesFilter
    {
        public const int CLASS_ID = -1777752804;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(6)]
        public TLMessagesFilterPhotos()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessagesFilterPhotos(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -1777752804;

        public override string toString() => 
            "inputMessagesFilterPhotos#9609a51c";
    }
}

