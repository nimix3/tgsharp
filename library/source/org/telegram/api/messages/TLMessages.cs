namespace org.telegram.api.messages
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessages : TLAbsMessages
    {
        public const int CLASS_ID = -1938715001;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68 })]
        public TLMessages()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessages(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb9, 0x6d, 0x6d, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.messages = StreamingUtils.readTLVector(stream, context);
            base.chats = StreamingUtils.readTLVector(stream, context);
            base.users = StreamingUtils.readTLVector(stream, context);
        }

        public override int getClassId() => 
            -1938715001;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb2, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(base.messages, stream);
            StreamingUtils.writeTLVector(base.chats, stream);
            StreamingUtils.writeTLVector(base.users, stream);
        }

        public override string toString() => 
            "messages.messages#8c718e87";
    }
}

