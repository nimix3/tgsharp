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
    public class TLMessageActionChatAddUser : TLAbsMessageAction
    {
        public const int CLASS_ID = 0x488a7337;
        private TLIntVector users;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa8, 0x68 })]
        public TLMessageActionChatAddUser()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessageActionChatAddUser(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 190, 0x6d })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.users = StreamingUtils.readTLIntVector(stream, context);
        }

        public override int getClassId() => 
            0x488a7337;

        public virtual TLIntVector getUsers() => 
            this.users;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb9, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLVector(this.users, stream);
        }

        public virtual void setUsers(TLIntVector users)
        {
            this.users = users;
        }

        public override string toString() => 
            "messageActionChatAddUser#488a7337";
    }
}

