namespace org.telegram.api.functions.phone
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using java.lang;
    using org.telegram.api.input.user;
    using org.telegram.api.phone;
    using org.telegram.tl;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable, Signature("Lorg/telegram/tl/TLMethod<Lorg/telegram/api/phone/TLPhonePhoneCall;>;")]
    public class TLRequestPhoneRequestCall : TLMethod
    {
        public const int CLASS_ID = 0x5b95b3d4;
        private TLBytes gAHash;
        private TLPhoneCallProtocol protocol;
        private int randomId;
        private TLAbsInputUser userId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa7, 0x68 })]
        public TLRequestPhoneRequestCall()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLRequestPhoneRequestCall(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), Modifiers(0x1041), EditorBrowsable(EditorBrowsableState.Never), LineNumberTable(0x10)]
        public virtual TLObject <bridge>deserializeResponse(InputStream @is, TLContext tlc) => 
            this.deserializeResponse(@is, tlc);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x26, 0x77, 0x6c, 0x6d, 0x77 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.userId = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsInputUser>.Value);
            this.randomId = StreamingUtils.readInt(stream);
            this.gAHash = StreamingUtils.readTLBytes(stream, context);
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
            0x5b95b3d4;

        public virtual TLBytes getgAHash() => 
            this.gAHash;

        public virtual TLPhoneCallProtocol getProtocol() => 
            this.protocol;

        public virtual int getRandomId() => 
            this.randomId;

        public virtual TLAbsInputUser getUserId() => 
            this.userId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 30, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.userId, stream);
            StreamingUtils.writeInt(this.randomId, stream);
            StreamingUtils.writeTLBytes(this.gAHash, stream);
            StreamingUtils.writeTLObject(this.protocol, stream);
        }

        public virtual void setgAHash(TLBytes gAHash)
        {
            this.gAHash = gAHash;
        }

        public virtual void setProtocol(TLPhoneCallProtocol protocol)
        {
            this.protocol = protocol;
        }

        public virtual void setRandomId(int randomId)
        {
            this.randomId = randomId;
        }

        public virtual void setUserId(TLAbsInputUser userId)
        {
            this.userId = userId;
        }

        public override string toString() => 
            "phone.requestCall#5b95b3d4";
    }
}

