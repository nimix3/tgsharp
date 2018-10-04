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
    public class TLFileLocation : TLAbsFileLocation
    {
        public const int CLASS_ID = 0x53d69076;
        private int dcId;
        private int localId;
        private long secret;
        private long volumeId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLFileLocation()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLFileLocation(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x43, 0x6c, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.dcId = StreamingUtils.readInt(stream);
            this.volumeId = StreamingUtils.readLong(stream);
            this.localId = StreamingUtils.readInt(stream);
            this.secret = StreamingUtils.readLong(stream);
        }

        public override int getClassId() => 
            0x53d69076;

        public virtual int getDcId() => 
            this.dcId;

        public virtual int getLocalId() => 
            this.localId;

        public virtual long getSecret() => 
            this.secret;

        public virtual long getVolumeId() => 
            this.volumeId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x3b, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.dcId, stream);
            StreamingUtils.writeLong(this.volumeId, stream);
            StreamingUtils.writeInt(this.localId, stream);
            StreamingUtils.writeLong(this.secret, stream);
        }

        public virtual void setDcId(int dcId)
        {
            this.dcId = dcId;
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
            "fileLocation#53d69076";
    }
}

