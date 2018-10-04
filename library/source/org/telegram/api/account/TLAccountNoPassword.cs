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
    public class TLAccountNoPassword : TLAbsAccountPassword
    {
        public const int CLASS_ID = -1764049896;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xaf, 0x68 })]
        public TLAccountNoPassword()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAccountNoPassword(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 1, 0x6d, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.newSalt = StreamingUtils.readTLBytes(stream, context);
            base.emailUnconfirmedPattern = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            -1764049896;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xba, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLBytes(base.newSalt, stream);
            StreamingUtils.writeTLString(base.emailUnconfirmedPattern, stream);
        }

        public override string toString() => 
            "accountNoPassword#96dabc18";
    }
}

