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
    public class TLDhConfigNotModified : TLAbsDhConfig
    {
        public const int CLASS_ID = -1058912715;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa5, 0x68 })]
        public TLDhConfigNotModified()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDhConfigNotModified(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb3, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.random = StreamingUtils.readTLBytes(stream, context);
        }

        public override int getClassId() => 
            -1058912715;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xae, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLBytes(base.random, stream);
        }

        public override string toString() => 
            "messages.dhConfigNotModified#c0e24635";
    }
}

