namespace org.telegram.api.page.block
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLPageBlockCover : TLAbsPageBlock
    {
        public const int CLASS_ID = 0x39f23300;
        private TLAbsPageBlock cover;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa2, 0x68 })]
        public TLPageBlockCover()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLPageBlockCover(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb5, 0x77 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.cover = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsPageBlock>.Value);
        }

        public override int getClassId() => 
            0x39f23300;

        public virtual TLAbsPageBlock getCover() => 
            this.cover;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb0, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.cover, stream);
        }

        public override string toString() => 
            "pageBlockCover#39f23300";
    }
}

