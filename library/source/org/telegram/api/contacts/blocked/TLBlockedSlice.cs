namespace org.telegram.api.contacts.blocked
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLBlockedSlice : TLAbsBlocked
    {
        public const int CLASS_ID = -1878523231;
        private int count;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 180, 0x68 })]
        public TLBlockedSlice()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLBlockedSlice(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x16, 0x6c, 0x6d, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.count = StreamingUtils.readInt(stream);
            base.blocked = StreamingUtils.readTLVector(stream, context);
            base.users = StreamingUtils.readTLVector(stream, context);
        }

        public override int getClassId() => 
            -1878523231;

        public virtual int getCount() => 
            this.count;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 15, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.count, stream);
            StreamingUtils.writeTLVector(base.blocked, stream);
            StreamingUtils.writeTLVector(base.users, stream);
        }

        public virtual void setCount(int value)
        {
            this.count = value;
        }

        public override string toString() => 
            "contacts.blockedSlice#900802a1";
    }
}

