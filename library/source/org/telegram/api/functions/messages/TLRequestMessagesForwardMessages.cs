namespace org.telegram.api.functions.messages
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.input.peer;
    using org.telegram.api.updates;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/updates/TLAbsUpdates;>;")]
    public class TLRequestMessagesForwardMessages : TLMethod
    {
        public const int CLASS_ID = 0x708e0195;
        private const int FLAG_BACKGROUND = 0x40;
        private const int FLAG_BROADCAST = 0x10;
        private const int FLAG_SILENT = 0x20;
        private const int FLAG_UNUSED0 = 1;
        private const int FLAG_UNUSED1 = 2;
        private const int FLAG_UNUSED2 = 4;
        private const int FLAG_UNUSED3 = 8;
        private const int FLAG_UNUSED7 = 0x80;
        private const int FLAG_WITH_MY_SCORE = 0x100;
        private int flags;
        private TLAbsInputPeer fromPeer;
        private TLIntVector id;
        private TLLongVector randomId;
        private TLAbsInputPeer toPeer;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xbb, 0x68 })]
        public TLRequestMessagesForwardMessages()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesForwardMessages(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x13)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x6b, 0x6c, 0x72, 0x6d, 0x6d, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.fromPeer = StreamingUtils.readTLObject(stream, context);
            this.id = StreamingUtils.readTLIntVector(stream, context);
            this.randomId = StreamingUtils.readTLLongVector(stream, context);
            this.toPeer = StreamingUtils.readTLObject(stream, context);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 4, 0x68, 0x63, 0x90, 0x68, 0x87 })]
        public virtual TLAbsUpdates deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLAbsUpdates)
            {
                return (TLAbsUpdates) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLAbsUpdates>.Value.getName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        [LineNumberTable(new byte[] { 0x9f, 110, 0xa2, 0x63, 0x91, 0x8f })]
        public virtual void enableBackground(bool enabled)
        {
            if (enabled)
            {
                this.flags |= 0x40;
            }
            else
            {
                this.flags &= -65;
            }
        }

        [LineNumberTable(new byte[] { 0x9f, 0x72, 0xa2, 0x63, 0x91, 0x8f })]
        public virtual void enableBroadcast(bool enabled)
        {
            if (enabled)
            {
                this.flags |= 0x10;
            }
            else
            {
                this.flags &= -17;
            }
        }

        [LineNumberTable(new byte[] { 0x9f, 0x70, 0xa2, 0x63, 0x91, 0x8f })]
        public virtual void enableSilent(bool enabled)
        {
            if (enabled)
            {
                this.flags |= 0x20;
            }
            else
            {
                this.flags &= -33;
            }
        }

        [LineNumberTable(new byte[] { 0x9f, 0x6c, 0xa2, 0x63, 0x94, 0x92 })]
        public virtual void enableWithMyScore(bool enabled)
        {
            if (enabled)
            {
                this.flags |= 0x100;
            }
            else
            {
                this.flags &= -257;
            }
        }

        public override int getClassId() => 
            0x708e0195;

        public virtual int getFlags() => 
            this.flags;

        public virtual TLAbsInputPeer getFromPeer() => 
            this.fromPeer;

        public virtual TLIntVector getId() => 
            this.id;

        public virtual TLLongVector getRandomId() => 
            this.randomId;

        public virtual TLAbsInputPeer getToPeer() => 
            this.toPeer;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x62, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLObject(this.fromPeer, stream);
            StreamingUtils.writeTLVector(this.id, stream);
            StreamingUtils.writeTLVector(this.randomId, stream);
            StreamingUtils.writeTLObject(this.toPeer, stream);
        }

        public virtual void setFlags(int flags)
        {
            this.flags = flags;
        }

        public virtual void setFromPeer(TLAbsInputPeer fromPeer)
        {
            this.fromPeer = fromPeer;
        }

        public virtual void setId(TLIntVector value)
        {
            this.id = value;
        }

        public virtual void setRandomId(TLLongVector randomId)
        {
            this.randomId = randomId;
        }

        public virtual void setToPeer(TLAbsInputPeer toPeer)
        {
            this.toPeer = toPeer;
        }

        public override string toString() => 
            "messages.forwardMessages#708e0195";
    }
}

