namespace org.telegram.api.page.block
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPageBlockAnchor : TLAbsPageBlock
    {
        public const int CLASS_ID = -837994576;
        private string name;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa2, 0x68 })]
        public TLPageBlockAnchor()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPageBlockAnchor(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb5, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.name = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            -837994576;

        public virtual string getName() => 
            this.name;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb0, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.name, stream);
        }

        public override string toString() => 
            "pageBlockAnchor#ce0d37b0";
    }
}

