namespace org.telegram.api.help
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLAppUpdate : TLAbsAppUpdate
    {
        public const int CLASS_ID = -1987579119;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa5, 0x68 })]
        public TLAppUpdate()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAppUpdate(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb6, 0x6c, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.id = StreamingUtils.readInt(stream);
            base.critical = StreamingUtils.readTLBool(stream);
            base.url = StreamingUtils.readTLString(stream);
            base.text = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            -1987579119;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xae, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(base.id, stream);
            StreamingUtils.writeTLBool(base.critical, stream);
            StreamingUtils.writeTLString(base.url, stream);
            StreamingUtils.writeTLString(base.text, stream);
        }

        public override string toString() => 
            "help.appUpdate#8987f311";
    }
}

