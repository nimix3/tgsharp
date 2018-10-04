namespace org.telegram.api.functions.channels
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.input.chat;
    using org.telegram.api.input.user;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/tl/TLBool;>;")]
    public class TLRequestChannelsReportSpam : TLMethod
    {
        private TLAbsInputChannel channel;
        public const int CLASS_ID = -32999408;
        private TLIntVector id;
        private TLAbsInputUser userId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xaf, 0x68 })]
        public TLRequestChannelsReportSpam()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestChannelsReportSpam(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x13)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x23, 0x72, 0x72, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.channel = StreamingUtils.readTLObject(stream, context);
            this.userId = StreamingUtils.readTLObject(stream, context);
            this.id = StreamingUtils.readTLIntVector(stream, context);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb8, 0x68, 0x63, 0x90, 0x68, 0x87 })]
        public virtual TLBool deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLBool)
            {
                return (TLBool) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLBool>.Value.getName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getName()).toString());
        }

        public virtual TLAbsInputChannel getChannel() => 
            this.channel;

        public override int getClassId() => 
            -32999408;

        public virtual TLIntVector getId() => 
            this.id;

        public virtual TLAbsInputUser getUserId() => 
            this.userId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.channel, stream);
            StreamingUtils.writeTLObject(this.userId, stream);
            StreamingUtils.writeTLVector(this.id, stream);
        }

        public virtual void setChannel(TLAbsInputChannel channel)
        {
            this.channel = channel;
        }

        public virtual void setId(TLIntVector id)
        {
            this.id = id;
        }

        public virtual void setUserId(TLAbsInputUser userId)
        {
            this.userId = userId;
        }

        public override string toString() => 
            "functions.channels.TLRequestChannelsReportSpam#fe087810";
    }
}

