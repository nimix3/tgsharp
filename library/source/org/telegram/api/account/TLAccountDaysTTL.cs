namespace org.telegram.api.account
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLAccountDaysTTL : TLObject
    {
        public const int CLASS_ID = -1194283041;
        private int days;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb2, 0x68 })]
        public TLAccountDaysTTL()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLAccountDaysTTL(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x13, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.days = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            -1194283041;

        public virtual int getDays() => 
            this.days;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 14, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.days, stream);
        }

        public virtual void setDays(int days)
        {
            this.days = days;
        }

        public override string toString() => 
            "account.accountDaysTLL#b8d0afdf";
    }
}

