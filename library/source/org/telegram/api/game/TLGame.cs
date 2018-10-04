namespace org.telegram.api.game
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.document;
    using org.telegram.api.photo;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLGame : TLObject
    {
        private long accessHash;
        public const int CLASS_ID = -1107729093;
        private string description;
        private TLAbsDocument document;
        private const int FLAG_DOCUMENT = 1;
        private int flags;
        private long id;
        private TLAbsPhoto photo;
        private string shortName;
        private string title;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x13)]
        public TLGame()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLGame(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x24, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x77, 0x6a, 0x97 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.id = StreamingUtils.readLong(stream);
            this.accessHash = StreamingUtils.readLong(stream);
            this.shortName = StreamingUtils.readTLString(stream);
            this.title = StreamingUtils.readTLString(stream);
            this.description = StreamingUtils.readTLString(stream);
            this.photo = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsPhoto>.Value);
            if ((this.flags & 1) != 0)
            {
                this.document = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsDocument>.Value);
            }
        }

        public virtual long getAccessHash() => 
            this.accessHash;

        public override int getClassId() => 
            -1107729093;

        public virtual string getDescription() => 
            this.description;

        public virtual TLAbsDocument getDocument() => 
            this.document;

        public virtual long getId() => 
            this.id;

        public virtual TLAbsPhoto getPhoto() => 
            this.photo;

        public virtual string getShortName() => 
            this.shortName;

        public virtual string getTitle() => 
            this.title;

        public virtual bool hasDocument() => 
            ((this.flags & 1) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x16, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6c, 0x6a, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeLong(this.id, stream);
            StreamingUtils.writeLong(this.accessHash, stream);
            StreamingUtils.writeTLString(this.shortName, stream);
            StreamingUtils.writeTLString(this.title, stream);
            StreamingUtils.writeTLString(this.description, stream);
            StreamingUtils.writeTLObject(this.photo, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeTLObject(this.document, stream);
            }
        }

        public override string toString() => 
            "game#bdf9653b";
    }
}

