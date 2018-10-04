namespace org.telegram.api.updates.difference
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.updates;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLDifference : TLAbsDifference
    {
        public const int CLASS_ID = 0xf49ca0;
        private TLUpdatesState state;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xae, 0x68 })]
        public TLDifference()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDifference(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x16, 0x6d, 0x6d, 0x6d, 0x6d, 0x6d, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.newMessages = StreamingUtils.readTLVector(stream, context);
            base.newEncryptedMessages = StreamingUtils.readTLVector(stream, context);
            base.otherUpdates = StreamingUtils.readTLVector(stream, context);
            base.chats = StreamingUtils.readTLVector(stream, context);
            base.users = StreamingUtils.readTLVector(stream, context);
            this.state = StreamingUtils.readTLObject(stream, context);
        }

        public override int getClassId() => 
            0xf49ca0;

        public virtual TLUpdatesState getState() => 
            this.state;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 11, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(base.newMessages, stream);
            StreamingUtils.writeTLVector(base.newEncryptedMessages, stream);
            StreamingUtils.writeTLVector(base.otherUpdates, stream);
            StreamingUtils.writeTLVector(base.chats, stream);
            StreamingUtils.writeTLVector(base.users, stream);
            StreamingUtils.writeTLObject(this.state, stream);
        }

        public virtual void setState(TLUpdatesState state)
        {
            this.state = state;
        }

        public override string toString() => 
            "updates.difference#f49ca0";
    }
}

