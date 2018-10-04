namespace org.telegram.api.input.messages.entity
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.api.input.user;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputMessageEntityMentionName : TLAbsInputMessageEntity
    {
        public const int CLASS_ID = 0x208e68c9;
        private int length;
        private int offset;
        private TLAbsInputUser userId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa7, 0x68 })]
        public TLInputMessageEntityMentionName()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputMessageEntityMentionName(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x13, 0x6c, 0x6c, 0x77 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.offset = StreamingUtils.readInt(stream);
            this.length = StreamingUtils.readInt(stream);
            this.userId = StreamingUtils.readTLObject(stream, context, ClassLiteral<TLAbsInputUser>.Value);
        }

        public override int getClassId() => 
            0x208e68c9;

        public virtual int getLength() => 
            this.length;

        public virtual int getOffset() => 
            this.offset;

        public virtual TLAbsInputUser getUserId() => 
            this.userId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 9, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.offset, stream);
            StreamingUtils.writeInt(this.length, stream);
            StreamingUtils.writeTLObject(this.userId, stream);
        }

        public virtual void setLength(int length)
        {
            this.length = length;
        }

        public virtual void setOffset(int offset)
        {
            this.offset = offset;
        }

        public virtual void setUserId(TLAbsInputUser userId)
        {
            this.userId = userId;
        }

        public override string toString() => 
            "inputMessageEntityMentionName#208e68c9";
    }
}

