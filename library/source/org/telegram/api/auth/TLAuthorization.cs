namespace org.telegram.api.auth
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.user;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLAuthorization : TLObject
    {
        public const int CLASS_ID = -855308010;
        private const int FLAG_TMP_SESSIONS = 1;
        private int flags;
        private TLAbsUser user;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb6, 0x68 })]
        public TLAuthorization()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAuthorization(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x10, 0x6c, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.user = StreamingUtils.readTLObject(stream, context);
        }

        public override int getClassId() => 
            -855308010;

        public virtual TLAbsUser getUser() => 
            this.user;

        public virtual bool isTemporalSession() => 
            ((this.flags & 1) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 11, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLObject(this.user, stream);
        }

        public override string toString() => 
            "auth.authorization#cd050916";
    }
}

