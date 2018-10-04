namespace org.telegram.api.messages.chats
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessagesChats : TLAbsMessagesChats
    {
        public const int CLASS_ID = 0x64ff9fd5;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa6, 0x68 })]
        public TLMessagesChats()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessagesChats(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb5, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.chats = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsChat>.Value);
        }

        public override int getClassId() => 
            0x64ff9fd5;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb0, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(base.chats, stream);
        }

        public override string toString() => 
            "messages.chats#64ff9fd5";
    }
}

