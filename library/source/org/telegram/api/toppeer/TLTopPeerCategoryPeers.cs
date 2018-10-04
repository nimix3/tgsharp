namespace org.telegram.api.toppeer
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.toppeer.category;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLTopPeerCategoryPeers : TLObject
    {
        private TLAbsTopPeerCategory category;
        public const int CLASS_ID = -75283823;
        private int count;
        [Signature("Lorg/telegram/tl/TLVector<Lorg/telegram/api/toppeer/TLTopPeer;>;")]
        private TLVector peers;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x13)]
        public TLTopPeerCategoryPeers()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLTopPeerCategoryPeers(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 2, 0x77, 0x6c, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.category = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsTopPeerCategory>.Value);
            this.count = StreamingUtils.readInt(stream);
            this.peers = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLTopPeer>.Value);
        }

        public virtual TLAbsTopPeerCategory getCategory() => 
            this.category;

        public override int getClassId() => 
            -75283823;

        public virtual int getCount() => 
            this.count;

        [Signature("()Lorg/telegram/tl/TLVector<Lorg/telegram/api/toppeer/TLTopPeer;>;")]
        public virtual TLVector getPeers() => 
            this.peers;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbb, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.category, stream);
            StreamingUtils.writeInt(this.count, stream);
            StreamingUtils.writeTLVector(this.peers, stream);
        }

        public override string toString() => 
            "topPeerCategoryPeers#fb834291";
    }
}

