namespace org.telegram.api.update
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLUpdateMessageId : TLAbsUpdate
    {
        public const int CLASS_ID = 0x4e90bfd6;
        private int id;
        private long randomId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        public TLUpdateMessageId()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateMessageId(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1b, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.id = StreamingUtils.readInt(stream);
            this.randomId = StreamingUtils.readLong(stream);
        }

        public override int getClassId() => 
            0x4e90bfd6;

        public virtual int getId() => 
            this.id;

        public virtual long getRandomId() => 
            this.randomId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x15, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.id, stream);
            StreamingUtils.writeLong(this.randomId, stream);
        }

        public virtual void setId(int id)
        {
            this.id = id;
        }

        public virtual void setRandomId(long randomId)
        {
            this.randomId = randomId;
        }

        public override string toString() => 
            "updateMessageID#4e90bfd6";
    }
}

