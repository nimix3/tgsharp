namespace org.telegram.api.updates
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.update;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdateShort : TLAbsUpdates
    {
        public const int CLASS_ID = 0x78d4dec1;
        private int date;
        private TLAbsUpdate update;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68 })]
        public TLUpdateShort()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateShort(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1c, 0x72, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.update = StreamingUtils.readTLObject(stream, context);
            this.date = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            0x78d4dec1;

        public virtual int getDate() => 
            this.date;

        public virtual TLAbsUpdate getUpdate() => 
            this.update;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x16, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLObject(this.update, stream);
            StreamingUtils.writeInt(this.date, stream);
        }

        public virtual void setDate(int date)
        {
            this.date = date;
        }

        public virtual void setUpdate(TLAbsUpdate update)
        {
            this.update = update;
        }

        public override string toString() => 
            "updateShort#78d4dec1";
    }
}

