namespace org.telegram.mtproto.tl
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class MTMessageCopy : TLObject
    {
        public const int CLASS_ID = -530561358;
        private MTMessage orig_message;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa6, 0x68 })]
        public MTMessageCopy()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68, 0x67 })]
        public MTMessageCopy(MTMessage orig_message)
        {
            this.orig_message = orig_message;
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected MTMessageCopy(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbc, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.orig_message = StreamingUtils.readTLObject(stream, context);
        }

        public override int getClassId() => 
            -530561358;

        public virtual MTMessage getOrig_message() => 
            this.orig_message;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb7, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.orig_message, stream);
        }

        public virtual void setOrig_message(MTMessage orig_message)
        {
            this.orig_message = orig_message;
        }

        public override string toString() => 
            "MTMessageCopy#e06046b2";
    }
}

