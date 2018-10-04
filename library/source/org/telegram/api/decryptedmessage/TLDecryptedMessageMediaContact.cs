namespace org.telegram.api.decryptedmessage
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLDecryptedMessageMediaContact : TLAbsDecryptedMessageMedia
    {
        public const int CLASS_ID = 0x588a0a97;
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private int userId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 180, 0x68 })]
        public TLDecryptedMessageMediaContact()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDecryptedMessageMediaContact(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 80, 0x6c, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.phoneNumber = StreamingUtils.readTLString(stream);
            this.firstName = StreamingUtils.readTLString(stream);
            this.lastName = StreamingUtils.readTLString(stream);
            this.userId = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            0x588a0a97;

        public virtual string getFirstName() => 
            this.firstName;

        public virtual string getLastName() => 
            this.lastName;

        public virtual string getPhoneNumber() => 
            this.phoneNumber;

        public virtual int getUserId() => 
            this.userId;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x47, 0x6c, 0x6c, 0x6c, 110 })]
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
            "decryptedMessageMediaContact#588a0a97";
    }
}

