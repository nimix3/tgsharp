namespace org.telegram.api.toppeer
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
    public class TLTopPeer : TLObject
    {
        public const int CLASS_ID = -305282981;
        private TLAbsPeer peer;
        private double rating;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x12)]
        public TLTopPeer()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLTopPeer(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xbb, 0x77, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.peer = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsPeer>.Value);
            this.rating = StreamingUtils.readDouble(stream);
        }

        public override int getClassId() => 
            -305282981;

        public virtual TLAbsPeer getPeer() => 
            this.peer;

        public virtual double getRating() => 
            this.rating;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb5, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.peer, stream);
            StreamingUtils.writeDouble(this.rating, stream);
        }

        public override string toString() => 
            "topPeer#edcdc05b";
    }
}

