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
    public class TLUserStatusOffline : TLAbsUserStatus
    {
        public const int CLASS_ID = 0x8c703f;
        private int wasOnline;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa7, 0x68 })]
        public TLUserStatusOffline()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUserStatusOffline(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 7, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.wasOnline = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            0x8c703f;

        public virtual int getWasOnline() => 
            this.wasOnline;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 2, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.wasOnline, stream);
        }

        public virtual void setWasOnline(int wasOnline)
        {
            this.wasOnline = wasOnline;
        }

        public override string toString() => 
            "userStatusOffline#8c703f";
    }
}

