namespace org.telegram.api.file.location
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLFileLocationUnavailable : TLAbsFileLocation
    {
        public const int CLASS_ID = 0x7c596b46;
        private int localId;
        private long secret;
        private long volumeId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68 })]
        public TLFileLocationUnavailable()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLFileLocationUnavailable(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x2f, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.volumeId = StreamingUtils.readLong(stream);
            this.localId = StreamingUtils.readInt(stream);
            this.secret = StreamingUtils.readLong(stream);
        }

        public override int getClassId() => 
            0x7c596b46;

        public virtual int getLocalId() => 
            this.localId;

        public virtual long getSecret() => 
            this.secret;

        public virtual long getVolumeId() => 
            this.volumeId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 40, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.volumeId, stream);
            StreamingUtils.writeInt(this.localId, stream);
            StreamingUtils.writeLong(this.secret, stream);
        }

        public virtual void setLocalId(int localId)
        {
            this.localId = localId;
        }

        public virtual void setSecret(long secret)
        {
            this.secret = secret;
        }

        public virtual void setVolumeId(long volumeId)
        {
            this.volumeId = volumeId;
        }

        public override string toString() => 
            "fileLocationUnavailable#7c596b46";
    }
}

