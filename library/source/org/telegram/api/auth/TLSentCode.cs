namespace org.telegram.api.auth
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.api.auth.codetype;
    using org.telegram.api.auth.sentcodetype;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLSentCode : TLObject
    {
        public const int CLASS_ID = 0x5e002502;
        private const int FLAG_NEXT_TYPE = 2;
        private const int FLAG_PHONE_REGISTERED = 1;
        private const int FLAG_TIMEOUT = 4;
        private int flags;
        private TLAbsCodeType nextType;
        private string phoneCodeHash;
        private int timeout;
        private TLAbsSentCodeType type;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 190, 0x68 })]
        public TLSentCode()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLSentCode(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x44, 0x6c, 0x72, 0x6c, 0x6a, 0x92, 0x6a, 140 })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.flags = StreamingUtils.readInt(stream);
            this.type = StreamingUtils.readTLObject(stream, context);
            this.phoneCodeHash = StreamingUtils.readTLString(stream);
            if ((this.flags & 2) != 0)
            {
                this.nextType = StreamingUtils.readTLObject(stream, context);
            }
            if ((this.flags & 4) != 0)
            {
                this.timeout = StreamingUtils.readInt(stream);
            }
        }

        public override int getClassId() => 
            0x5e002502;

        public virtual TLAbsCodeType getNextType() => 
            this.nextType;

        public virtual string getPhoneCodeHash() => 
            this.phoneCodeHash;

        public virtual int getTimeout() => 
            this.timeout;

        public virtual TLAbsSentCodeType getType() => 
            this.type;

        public virtual bool isPhoneRegistered() => 
            ((this.flags & 1) != 0);

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x37, 0x6c, 0x6c, 0x6c, 0x6a, 140, 0x6a, 0x8e })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.flags, stream);
            StreamingUtils.writeTLObject(this.type, stream);
            StreamingUtils.writeTLString(this.phoneCodeHash, stream);
            if ((this.flags & 2) != 0)
            {
                StreamingUtils.writeTLObject(this.nextType, stream);
            }
            if ((this.flags & 4) != 0)
            {
                StreamingUtils.writeInt(this.timeout, stream);
            }
        }

        public virtual void setNextType(TLAbsCodeType nextType)
        {
            this.nextType = nextType;
        }

        public virtual void setPhoneCodeHash(string phoneCodeHash)
        {
            this.phoneCodeHash = phoneCodeHash;
        }

        public virtual void setPhoneregfalse()
        {
            this.flags = 0;
        }

        public virtual void setTimeout(int timeout)
        {
            this.timeout = timeout;
        }

        public virtual void setType(TLAbsSentCodeType type)
        {
            this.type = type;
        }

        public override string toString() => 
            "auth.sentCode#5e002502";
    }
}

