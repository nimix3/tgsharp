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
    public class TLDifferenceSlice : TLAbsDifference
    {
        public const int CLASS_ID = -1459938943;
        private TLUpdatesState intermediateState;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xae, 0x68 })]
        public TLDifferenceSlice()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDifferenceSlice(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
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
            this.intermediateState = StreamingUtils.readTLObject(stream, context);
        }

        public override int getClassId() => 
            -1459938943;

        public virtual TLUpdatesState getIntermediateState() => 
            this.intermediateState;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 11, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(base.newMessages, stream);
            StreamingUtils.writeTLVector(base.newEncryptedMessages, stream);
            StreamingUtils.writeTLVector(base.otherUpdates, stream);
            StreamingUtils.writeTLVector(base.chats, stream);
            StreamingUtils.writeTLVector(base.users, stream);
            StreamingUtils.writeTLObject(this.intermediateState, stream);
        }

        public virtual void setIntermediateState(TLUpdatesState intermediateState)
        {
            this.intermediateState = intermediateState;
        }

        public override string toString() => 
            "updates.differenceSlice#a8fb1981";
    }
}

