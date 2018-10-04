namespace org.telegram.api.functions.messages
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.messages;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/messages/TLMessagesPeerDialogs;>;")]
    public class TLRequestMessagesGetPeerDialogs : TLMethod
    {
        public const int CLASS_ID = 0x2d9776b9;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/input/peer/TLAbsInputPeer;>;")]
        private TLVector peers;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xac, 0x68 })]
        public TLRequestMessagesGetPeerDialogs()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesGetPeerDialogs(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x12)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 14, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.peers = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsInputPeer>.Value);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb5, 0x68, 0x63, 0x90, 0x68, 0x87 })]
        public virtual TLMessagesPeerDialogs deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLMessagesPeerDialogs)
            {
                return (TLMessagesPeerDialogs) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLMessagesPeerDialogs>.Value.getName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            0x2d9776b9;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/input/peer/TLAbsInputPeer;>;")]
        public virtual TLVector getPeers() => 
            this.peers;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 9, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(this.peers, stream);
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/input/peer/TLAbsInputPeer;>;)V")]
        public virtual void setPeers(TLVector peers)
        {
            this.peers = peers;
        }

        public override string toString() => 
            "messages.getPeerDialogs#2d9776b9";
    }
}

