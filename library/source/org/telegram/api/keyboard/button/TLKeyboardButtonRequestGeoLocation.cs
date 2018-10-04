namespace org.telegram.api.keyboard.button
{
    using IKVM.Attributes;
    using java.io;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class TLKeyboardButtonRequestGeoLocation : TLAbsKeyboardButton
    {
        public const int CLASS_ID = -59151553;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xa2, 0x68 })]
        public TLKeyboardButtonRequestGeoLocation()
        {
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected TLKeyboardButtonRequestGeoLocation(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xb1, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            base.text = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            -59151553;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x9f, 0xac, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeTLString(base.text, stream);
        }

        public override string toString() => 
            "keyboardButtonRequestGeoLocation#fc796b3f";
    }
}

