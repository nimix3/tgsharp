namespace org.telegram.api.input.chat
{
    using IKVM.Attributes;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputChannelEmpty : TLAbsInputChannel
    {
        public const int CLASS_ID = -292807034;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0x9b, 0x68 })]
        public TLInputChannelEmpty()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputChannelEmpty(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public override int getChannelId() => 
            0;

        public override int getClassId() => 
            -292807034;

        public override string toString() => 
            "input.chat.TLInputChannelEmpty#ee8c1e86";
    }
}

