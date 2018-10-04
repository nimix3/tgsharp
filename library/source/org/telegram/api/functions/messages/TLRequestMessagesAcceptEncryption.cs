namespace org.telegram.api.functions.messages
{
    using IKVM.Attributes;
    using java.io;
    using java.lang;
    using org.telegram.api.encrypted.chat;
    using org.telegram.api.input.encrypted;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/encrypted/chat/TLAbsEncryptedChat;>;")]
    public class TLRequestMessagesAcceptEncryption : TLMethod
    {
        public const int CLASS_ID = 0x3dbc0415;
        private TLBytes gB;
        private long keyFingerprint;
        private TLInputEncryptedChat peer;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xae, 0x68 })]
        public TLRequestMessagesAcceptEncryption()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesAcceptEncryption(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x12)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x3e, 0x72, 0x6d, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.peer = StreamingUtils.readTLObject(stream, context);
            this.gB = StreamingUtils.readTLBytes(stream, context);
            this.keyFingerprint = StreamingUtils.readLong(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb7, 0x68, 0x63, 0x70, 0x68, 0x67 })]
        public virtual TLAbsEncryptedChat deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLAbsEncryptedChat)
            {
                return (TLAbsEncryptedChat) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected org.telegram.api.encrypted.chat.TLAbsEncryptedChat, got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            0x3dbc0415;

        public virtual TLBytes getGB() => 
            this.gB;

        public virtual long getKeyFingerprint() => 
            this.keyFingerprint;

        public virtual TLInputEncryptedChat getPeer() => 
            this.peer;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x37, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.peer, stream);
            StreamingUtils.writeTLBytes(this.gB, stream);
            StreamingUtils.writeLong(this.keyFingerprint, stream);
        }

        public virtual void setGB(TLBytes value)
        {
            this.gB = value;
        }

        public virtual void setKeyFingerprint(long value)
        {
            this.keyFingerprint = value;
        }

        public virtual void setPeer(TLInputEncryptedChat value)
        {
            this.peer = value;
        }

        public override string toString() => 
            "messages.acceptEncryption#3dbc0415";
    }
}

