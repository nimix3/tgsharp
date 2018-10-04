namespace org.telegram.api.functions.messages
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.input.peer;
    using org.telegram.api.messages;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/messages/TLMessagesBotCallbackAnswer;>;")]
    public class TLRequestMessagesGetBotCallbackAnswer : TLMethod
    {
        public const int CLASS_ID = -2130010132;
        private TLBytes data;
        private const int FLAG_DATA = 1;
        private const int FLAG_GAME = 2;
        private int flags;
        private int msgId;
        private TLAbsInputPeer peer;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb2, 0x68 })]
        public TLRequestMessagesGetBotCallbackAnswer()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesGetBotCallbackAnswer(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x12)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x39, 0x6c, 0x77, 0x6c, 0x6a, 0x8d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.peer = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsInputPeer>.Value);
            this.msgId = StreamingUtils.readInt(stream);
            if ((this.flags & 1) != 0)
            {
                this.data = StreamingUtils.readTLBytes(stream, context);
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0, 0x68, 0x63, 0x90, 0x68, 0x87 })]
        public virtual TLMessagesBotCallbackAnswer deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLMessagesBotCallbackAnswer)
            {
                return (TLMessagesBotCallbackAnswer) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLMessagesBotCallbackAnswer>.Value.getName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getName()).toString());
        }

        [LineNumberTable(new byte[] { 0x9f, 0x79, 0x62, 0x63, 0x90, 0x8f })]
        public virtual void enableGame(bool enabled)
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
            -2130010132;

        public virtual TLBytes getData() => 
            this.data;

        public virtual int getflags() => 
            this.flags;

        public virtual int getMsgId() => 
            this.msgId;

        public virtual TLAbsInputPeer getPeer() => 
            this.peer;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x2e, 0x6c, 0x6c, 0x6c, 0x6a, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLObject(this.peer, stream);
            StreamingUtils.writeInt(this.msgId, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeTLBytes(this.data, stream);
            }
        }

        public virtual void setData(TLBytes data)
        {
            this.data = data;
        }

        public virtual void setflag(int flags)
        {
            this.flags = flags;
        }

        public virtual void setMsgId(int msgId)
        {
            this.msgId = msgId;
        }

        public virtual void setPeer(TLAbsInputPeer peer)
        {
            this.peer = peer;
        }

        public override string toString() => 
            "messages.getBotCallbackAnswer#810a9fec";
    }
}

