namespace org.telegram.api.update
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
    public class TLUpdateUserStatus : TLAbsUpdate
    {
        public const int CLASS_ID = 0x1bfbd823;
        private TLAbsUserStatus status;
        private int userId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68 })]
        public TLUpdateUserStatus()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateUserStatus(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1c, 0x6c, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.userId = StreamingUtils.readInt(stream);
            this.status = StreamingUtils.readTLObject(stream, context);
        }

        public override int getClassId() => 
            0x1bfbd823;

        public virtual TLAbsUserStatus getStatus() => 
            this.status;

        public virtual int getUserId() => 
            this.userId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x16, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.userId, stream);
            StreamingUtils.writeTLObject(this.status, stream);
        }

        public virtual void setStatus(TLAbsUserStatus status)
        {
            this.status = status;
        }

        public virtual void setUserId(int userId)
        {
            this.userId = userId;
        }

        public override string toString() => 
            "updateUserStatus#1bfbd823";
    }
}

