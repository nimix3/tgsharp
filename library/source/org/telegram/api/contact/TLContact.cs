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
    public class TLContact : TLObject
    {
        public const int CLASS_ID = -116274796;
        private bool mutual;
        private int userId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb3, 0x68 })]
        public TLContact()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLContact(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x26, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.userId = StreamingUtils.readInt(stream);
            this.mutual = StreamingUtils.readTLBool(stream);
        }

        public override int getClassId() => 
            -116274796;

        public virtual bool getMutual() => 
            this.mutual;

        public virtual int getUserId() => 
            this.userId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x20, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.userId, stream);
            StreamingUtils.writeTLBool(this.mutual, stream);
        }

        public virtual void setMutual(bool value)
        {
            int num = (int) value;
            this.mutual = (bool) num;
        }

        public virtual void setUserId(int value)
        {
            this.userId = value;
        }

        public override string toString() => 
            "contact#f911c994";
    }
}

