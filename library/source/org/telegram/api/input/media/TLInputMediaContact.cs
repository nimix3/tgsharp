namespace org.telegram.api.input.media
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputMediaContact : TLAbsInputMedia
    {
        public const int CLASS_ID = -1494984313;
        private string firstName;
        private string lastName;
        private string phoneNumber;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa9, 0x68 })]
        public TLInputMediaContact()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputMediaContact(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x2f, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.phoneNumber = StreamingUtils.readTLString(stream);
            this.firstName = StreamingUtils.readTLString(stream);
            this.lastName = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            -1494984313;

        public virtual string getFirstName() => 
            this.firstName;

        public virtual string getLastName() => 
            this.lastName;

        public virtual string getPhoneNumber() => 
            this.phoneNumber;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 40, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.phoneNumber, stream);
            StreamingUtils.writeTLString(this.firstName, stream);
            StreamingUtils.writeTLString(this.lastName, stream);
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

        public override string toString() => 
            "inputMediaContact#a6e45987";
    }
}

