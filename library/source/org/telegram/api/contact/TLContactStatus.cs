namespace org.telegram.api.contact
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.user.status;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLContactStatus : TLObject
    {
        public const int CLASS_ID = -748155807;
        private TLAbsUserStatus status;
        private int userId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 180, 0x68 })]
        public TLContactStatus()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLContactStatus(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x15, 0x6c, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.userId = StreamingUtils.readInt(stream);
            this.status = StreamingUtils.readTLObject(stream, context);
        }

        public override int getClassId() => 
            -748155807;

        public virtual int getUserId() => 
            this.userId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 15, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.userId, stream);
            StreamingUtils.writeTLObject(this.status, stream);
        }

        public virtual void setUserId(int value)
        {
            this.userId = value;
        }

        public override string toString() => 
            "contactStatus#d3680c61";
    }
}

