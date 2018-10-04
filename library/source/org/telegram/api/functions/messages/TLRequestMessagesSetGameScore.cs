namespace org.telegram.api.functions.messages
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.input.peer;
    using org.telegram.api.input.user;
    using org.telegram.api.updates;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/updates/TLAbsUpdates;>;")]
    public class TLRequestMessagesSetGameScore : TLMethod
    {
        public const int CLASS_ID = -1896289088;
        private const int FLAG_EDITMESSAGE = 1;
        private const int FLAG_FORCE = 2;
        private int flags;
        private int id;
        private TLAbsInputPeer peer;
        private int score;
        private TLAbsInputUser userId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb3, 0x68 })]
        public TLRequestMessagesSetGameScore()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesSetGameScore(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x12)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x3f, 0x6c, 0x77, 0x6c, 0x77, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.peer = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsInputPeer>.Value);
            this.id = StreamingUtils.readInt(stream);
            this.userId = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsInputUser>.Value);
            this.score = StreamingUtils.readInt(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbc, 0x68, 0x63, 0x70, 0x68, 0x67 })]
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
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLAbsUpdates>.Value.getCanonicalName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        [LineNumberTable(new byte[] { 0x9f, 0x79, 0xa2, 0x63, 0x90, 0x8f })]
        public virtual void enableEditMessage(bool enabled)
        {
            if (enabled)
            {
                this.flags |= 1;
            }
            else
            {
                this.flags &= -2;
            }
        }

        [LineNumberTable(new byte[] { 0x9f, 0x77, 0xa2, 0x63, 0x90, 0x8f })]
        public virtual void enableForce(bool enabled)
        {
            if (enabled)
            {
                this.flags |= 2;
            }
            else
            {
                this.flags &= -3;
            }
        }

        public override int getClassId() => 
            -1896289088;

        public virtual int getId() => 
            this.id;

        public virtual TLAbsInputPeer getPeer() => 
            this.peer;

        public virtual int getScore() => 
            this.score;

        public virtual TLAbsInputUser getUserId() => 
            this.userId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x36, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLObject(this.peer, stream);
            StreamingUtils.writeInt(this.id, stream);
            StreamingUtils.writeTLObject(this.userId, stream);
            StreamingUtils.writeInt(this.score, stream);
        }

        public virtual void setId(int id)
        {
            this.id = id;
        }

        public virtual void setPeer(TLAbsInputPeer peer)
        {
            this.peer = peer;
        }

        public virtual void setScore(int score)
        {
            this.score = score;
        }

        public virtual void setUserId(TLAbsInputUser userId)
        {
            this.userId = userId;
        }

        public override string toString() => 
            "messages.setGameScore#8ef8ecc0";
    }
}

