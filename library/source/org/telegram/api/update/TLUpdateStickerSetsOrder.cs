namespace org.telegram.api.update
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdateStickerSetsOrder : TLAbsUpdate
    {
        public const int CLASS_ID = 0xbb2d201;
        private const int FLAG_MASKS = 1;
        private int flags;
        private TLLongVector order;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xbc, 0x68 })]
        public TLUpdateStickerSetsOrder()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateStickerSetsOrder(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x17, 0x6c, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.order = StreamingUtils.readTLLongVector(stream, context);
        }

        public override int getClassId() => 
            0xbb2d201;

        public virtual TLLongVector getOrder() => 
            this.order;

        public virtual bool isMask() => 
            ((this.flags & 1) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x11, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLVector(this.order, stream);
        }

        public virtual void setOrder(TLLongVector order)
        {
            this.order = order;
        }

        public override string toString() => 
            "updateStickerSetsOrder#bb2d201";
    }
}

