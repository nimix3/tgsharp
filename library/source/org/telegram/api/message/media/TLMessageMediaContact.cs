namespace org.telegram.api.message.media
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLMessageMediaContact : TLAbsMessageMedia
    {
        public const int CLASS_ID = 0x5e7d2f39;
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private int userId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLMessageMediaContact()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLMessageMediaContact(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 70, 0x6c, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.phoneNumber = StreamingUtils.readTLString(stream);
            this.firstName = StreamingUtils.readTLString(stream);
            this.lastName = StreamingUtils.readTLString(stream);
            this.userId = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            0x5e7d2f39;

        public virtual string getFirstName() => 
            this.firstName;

        public virtual string getLastName() => 
            this.lastName;

        public virtual string getPhoneNumber() => 
            this.phoneNumber;

        public virtual int getUserId() => 
            this.userId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x3d, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.phoneNumber, stream);
            StreamingUtils.writeTLString(this.firstName, stream);
            StreamingUtils.writeTLString(this.lastName, stream);
            StreamingUtils.writeInt(this.userId, stream);
        }

        public virtual void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public virtual void setLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public virtual void setPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public virtual void setUserId(int userId)
        {
            this.userId = userId;
        }

        public override string toString() => 
            "messageMediaContact#5e7d2f39";
    }
}

