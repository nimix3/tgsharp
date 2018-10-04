namespace org.telegram.api.update
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.peer;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdateDialogPinned : TLAbsUpdate
    {
        public const int CLASS_ID = -686710068;
        private const int FLAG_PINNED = 1;
        private int flags;
        private TLAbsPeer peer;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xab, 0x68 })]
        public TLUpdateDialogPinned()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateDialogPinned(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 3, 0x6c, 0x77 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.peer = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsPeer>.Value);
        }

        public override int getClassId() => 
            -686710068;

        public virtual TLAbsPeer getPeer() => 
            this.peer;

        public virtual bool isPinned() => 
            ((this.flags & 1) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbd, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLObject(this.peer, stream);
        }

        public override string toString() => 
            "updateDialogPinned#d711a2cc";
    }
}

