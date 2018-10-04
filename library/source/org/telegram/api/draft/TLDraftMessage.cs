namespace org.telegram.api.draft
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLDraftMessage : TLAbsDraftMessage
    {
        public const int CLASS_ID = -40996577;
        private int date;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/entity/TLAbsMessageEntity;>;")]
        private TLVector entities;
        private const int FLAG_ENTITIES = 8;
        private const int FLAG_NO_WEBPAGE = 2;
        private const int FLAG_REPLY_TO_MSG_ID = 1;
        private const int FLAG_UNUSED_2 = 4;
        private int flags;
        private string message;
        private int replyToMsgId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xaf, 0x68 })]
        public TLDraftMessage()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDraftMessage(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x22, 0x6c, 0x6a, 140, 0x6c, 0x6a, 0x92, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            if ((this.flags & 1) != 0)
            {
                this.replyToMsgId = StreamingUtils.readInt(stream);
            }
            this.message = StreamingUtils.readTLString(stream);
            if ((this.flags & 8) != 0)
            {
                this.entities = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsMessageEntity>.Value);
            }
            this.date = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            -40996577;

        public virtual int getDate() => 
            this.date;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/entity/TLAbsMessageEntity;>;")]
        public virtual TLVector getEntities() => 
            this.entities;

        public virtual string getMessage() => 
            this.message;

        public virtual int getReplyToMsgId() => 
            this.replyToMsgId;

        public virtual bool hasEntities() => 
            ((this.flags & 8) != 0);

        public virtual bool hasWebPreview() => 
            ((this.flags & 2) == 0);

        public virtual bool isReply() => 
            ((this.flags & 1) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x15, 0x6c, 0x6a, 140, 0x6c, 0x6a, 140, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeInt(this.replyToMsgId, stream);
            }
            StreamingUtils.writeTLString(this.message, stream);
            if ((this.flags & 8) != 0)
            {
                StreamingUtils.writeTLVector(this.entities, stream);
            }
            StreamingUtils.writeInt(this.date, stream);
        }

        public override string toString() => 
            "draftMessage#fd8e711f";
    }
}

