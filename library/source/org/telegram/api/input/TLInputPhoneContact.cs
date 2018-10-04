namespace org.telegram.api.input
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLInputPhoneContact : TLObject
    {
        public const int CLASS_ID = -208488460;
        protected internal long clientId;
        protected internal string firstName;
        protected internal string lastName;
        protected internal string phone;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb6, 0x68 })]
        public TLInputPhoneContact()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputPhoneContact(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x4f, 0x6c, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.clientId = StreamingUtils.readLong(stream);
            this.phone = StreamingUtils.readTLString(stream);
            this.firstName = StreamingUtils.readTLString(stream);
            this.lastName = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            -208488460;

        public virtual long getClientId() => 
            this.clientId;

        public virtual string getFirstName() => 
            this.firstName;

        public virtual string getLastName() => 
            this.lastName;

        public virtual string getPhone() => 
            this.phone;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x47, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeLong(this.clientId, stream);
            StreamingUtils.writeTLString(this.phone, stream);
            StreamingUtils.writeTLString(this.firstName, stream);
            StreamingUtils.writeTLString(this.lastName, stream);
        }

        public virtual void setClientId(long value)
        {
            this.clientId = value;
        }

        public virtual void setFirstName(string value)
        {
            this.firstName = value;
        }

        public virtual void setLastName(string value)
        {
            this.lastName = value;
        }

        public virtual void setPhone(string value)
        {
            this.phone = value;
        }

        public override string toString() => 
            "inputPhoneContact#f392b7f4";
    }
}

