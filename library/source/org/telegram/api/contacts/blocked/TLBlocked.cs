namespace org.telegram.api.contacts.blocked
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLBlocked : TLAbsBlocked
    {
        public const int CLASS_ID = 0x1c138d15;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb2, 0x68 })]
        public TLBlocked()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLBlocked(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 1, 0x6d, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.blocked = StreamingUtils.readTLVector(stream, context);
            base.users = StreamingUtils.readTLVector(stream, context);
        }

        public override int getClassId() => 
            0x1c138d15;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbb, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(base.blocked, stream);
            StreamingUtils.writeTLVector(base.users, stream);
        }

        public override string toString() => 
            "contacts.blocked#1c138d15";
    }
}

