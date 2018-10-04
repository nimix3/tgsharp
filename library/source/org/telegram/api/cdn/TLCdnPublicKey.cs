namespace org.telegram.api.cdn
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLCdnPublicKey : TLObject
    {
        public const int CLASS_ID = -914167110;
        private int dcId;
        private string publicKey;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(15)]
        public TLCdnPublicKey()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLCdnPublicKey(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.dcId = StreamingUtils.readInt(stream);
            this.publicKey = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            -914167110;

        public virtual int getDcId() => 
            this.dcId;

        public virtual string getPublicKey() => 
            this.publicKey;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xba, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.dcId, stream);
            StreamingUtils.writeTLString(this.publicKey, stream);
        }

        public virtual void setDcId(int dcId)
        {
            this.dcId = dcId;
        }

        public virtual void setPublicKey(string publicKey)
        {
            this.publicKey = publicKey;
        }

        public override string toString() => 
            "cdnPublicKey#c982eaba";
    }
}

