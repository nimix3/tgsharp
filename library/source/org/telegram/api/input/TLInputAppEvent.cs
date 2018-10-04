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
    public class TLInputAppEvent : TLObject
    {
        public const int CLASS_ID = 0x770656a8;
        private string data;
        private long peer;
        private double time;
        private string type;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xab, 0x68 })]
        public TLInputAppEvent()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLInputAppEvent(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x44, 0x6d, 0x6c, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.time = StreamingUtils.readDouble(stream);
            this.type = StreamingUtils.readTLString(stream);
            this.peer = StreamingUtils.readLong(stream);
            this.data = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            0x770656a8;

        public virtual string getData() => 
            this.data;

        public virtual long getPeer() => 
            this.peer;

        public virtual double getTime() => 
            this.time;

        public virtual string getType() => 
            this.type;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 60, 0x6c, 0x6c, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeDouble(this.time, stream);
            StreamingUtils.writeTLString(this.type, stream);
            StreamingUtils.writeLong(this.peer, stream);
            StreamingUtils.writeTLString(this.data, stream);
        }

        public virtual void setData(string value)
        {
            this.data = value;
        }

        public virtual void setPeer(long value)
        {
            this.peer = value;
        }

        public virtual void setTime(double value)
        {
            this.time = value;
        }

        public virtual void setType(string value)
        {
            this.type = value;
        }

        public override string toString() => 
            "inputAppEvent#770656a8";
    }
}

