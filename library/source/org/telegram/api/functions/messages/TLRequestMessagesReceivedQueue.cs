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

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/tl/TLLongVector;>;")]
    public class TLRequestMessagesReceivedQueue : TLMethod
    {
        public const int CLASS_ID = 0x55a5bb66;
        private int maxQts;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68 })]
        public TLRequestMessagesReceivedQueue()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestMessagesReceivedQueue(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(15)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 14, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.maxQts = StreamingUtils.readInt(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(0x24)]
        public virtual TLLongVector deserializeResponse(InputStream stream, TLContext context) => 
            StreamingUtils.readTLLongVector(stream, context);

        public override int getClassId() => 
            0x55a5bb66;

        public virtual int getMaxQts() => 
            this.maxQts;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 9, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.maxQts, stream);
        }

        public virtual void setMaxQts(int value)
        {
            this.maxQts = value;
        }

        public override string toString() => 
            "messages.receivedQueue#55a5bb66";
    }
}

