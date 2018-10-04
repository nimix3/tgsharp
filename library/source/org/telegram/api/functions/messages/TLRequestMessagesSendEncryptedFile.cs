namespace org.telegram.api.functions.messages
{
    using IKVM.Attributes;
    using java.io;
    using java.lang;
    using org.telegram.api.input.encrypted;
    using org.telegram.api.input.encrypted.file;
    using org.telegram.api.messages.sentencrypted;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/messages/sentencrypted/TLAbsSentEncryptedMessage;>;")]
    public class TLRequestMessagesSendEncryptedFile : TLMethod
    {
        public const int CLASS_ID = -1701831834;
        private TLBytes data;
        private TLAbsInputEncryptedFile file;
        private TLInputEncryptedChat peer;
        private long randomId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb0, 0x68 })]
        public TLRequestMessagesSendEncryptedFile()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesSendEncryptedFile(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x13)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x53, 0x72, 0x6c, 0x6d, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.peer = StreamingUtils.readTLObject(stream, context);
            this.randomId = StreamingUtils.readLong(stream);
            this.data = StreamingUtils.readTLBytes(stream, context);
            this.file = StreamingUtils.readTLObject(stream, context);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb9, 0x68, 0x63, 0x70, 0x68, 0x67 })]
        public virtual TLAbsSentEncryptedMessage deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLAbsSentEncryptedMessage)
            {
                return (TLAbsSentEncryptedMessage) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected org.telegram.api.messages.sentencrypted.TLAbsSentEncryptedMessage, got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            -1701831834;

        public virtual TLBytes getData() => 
            this.data;

        public virtual TLAbsInputEncryptedFile getFile() => 
            this.file;

        public virtual TLInputEncryptedChat getPeer() => 
            this.peer;

        public virtual long getRandomId() => 
            this.randomId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x4b, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.peer, stream);
            StreamingUtils.writeLong(this.randomId, stream);
            StreamingUtils.writeTLBytes(this.data, stream);
            StreamingUtils.writeTLObject(this.file, stream);
        }

        public virtual void setData(TLBytes value)
        {
            this.data = value;
        }

        public virtual void setFile(TLAbsInputEncryptedFile value)
        {
            this.file = value;
        }

        public virtual void setPeer(TLInputEncryptedChat value)
        {
            this.peer = value;
        }

        public virtual void setRandomId(long value)
        {
            this.randomId = value;
        }

        public override string toString() => 
            "messages.sendEncryptedFile#9a901b66";
    }
}

