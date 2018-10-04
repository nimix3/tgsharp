namespace org.telegram.api
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLReceivedNotifyMessage : TLObject
    {
        public const int CLASS_ID = -1551583367;
        private int flags;
        private int id;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xad, 0x68 })]
        public TLReceivedNotifyMessage()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLReceivedNotifyMessage(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x22, 0x68, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.deserializeBody(stream, context);
            this.id = StreamingUtils.readInt(stream);
            this.flags = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            -1551583367;

        public virtual int getFlags() => 
            this.flags;

        public virtual int getId() => 
            this.id;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1b, 0x67, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            base.serializeBody(stream);
            StreamingUtils.writeInt(this.id, stream);
            StreamingUtils.writeInt(this.flags, stream);
        }

        public virtual void setFlags(int flags)
        {
            this.flags = flags;
        }

        public virtual void setId(int id)
        {
            this.id = id;
        }

        public override string toString() => 
            "messages.receivedNotifyMessage#a384b779";
    }
}

