namespace org.telegram.api.update
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.geo.point;
    using org.telegram.api.input.bot;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdateBotInlineSend : TLAbsUpdate
    {
        public const int CLASS_ID = 0xe48f964;
        private const int FLAG_GEOPOINT = 1;
        private const int FLAG_MSG_ID = 2;
        private int flags;
        private TLAbsGeoPoint geo;
        private string id;
        private TLInputBotInlineMessageId msgId;
        private string query;
        private int userId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 3, 0x68 })]
        public TLUpdateBotInlineSend()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateBotInlineSend(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x2a, 0x6c, 0x6c, 0x6c, 0x6a, 0x92, 0x6c, 0x6a, 0x92 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.userId = StreamingUtils.readInt(stream);
            this.query = StreamingUtils.readTLString(stream);
            if ((this.flags & 1) != 0)
            {
                this.geo = StreamingUtils.readTLObject(stream, context);
            }
            this.id = StreamingUtils.readTLString(stream);
            if ((this.flags & 1) != 0)
            {
                this.msgId = StreamingUtils.readTLObject(stream, context);
            }
        }

        public override int getClassId() => 
            0xe48f964;

        public virtual string getId() => 
            this.id;

        public virtual string getQuery() => 
            this.query;

        public virtual int getUserId() => 
            this.userId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x18, 0x6c, 0x6c, 0x6c, 0x6a, 140, 0x6c, 0x6a, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeInt(this.userId, stream);
            StreamingUtils.writeTLString(this.query, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeTLObject(this.geo, stream);
            }
            StreamingUtils.writeTLString(this.id, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeTLObject(this.msgId, stream);
            }
        }

        public override string toString() => 
            "updateBotInlineSend#e48f964";
    }
}

