namespace org.telegram.api.message.action
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessageActionChatCreate : TLAbsMessageAction
    {
        public const int CLASS_ID = -1503425638;
        private string title;
        private TLIntVector users;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68 })]
        public TLMessageActionChatCreate()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessageActionChatCreate(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x1f, 0x6c, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.title = StreamingUtils.readTLString(stream);
            this.users = StreamingUtils.readTLIntVector(stream, context);
        }

        public override int getClassId() => 
            -1503425638;

        public virtual string getTitle() => 
            this.title;

        public virtual TLIntVector getUsers() => 
            this.users;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x18, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.title, stream);
            StreamingUtils.writeTLVector(this.users, stream);
        }

        public virtual void setTitle(string title)
        {
            this.title = title;
        }

        public virtual void setUsers(TLIntVector users)
        {
            this.users = users;
        }

        public override string toString() => 
            "messageActionChatCreate#a6638b9a";
    }
}

