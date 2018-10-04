namespace org.telegram.api.functions.phone
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.input.phonecall;
    using org.telegram.api.phone;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/phone/TLPhonePhoneCall;>;")]
    public class TLRequestPhoneConfirmCall : TLMethod
    {
        public const int CLASS_ID = 0x2efe1722;
        private TLBytes gA;
        private long keyFingerprint;
        private TLInputPhoneCall peer;
        private TLPhoneCallProtocol protocol;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa7, 0x68 })]
        public TLRequestPhoneConfirmCall()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestPhoneConfirmCall(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x10)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x26, 0x77, 0x6d, 0x6c, 0x77 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.peer = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLInputPhoneCall>.Value);
            this.gA = StreamingUtils.readTLBytes(stream, context);
            this.keyFingerprint = StreamingUtils.readLong(stream);
            this.protocol = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLPhoneCallProtocol>.Value);
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 12, 0x68, 0x63, 0x90, 0x68, 0x87, 0x7f, 10 })]
        public virtual TLPhonePhoneCall deserializeResponse(InputStream stream, TLContext context)
        {
            TLObject obj2 = StreamingUtils.readTLObject(stream, context);
            if (obj2 == null)
            {
                Throwable.__<suppressFillInStackTrace>();
                throw new IOException("Unable to parse response");
            }
            if (obj2 is TLPhonePhoneCall)
            {
                return (TLPhonePhoneCall) obj2;
            }
            Throwable.__<suppressFillInStackTrace>();
            throw new IOException(new StringBuilder().append("Incorrect response type. Expected ").append(ClassLiteral<TLPhonePhoneCall>.Value.getCanonicalName()).append(", got: ").append(Object.instancehelper_getClass(obj2).getCanonicalName()).toString());
        }

        public override int getClassId() => 
            0x2efe1722;

        public virtual TLBytes getgA() => 
            this.gA;

        public virtual long getKeyFingerprint() => 
            this.keyFingerprint;

        public virtual TLInputPhoneCall getPeer() => 
            this.peer;

        public virtual TLPhoneCallProtocol getProtocol() => 
            this.protocol;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 30, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.peer, stream);
            StreamingUtils.writeTLBytes(this.gA, stream);
            StreamingUtils.writeLong(this.keyFingerprint, stream);
            StreamingUtils.writeTLObject(this.protocol, stream);
        }

        public virtual void setgA(TLBytes gA)
        {
            this.gA = gA;
        }

        public virtual void setKeyFingerprint(long keyFingerprint)
        {
            this.keyFingerprint = keyFingerprint;
        }

        public virtual void setPeer(TLInputPhoneCall peer)
        {
            this.peer = peer;
        }

        public virtual void setProtocol(TLPhoneCallProtocol protocol)
        {
            this.protocol = protocol;
        }

        public override string toString() => 
            "phone.confirmCall#2efe1722";
    }
}

