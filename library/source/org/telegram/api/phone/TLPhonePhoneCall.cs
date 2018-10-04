namespace org.telegram.api.phone
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.phone.call;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPhonePhoneCall : TLObject
    {
        public const int CLASS_ID = -326966976;
        private TLAbsPhoneCall phoneCall;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        private TLVector users;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa7, 0x68 })]
        public TLPhonePhoneCall()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPhonePhoneCall(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbf, 0x77, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.phoneCall = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsPhoneCall>.Value);
            this.users = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsUser>.Value);
        }

        public override int getClassId() => 
            -326966976;

        public virtual TLAbsPhoneCall getPhoneCall() => 
            this.phoneCall;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        public virtual TLVector getUsers() => 
            this.users;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb9, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.phoneCall, stream);
            StreamingUtils.writeTLVector(this.users, stream);
        }

        public override string toString() => 
            "phone.phoneCall#ec82e140";
    }
}

