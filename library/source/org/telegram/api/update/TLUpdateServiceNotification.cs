namespace org.telegram.api.update
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.message.media;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdateServiceNotification : TLAbsUpdate
    {
        public const int CLASS_ID = -337352679;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/entity/TLAbsMessageEntity;>;")]
        private TLVector entities;
        private const int FLAG_INBOX_DATE = 2;
        private const int FLAG_POPUP = 1;
        private int flags;
        private int inboxDate;
        private TLAbsMessageMedia media;
        private string message;
        private string type;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb2, 0x68 })]
        public TLUpdateServiceNotification()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateServiceNotification(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x20, 0x6c, 0x6a, 140, 0x6c, 0x6c, 0x77, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            if ((this.flags & 2) != 0)
            {
                this.inboxDate = StreamingUtils.readInt(stream);
            }
            this.type = StreamingUtils.readTLString(stream);
            this.message = StreamingUtils.readTLString(stream);
            this.media = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsMessageMedia>.Value);
            this.entities = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsMessageEntity>.Value);
        }

        public override int getClassId() => 
            -337352679;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/message/entity/TLAbsMessageEntity;>;")]
        public virtual TLVector getEntities() => 
            this.entities;

        public virtual int getFlags() => 
            this.flags;

        public virtual TLAbsMessageMedia getMedia() => 
            this.media;

        public virtual string getMessage() => 
            this.message;

        public virtual string getType() => 
            this.type;

        public virtual bool isPopup() => 
            ((this.flags & 1) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x13, 0x6c, 0x6a, 140, 0x6c, 0x6c, 0x6c, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            if ((this.flags & 2) != 0)
            {
                StreamingUtils.writeInt(this.inboxDate, stream);
            }
            StreamingUtils.writeTLString(this.type, stream);
            StreamingUtils.writeTLString(this.message, stream);
            StreamingUtils.writeTLObject(this.media, stream);
            StreamingUtils.writeTLVector(this.entities, stream);
        }

        public override string toString() => 
            "updateServiceNotification#ebe46819";
    }
}

