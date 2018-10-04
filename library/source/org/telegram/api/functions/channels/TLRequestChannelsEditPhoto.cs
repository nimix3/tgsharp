namespace org.telegram.api.functions.channels
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.input.chat;
    using org.telegram.api.input.chat.photo;
    using org.telegram.api.updates;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/updates/TLAbsUpdates;>;")]
    public class TLRequestChannelsEditPhoto : TLMethod
    {
        private TLAbsInputChannel channel;
        public const int CLASS_ID = -248621111;
        private TLAbsInputChatPhoto photo;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xac, 0x68 })]
        public TLRequestChannelsEditPhoto()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestChannelsEditPhoto(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x12)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x17, 0x72, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.channel = StreamingUtils.readTLObject(stream, context);
            this.photo = StreamingUtils.readTLObject(stream, context);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb5, 0x68, 0x63, 0x90, 0x68, 0x87 })]
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
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLAbsUpdates>.Value.getName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getName()).toString());
        }

        public virtual TLAbsInputChannel getChannel() => 
            this.channel;

        public override int getClassId() => 
            -248621111;

        public virtual TLAbsInputChatPhoto getPhoto() => 
            this.photo;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x11, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.channel, stream);
            StreamingUtils.writeTLObject(this.photo, stream);
        }

        public virtual void setChannel(TLAbsInputChannel channel)
        {
            this.channel = channel;
        }

        public virtual void setPhoto(TLAbsInputChatPhoto photo)
        {
            this.photo = photo;
        }

        public override string toString() => 
            "functions.channels.TLRequestChannelsEditPhoto#f12e57c9";
    }
}

