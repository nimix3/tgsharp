namespace org.telegram.mtproto.tl
{
    using IKVM.Attributes;
    using java.io;
    using java.lang;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class MTInvokeAfter : TLObject
    {
        public const int CLASS_ID = -878758099;
        private long dependMsgId;
        private byte[] request;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa4, 0x68, 0x67, 0x67 })]
        public MTInvokeAfter(long dependMsgId, byte[] request)
        {
            this.dependMsgId = dependMsgId;
            this.request = request;
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected MTInvokeAfter(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(0x35)]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            Throwable.__<suppressFillInStackTrace>();
            throw new UnsupportedOperationException("Unable to deserialize invokeAfterMsg#-878758099");
        }

        public override int getClassId() => 
            -878758099;

        public virtual long getDependMsgId() => 
            this.dependMsgId;

        public virtual byte[] getRequest() => 
            this.request;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbd, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.dependMsgId, stream);
            StreamingUtils.writeByteArray(this.request, stream);
        }

        public override string toString() => 
            "mTInvokeAfter#cb9f372d";
    }
}

