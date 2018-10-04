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
    public class TLUpdateUserName : TLAbsUpdate
    {
        public const int CLASS_ID = -1489818765;
        private string firstName;
        private string lastName;
        private int userId;
        private string userName;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLUpdateUserName()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLUpdateUserName(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x43, 0x6c, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.userId = StreamingUtils.readInt(stream);
            this.firstName = StreamingUtils.readTLString(stream);
            this.lastName = StreamingUtils.readTLString(stream);
            this.userName = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            -1489818765;

        public virtual string getFirstName() => 
            this.firstName;

        public virtual string getLastName() => 
            this.lastName;

        public virtual int getUserId() => 
            this.userId;

        public virtual string getUserName() => 
            this.userName;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x3b, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.userId, stream);
            StreamingUtils.writeTLString(this.firstName, stream);
            StreamingUtils.writeTLString(this.lastName, stream);
            StreamingUtils.writeTLString(this.userName, stream);
        }

        public virtual void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public virtual void setLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public virtual void setUserId(int userId)
        {
            this.userId = userId;
        }

        public virtual void setUserName(string userName)
        {
            this.userName = userName;
        }

        public override string toString() => 
            "updateUserName#a7332b73";
    }
}

