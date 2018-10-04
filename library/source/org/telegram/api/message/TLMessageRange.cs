namespace org.telegram.api.message
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessageRange : TLObject
    {
        public const int CLASS_ID = 0xae30253;
        private int maxId;
        private int minId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68 })]
        public TLMessageRange()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessageRange(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 11, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.minId = StreamingUtils.readInt(stream);
            this.maxId = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            0xae30253;

        public virtual int getMaxId() => 
            this.maxId;

        public virtual int getMinId() => 
            this.minId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 3, 0x6c, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.minId, stream);
            StreamingUtils.writeInt(this.maxId, stream);
        }

        public virtual void setMaxId(int maxId)
        {
            this.maxId = maxId;
        }

        public virtual void setMinId(int minId)
        {
            this.minId = minId;
        }

        public override string toString() => 
            "message.TLMessageRange#ae30253";
    }
}

