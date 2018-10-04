namespace org.telegram.api.update
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.webpage;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Implements(new string[] { "org.telegram.api.update.TLChannelUpdate" })]
    public class TLUpdateChannelWebPage : TLAbsUpdate, TLChannelUpdate
    {
        private int channelId;
        public const int CLASS_ID = 0x40771900;
        private int pts;
        private int ptsCount;
        private TLAbsWebPage webPage;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        public TLUpdateChannelWebPage()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateChannelWebPage(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 13, 0x6c, 0x77, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.channelId = StreamingUtils.readInt(stream);
            this.webPage = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsWebPage>.Value);
            this.pts = StreamingUtils.readInt(stream);
            this.ptsCount = StreamingUtils.readInt(stream);
        }

        public virtual int getChannelId() => 
            this.channelId;

        public override int getClassId() => 
            0x40771900;

        public override int getPts() => 
            this.pts;

        public override int getPtsCount() => 
            this.ptsCount;

        public virtual TLAbsWebPage getWebPage() => 
            this.webPage;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 5, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.channelId, stream);
            StreamingUtils.writeTLObject(this.webPage, stream);
            StreamingUtils.writeInt(this.pts, stream);
            StreamingUtils.writeInt(this.ptsCount, stream);
        }

        public override string toString() => 
            "updateChannelWebPage#40771900";
    }
}

