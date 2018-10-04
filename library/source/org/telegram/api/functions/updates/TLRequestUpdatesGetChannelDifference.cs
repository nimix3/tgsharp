namespace org.telegram.api.functions.updates
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.channel.filters;
    using org.telegram.api.input.chat;
    using org.telegram.api.updates.channel.differences;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/updates/channel/differences/TLAbsUpdatesChannelDifferences;>;")]
    public class TLRequestUpdatesGetChannelDifference : TLMethod
    {
        private TLAbsInputChannel channel;
        public const int CLASS_ID = 0x3173d78;
        private TLAbsChannelMessagesFilter filter;
        private const int FLAG_FORCE = 1;
        private int flags;
        private int limit;
        private int pts;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68 })]
        public TLRequestUpdatesGetChannelDifference()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestUpdatesGetChannelDifference(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(15)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x34, 0x6c, 0x77, 0x77, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.channel = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsInputChannel>.Value);
            this.filter = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsChannelMessagesFilter>.Value);
            this.pts = StreamingUtils.readInt(stream);
            this.limit = StreamingUtils.readInt(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb2, 0x68, 0x63, 0x90, 0x68, 0x87 })]
        public virtual TLAbsUpdatesChannelDifferences deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLAbsUpdatesChannelDifferences)
            {
                return (TLAbsUpdatesChannelDifferences) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLAbsUpdatesChannelDifferences>.Value.getName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public virtual TLAbsInputChannel getChannel() => 
            this.channel;

        public override int getClassId() => 
            0x3173d78;

        public virtual TLAbsChannelMessagesFilter getFilter() => 
            this.filter;

        public virtual int getFlags() => 
            this.flags;

        public virtual int getLimit() => 
            this.limit;

        public virtual int getPts() => 
            this.pts;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x2b, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLObject(this.channel, stream);
            StreamingUtils.writeTLObject(this.filter, stream);
            StreamingUtils.writeInt(this.pts, stream);
            StreamingUtils.writeInt(this.limit, stream);
        }

        public virtual void setChannel(TLAbsInputChannel channel)
        {
            this.channel = channel;
        }

        public virtual void setFilter(TLAbsChannelMessagesFilter filter)
        {
            this.filter = filter;
        }

        [LineNumberTable(new byte[] { 0x9f, 0x7a, 0xa2, 0x63, 0x90, 0x8f })]
        public virtual void setForce(bool enabled)
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

        public virtual void setLimit(int limit)
        {
            this.limit = limit;
        }

        public virtual void setPts(int pts)
        {
            this.pts = pts;
        }

        public override string toString() => 
            "updates.getChannelDifference#3173d78";
    }
}

