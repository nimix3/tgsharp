namespace org.telegram.api.messages
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessagesEditData : TLObject
    {
        public const int CLASS_ID = 0x26b5dde6;
        private const int FLAG_CAPTION = 1;
        private int flags;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa4, 0x68 })]
        public TLMessagesEditData()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessagesEditData(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb7, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            0x26b5dde6;

        public virtual bool isCaptionEdited() => 
            ((this.flags & 1) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb2, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
        }

        public override string toString() => 
            "messages.messageEditData#26b5dde6";
    }
}

