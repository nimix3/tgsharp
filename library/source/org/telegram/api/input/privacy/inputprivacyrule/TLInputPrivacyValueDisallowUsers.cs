namespace org.telegram.api.input.privacy.inputprivacyrule
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputPrivacyValueDisallowUsers : TLAbsInputPrivacyRule
    {
        public const int CLASS_ID = -1877932953;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        protected internal TLVector users;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xbd, 0xe8, 0x3a, 0xeb, 0x47 })]
        public TLInputPrivacyValueDisallowUsers()
        {
            this.users = new TLVector();
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputPrivacyValueDisallowUsers(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1d, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.users = StreamingUtils.readTLVector(stream, context);
        }

        public override int getClassId() => 
            -1877932953;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;")]
        public virtual TLVector getUsers() => 
            this.users;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x18, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(this.users, stream);
        }

        [Signature("(Lorg/telegram/tl/TLVector<Lorg/telegram/api/user/TLAbsUser;>;)V")]
        public virtual void setUsers(TLVector users)
        {
            this.users = users;
        }

        public override string toString() => 
            "inputPrivacyValueDisallowUsers#90110467";
    }
}

