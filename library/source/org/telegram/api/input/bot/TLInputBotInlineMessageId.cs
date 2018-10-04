namespace org.telegram.api.input.bot
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputBotInlineMessageId : TLObject
    {
        private long accessHash;
        public const int CLASS_ID = -1995686519;
        private int dcId;
        private long id;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        public TLInputBotInlineMessageId()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputBotInlineMessageId(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 5, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.dcId = StreamingUtils.readInt(stream);
            this.id = StreamingUtils.readLong(stream);
            this.accessHash = StreamingUtils.readLong(stream);
        }

        public virtual long getAccessHash() => 
            this.accessHash;

        public override int getClassId() => 
            -1995686519;

        public virtual int getDcId() => 
            this.dcId;

        public virtual long getId() => 
            this.id;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 190, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.dcId, stream);
            StreamingUtils.writeLong(this.id, stream);
            StreamingUtils.writeLong(this.accessHash, stream);
        }

        public override string toString() => 
            "inputBotInlineMessageID#890c3d89";
    }
}

