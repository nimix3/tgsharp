namespace org.telegram.api.contact
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLContactBlocked : TLObject
    {
        public const int CLASS_ID = 0x561bc879;
        private int date;
        private int userId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb2, 0x68 })]
        public TLContactBlocked()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLContactBlocked(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x25, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.userId = StreamingUtils.readInt(stream);
            this.date = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            0x561bc879;

        public virtual int getDate() => 
            this.date;

        public virtual int getUserId() => 
            this.userId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1f, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.userId, stream);
            StreamingUtils.writeInt(this.date, stream);
        }

        public virtual void setDate(int value)
        {
            this.date = value;
        }

        public virtual void setUserId(int value)
        {
            this.userId = value;
        }

        public override string toString() => 
            "contactBlocked#561bc879";
    }
}

