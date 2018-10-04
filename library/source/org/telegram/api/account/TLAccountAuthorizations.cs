namespace org.telegram.api.account
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLAccountAuthorizations : TLObject
    {
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/auth/TLAuthorization;>;")]
        private TLVector authorizations;
        public const int CLASS_ID = 0x1250abde;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 180, 0x68 })]
        public TLAccountAuthorizations()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAccountAuthorizations(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x15, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.authorizations = StreamingUtils.readTLObject(stream, context);
        }

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/auth/TLAuthorization;>;")]
        public virtual TLVector getAuthorizations() => 
            this.authorizations;

        public override int getClassId() => 
            0x1250abde;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x10, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.authorizations, stream);
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/auth/TLAuthorization;>;)V")]
        public virtual void setAuthorizations(TLVector authorizations)
        {
            this.authorizations = authorizations;
        }

        public override string toString() => 
            "account.authorizations#1250abde";
    }
}

