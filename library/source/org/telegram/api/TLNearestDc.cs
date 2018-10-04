namespace org.telegram.api
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLNearestDc : TLObject
    {
        public const int CLASS_ID = -1910892683;
        private string country;
        private int nearestDc;
        private int thisDc;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 170, 0x68 })]
        public TLNearestDc()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLNearestDc(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x30, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.country = StreamingUtils.readTLString(stream);
            this.thisDc = StreamingUtils.readInt(stream);
            this.nearestDc = StreamingUtils.readInt(stream);
        }

        public override int getClassId() => 
            -1910892683;

        public virtual string getCountry() => 
            this.country;

        public virtual int getNearestDc() => 
            this.nearestDc;

        public virtual int getThisDc() => 
            this.thisDc;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x29, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.country, stream);
            StreamingUtils.writeInt(this.thisDc, stream);
            StreamingUtils.writeInt(this.nearestDc, stream);
        }

        public virtual void setCountry(string value)
        {
            this.country = value;
        }

        public virtual void setNearestDc(int value)
        {
            this.nearestDc = value;
        }

        public virtual void setThisDc(int value)
        {
            this.thisDc = value;
        }

        public override string toString() => 
            "nearestDc#8e1a1775";
    }
}

