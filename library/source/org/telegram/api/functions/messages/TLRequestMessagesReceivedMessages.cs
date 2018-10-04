namespace org.telegram.api.functions.messages
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/tl/TLVector<Lorg/telegram/api/TLReceivedNotifyMessage;>;>;")]
    public class TLRequestMessagesReceivedMessages : TLMethod
    {
        public const int CLASS_ID = 0x5a954c0;
        private int maxId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLRequestMessagesReceivedMessages()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesReceivedMessages(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x10)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 15, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.maxId = StreamingUtils.readInt(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Signature("(Ljava/io/InputStream;Lorg/telegram/tl/TLContext;)Lorg/telegram/tl/TLVector<Lorg/telegram/api/TLReceivedNotifyMessage;>;"), LineNumberTable(0x25)]
        public virtual TLVector deserializeResponse(InputStream stream, TLContext context) => 
            StreamingUtils.readTLVector(stream, context);

        public override int getClassId() => 
            0x5a954c0;

        public virtual int getMaxId() => 
            this.maxId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 10, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.maxId, stream);
        }

        public virtual void setMaxId(int value)
        {
            this.maxId = value;
        }

        public override string toString() => 
            "messages.receivedMessages#5a954c0";
    }
}

