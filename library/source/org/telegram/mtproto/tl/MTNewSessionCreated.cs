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
    public class MTNewSessionCreated : TLObject
    {
        public const int CLASS_ID = -1631450872;
        private long firstMsgId;
        private long serverSalt;
        private long uniqId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xaf, 0x88 })]
        public MTNewSessionCreated()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected MTNewSessionCreated(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68, 0x67, 0x67, 0x67 })]
        public MTNewSessionCreated(long firstMsgId, long uniqId, long serverSalt)
        {
            this.firstMsgId = firstMsgId;
            this.uniqId = uniqId;
            this.serverSalt = serverSalt;
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 13, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.firstMsgId = StreamingUtils.readLong(stream);
            this.uniqId = StreamingUtils.readLong(stream);
            this.serverSalt = StreamingUtils.readLong(stream);
        }

        public override int getClassId() => 
            -1631450872;

        public virtual long getFirstMsgId() => 
            this.firstMsgId;

        public virtual long getServerSalt() => 
            this.serverSalt;

        public virtual long getUniqId() => 
            this.uniqId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 6, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.firstMsgId, stream);
            StreamingUtils.writeLong(this.uniqId, stream);
            StreamingUtils.writeLong(this.serverSalt, stream);
        }

        public override string toString() => 
            "new_session_created#9ec20908";
    }
}

