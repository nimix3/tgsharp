namespace org.telegram.api.update
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
    public class TLUpdatePinnedDialogs : TLAbsUpdate
    {
        public const int CLASS_ID = -657787251;
        private const int FLAG_ORDER = 1;
        private int flags;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/peer/TLAbsPeer;>;")]
        private TLVector order;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa3, 0x68 })]
        public TLUpdatePinnedDialogs()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdatePinnedDialogs(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbd, 0x6c, 0x6a, 0x92 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            if ((this.flags & 1) != 0)
            {
                this.order = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsPeer>.Value);
            }
        }

        public override int getClassId() => 
            -657787251;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/peer/TLAbsPeer;>;")]
        public virtual TLVector getOrder() => 
            this.order;

        public virtual bool hasOrder() => 
            ((this.flags & 1) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb5, 0x6c, 0x6a, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            if ((this.flags & 1) != 0)
            {
                StreamingUtils.writeTLVector(this.order, stream);
            }
        }

        public override string toString() => 
            "updatePinnedDialogs#d8caf68d";
    }
}

