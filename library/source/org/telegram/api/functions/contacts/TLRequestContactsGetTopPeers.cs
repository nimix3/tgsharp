namespace org.telegram.api.functions.contacts
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.contacts.toppeers;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/contacts/toppeers/TLAbsContactsTopPeers;>;")]
    public class TLRequestContactsGetTopPeers : TLMethod
    {
        public const int CLASS_ID = -728224331;
        private const int FLAG_BOTS_INLINE = 4;
        private const int FLAG_BOTS_PM = 2;
        private const int FLAG_CHANNELS = 0x8000;
        private const int FLAG_CORRESPONDENTS = 1;
        private const int FLAG_GROUPS = 0x400;
        private const int FLAG_UNUSED_11 = 0x800;
        private const int FLAG_UNUSED_12 = 0x1000;
        private const int FLAG_UNUSED_13 = 0x2000;
        private const int FLAG_UNUSED_14 = 0x4000;
        private const int FLAG_UNUSED_3 = 8;
        private const int FLAG_UNUSED_4 = 0x10;
        private const int FLAG_UNUSED_5 = 0x20;
        private const int FLAG_UNUSED_6 = 0x40;
        private const int FLAG_UNUSED_7 = 0x80;
        private const int FLAG_UNUSED_8 = 0x100;
        private const int FLAG_UNUSED_9 = 0x200;
        private int flags;
        private int hash;
        private int limit;
        private int offset;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 190, 0x68 })]
        public TLRequestContactsGetTopPeers()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestContactsGetTopPeers(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x10)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x59, 0x6c, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.offset = StreamingUtils.readInt(stream);
            this.limit = StreamingUtils.readInt(stream);
            this.hash = StreamingUtils.readInt(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 7, 0x68, 0x63, 0x70, 0x68, 0x67 })]
        public virtual TLAbsContactsTopPeers deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLAbsContactsTopPeers)
            {
                return (TLAbsContactsTopPeers) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLAbsContactsTopPeers>.Value.getCanonicalName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        [LineNumberTable(new byte[] { 60, 110 })]
        public virtual void enableBotsInline()
        {
            this.flags |= 4;
        }

        [LineNumberTable(new byte[] { 0x34, 110 })]
        public virtual void enableBotsPM()
        {
            this.flags |= 2;
        }

        [LineNumberTable(new byte[] { 0x4c, 0x72 })]
        public virtual void enableChannels()
        {
            this.flags |= 0x8000;
        }

        [LineNumberTable(new byte[] { 0x2c, 110 })]
        public virtual void enableCorrespondents()
        {
            this.flags |= 1;
        }

        [LineNumberTable(new byte[] { 0x44, 0x72 })]
        public virtual void enableGroups()
        {
            this.flags |= 0x400;
        }

        public override int getClassId() => 
            -728224331;

        public virtual int getHash() => 
            this.hash;

        public virtual int getLimit() => 
            this.limit;

        public virtual int getOffset() => 
            this.offset;

        public virtual bool hasBotsInline() => 
            ((this.flags & 4) != 0);

        public virtual bool hasBotsPM() => 
            ((this.flags & 2) != 0);

        public virtual bool hasChannels() => 
            ((this.flags & 0x8000) != 0);

        public virtual bool hasCorrespondents() => 
            ((this.flags & 1) != 0);

        public virtual bool hasGroups() => 
            ((this.flags & 0x400) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x51, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeInt(this.offset, stream);
            StreamingUtils.writeInt(this.limit, stream);
            StreamingUtils.writeInt(this.hash, stream);
        }

        public virtual void setHash(int hash)
        {
            this.hash = hash;
        }

        public virtual void setLimit(int limit)
        {
            this.limit = limit;
        }

        public virtual void setOffset(int offset)
        {
            this.offset = offset;
        }

        public override string toString() => 
            "contacts.getTopPeers#d4982db5";
    }
}

