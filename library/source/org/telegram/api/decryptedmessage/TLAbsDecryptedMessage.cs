namespace org.telegram.api.decryptedmessage
{
    using IKVM.Attributes;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public abstract class TLAbsDecryptedMessage : TLObject
    {
        protected internal long randomId;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(0x12)]
        public TLAbsDecryptedMessage()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAbsDecryptedMessage(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        public virtual long getRandomId() => 
            this.randomId;

        public virtual void setRandomId(long value)
        {
            this.randomId = value;
        }
    }
}

