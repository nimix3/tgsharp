namespace org.telegram.api.functions.phone
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.input.phonecall;
    using org.telegram.api.phone.call.discardreason;
    using org.telegram.api.updates;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/updates/TLAbsUpdates;>;")]
    public class TLRequestPhoneDiscardCall : TLMethod
    {
        public const int CLASS_ID = 0x78d413a6;
        private long connectionId;
        private int duration;
        private TLInputPhoneCall peer;
        private TLAbsPhoneCallDiscardReason reason;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa7, 0x68 })]
        public TLRequestPhoneDiscardCall()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestPhoneDiscardCall(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x10)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x27, 0x77, 0x6c, 0x77, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.peer = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLInputPhoneCall>.Value);
            this.duration = StreamingUtils.readInt(stream);
            this.reason = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsPhoneCallDiscardReason>.Value);
            this.connectionId = StreamingUtils.readLong(stream);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xac, 0x68, 0x63, 0x90, 0x68, 0x87, 0x7f, 10 })]
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
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLAbsUpdates>.Value.getCanonicalName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            0x78d413a6;

        public virtual long getConnectionId() => 
            this.connectionId;

        public virtual int getDuration() => 
            this.duration;

        public virtual TLInputPhoneCall getPeer() => 
            this.peer;

        public virtual TLAbsPhoneCallDiscardReason getReason() => 
            this.reason;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1f, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.peer, stream);
            StreamingUtils.writeInt(this.duration, stream);
            StreamingUtils.writeTLObject(this.reason, stream);
            StreamingUtils.writeLong(this.connectionId, stream);
        }

        public virtual void setConnectionId(long connectionId)
        {
            this.connectionId = connectionId;
        }

        public virtual void setDuration(int duration)
        {
            this.duration = duration;
        }

        public virtual void setPeer(TLInputPhoneCall peer)
        {
            this.peer = peer;
        }

        public virtual void setReason(TLAbsPhoneCallDiscardReason reason)
        {
            this.reason = reason;
        }

        public override string toString() => 
            "phone.discardCall#78d413a6";
    }
}

