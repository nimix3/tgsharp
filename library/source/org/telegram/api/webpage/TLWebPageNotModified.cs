namespace org.telegram.api.webpage
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLWebPageNotModified : TLAbsWebPage
    {
        public const int CLASS_ID = -2054908813;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68 })]
        public TLWebPageNotModified()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLWebPageNotModified(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getClassId() => 
            -2054908813;

        public override string toString() => 
            "webPageNotModified#85849473";
    }
}

