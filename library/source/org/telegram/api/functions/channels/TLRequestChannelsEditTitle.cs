namespace org.telegram.api.functions.channels
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.input.chat;
    using org.telegram.api.updates;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/updates/TLAbsUpdates;>;")]
    public class TLRequestChannelsEditTitle : TLMethod
    {
        private TLAbsInputChannel channel;
        public const int CLASS_ID = 0x566decd0;
        private string title;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xac, 0x68 })]
        public TLRequestChannelsEditTitle()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestChannelsEditTitle(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x11)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x17, 0x72, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.channel = StreamingUtils.readTLObject(stream, context);
            this.title = StreamingUtils.readTLString(stream);
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
            0x566decd0;

        public virtual string getTitle() => 
            this.title;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x11, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.channel, stream);
            StreamingUtils.writeTLString(this.title, stream);
        }

        public virtual void setChannel(TLAbsInputChannel channel)
        {
            this.channel = channel;
        }

        public virtual void setTitle(string title)
        {
            this.title = title;
        }

        public override string toString() => 
            "functions.channels.TLRequestChannelsEditTitle#566decd0";
    }
}

