namespace org.telegram.api.user.status
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUserStatusOnline : TLAbsUserStatus
    {
        public const int CLASS_ID = -306628279;
        private int expires;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa7, 0x68 })]
        public TLUserStatusOnline()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUserStatusOnline(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 7, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.expires = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            -306628279;

        public virtual int getExpires() => 
            this.expires;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 2, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.expires, stream);
        }

        public virtual void setExpires(int expires)
        {
            this.expires = expires;
        }

        public override string toString() => 
            "userStatusOnline#edb93949";
    }
}

