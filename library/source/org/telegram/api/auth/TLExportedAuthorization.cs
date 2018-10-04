namespace org.telegram.api.auth
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLExportedAuthorization : TLObject
    {
        private TLBytes bytes;
        public const int CLASS_ID = -543777747;
        private int id;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 180, 0x68 })]
        public TLExportedAuthorization()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLExportedAuthorization(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x27, 0x6c, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.id = StreamingUtils.readInt(stream);
            this.bytes = StreamingUtils.readTLBytes(stream, context);
        }

        public virtual TLBytes getBytes() => 
            this.bytes;

        public override int getClassId() => 
            -543777747;

        public virtual int getId() => 
            this.id;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x21, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.id, stream);
            StreamingUtils.writeTLBytes(this.bytes, stream);
        }

        public virtual void setBytes(TLBytes value)
        {
            this.bytes = value;
        }

        public virtual void setId(int value)
        {
            this.id = value;
        }

        public override string toString() => 
            "auth.exportedAuthorization#df969c2d";
    }
}

