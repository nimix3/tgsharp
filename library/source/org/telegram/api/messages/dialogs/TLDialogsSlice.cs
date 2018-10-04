namespace org.telegram.api.messages.dialogs
{
    using IKVM.Attributes;
    using ikvm.internal;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLDialogsSlice : TLAbsDialogs
    {
        public const int CLASS_ID = 0x71e094f3;
        private int count;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xab, 0x68 })]
        public TLDialogsSlice()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDialogsSlice(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 15, 0x6c, 0x72, 0x72, 0x72, 0x72 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.count = StreamingUtils.readInt(stream);
            base.dialogs = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLDialog>.Value);
            base.messages = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsMessage>.Value);
            base.chats = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsChat>.Value);
            base.users = StreamingUtils.readTLVector(stream, context, ClassLiteral<TLAbsUser>.Value);
        }

        public override int getClassId() => 
            0x71e094f3;

        public virtual int getCount() => 
            this.count;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 6, 0x6c, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.count, stream);
            StreamingUtils.writeTLVector(base.dialogs, stream);
            StreamingUtils.writeTLVector(base.messages, stream);
            StreamingUtils.writeTLVector(base.chats, stream);
            StreamingUtils.writeTLVector(base.users, stream);
        }

        public virtual void setCount(int value)
        {
            this.count = value;
        }

        public override string toString() => 
            "messages.dialogsSlice#71e094f3";
    }
}

