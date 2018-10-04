namespace org.telegram.api.input.filelocation
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.file.location;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputFileLocation : TLAbsInputFileLocation
    {
        public const int CLASS_ID = 0x14637196;
        private int localId;
        private long secret;
        private long volumeId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLInputFileLocation()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb3, 0x68, 0x6c, 0x6c, 0x6c })]
        public TLInputFileLocation(TLFileLocation fileLocation)
        {
            this.volumeId = fileLocation.getVolumeId();
            this.localId = fileLocation.getLocalId();
            this.secret = fileLocation.getSecret();
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputFileLocation(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 60, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.volumeId = StreamingUtils.readLong(stream);
            this.localId = StreamingUtils.readInt(stream);
            this.secret = StreamingUtils.readLong(stream);
        }

        public override int getClassId() => 
            0x14637196;

        public virtual int getLocalId() => 
            this.localId;

        public virtual long getSecret() => 
            this.secret;

        public virtual long getVolumeId() => 
            this.volumeId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x35, 0x6c, 0x6c, 110 })]
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
            "inputFileLocation#14637196";
    }
}

