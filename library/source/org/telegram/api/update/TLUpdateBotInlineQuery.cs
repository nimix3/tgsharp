namespace org.telegram.api.update
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.geo.point;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdateBotInlineQuery : TLAbsUpdate
    {
        public const int CLASS_ID = 0x54826690;
        private const int FLAG_GEOPOINT = 1;
        private int flags;
        private TLAbsGeoPoint geo;
        private string offset;
        private string query;
        private long queryId;
        private int userId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 1, 0x68 })]
        public TLUpdateBotInlineQuery()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateBotInlineQuery(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x2e, 0x6c, 0x6c, 0x6c, 0x6c, 0x6a, 0x92, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.queryId = StreamingUtils.readLong(stream);
            this.userId = StreamingUtils.readInt(stream);
            this.query = StreamingUtils.readTLString(stream);
            if ((this.flags & 1) != 0)
            {
                this.geo = StreamingUtils.readTLObject(stream, context);
            }
            this.offset = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            0x54826690;

        public virtual int getFlags() => 
            this.flags;

        public virtual TLAbsGeoPoint getGeo() => 
            this.geo;

        public virtual string getOffset() => 
            this.offset;

        public virtual string getQuery() => 
            this.query;

        public virtual long getQueryId() => 
            this.queryId;

        public virtual int getUserId() => 
            this.userId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x22, 0x6c, 0x6c, 0x6c, 0x6c, 0x6a, 140, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeLong(this.queryId, stream);
            StreamingUtils.writeInt(this.userId, stream);
            StreamingUtils.writeTLString(this.query, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeTLObject(this.geo, stream);
            }
            StreamingUtils.writeTLString(this.offset, stream);
        }

        public override string toString() => 
            "updateBotInlineQuery#54826690";
    }
}

