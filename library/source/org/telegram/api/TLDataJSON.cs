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
    public class TLDataJSON : TLObject
    {
        public const int CLASS_ID = 0x7d748d04;
        private string data;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(15)]
        public TLDataJSON()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLDataJSON(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb2, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.data = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            0x7d748d04;

        public virtual string getData() => 
            this.data;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xad, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(this.data, stream);
        }

        public override string toString() => 
            "dataJSON#7d748d04";
    }
}

