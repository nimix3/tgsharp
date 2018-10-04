namespace org.telegram.api.messages.dhconfig
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLDhConfig : TLAbsDhConfig
    {
        public const int CLASS_ID = 0x2c221edd;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa5, 0x68 })]
        public TLDhConfig()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDhConfig(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb9, 0x6c, 0x6d, 0x6c, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.g = StreamingUtils.readInt(stream);
            base.p = StreamingUtils.readTLBytes(stream, context);
            base.version = StreamingUtils.readInt(stream);
            base.random = StreamingUtils.readTLBytes(stream, context);
        }

        public override int getClassId() => 
            0x2c221edd;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb0, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(base.g, stream);
            StreamingUtils.writeTLBytes(base.p, stream);
            StreamingUtils.writeInt(base.version, stream);
            StreamingUtils.writeTLBytes(base.random, stream);
        }

        public override string toString() => 
            "messages.dhConfig#2c221edd";
    }
}

