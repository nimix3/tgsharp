namespace org.telegram.tl
{
    using IKVM.Attributes;
    using java.io;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLError : TLObject
    {
        public const int CLASS_ID = -994444869;
        protected internal int code;
        public string text;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(20)]
        public TLError()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLError(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 180, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.code = StreamingUtils.readInt(stream);
            this.text = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            -994444869;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xae, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.code, stream);
            StreamingUtils.writeTLString(this.text, stream);
        }

        public override string toString() => 
            "tlError#c4b9f9bb";
    }
}

