namespace org.telegram.mtproto.tl
{
    using IKVM.Attributes;
    using java.io;
    using java.lang;
    using java.util.regex;
    using org.telegram.tl;
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    [Serializable]
    public class MTRpcError : TLObject
    {
        public const int CLASS_ID = 0x2144ca19;
        private int errorCode;
        private string message;
        [Modifiers(0x1a)]
        private static Pattern REGEXP_PATTERN = Pattern.compile("[A-Z_0-9]+");

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb2, 0x88 })]
        public MTRpcError()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xad, 0x68, 0x67, 0x67 })]
        public MTRpcError(int errorCode, string message)
        {
            this.errorCode = errorCode;
            this.message = message;
        }

        [HideFromJava, SecurityPermission(SecurityAction.Demand, SerializationFormatter=true)]
        protected MTRpcError(SerializationInfo info1, StreamingContext context1) : base(info1, context1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void __<clinit>()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x16, 0x6c, 0x6c })]
        public override void deserializeBody(InputStream stream, TLContext context)
        {
            this.errorCode = StreamingUtils.readInt(stream);
            this.message = StreamingUtils.readTLString(stream);
        }

        public override int getClassId() => 
            0x2144ca19;

        public virtual int getErrorCode() => 
            this.errorCode;

        [MethodImpl(MethodImplOptions.NoInlining), LineNumberTable(new byte[] { 0x9f, 0xb7, 0x68, 0x86, 0x7f, 2, 0x68, 0x89 })]
        public virtual string getErrorTag()
        {
            if (this.message != null)
            {
                CharSequence sequence;
                sequence.__<ref> = this.message;
                Matcher matcher = REGEXP_PATTERN.matcher(sequence);
                if (matcher.find())
                {
                    return matcher.group();
                }
            }
            return "DEFAULT";
        }

        public virtual string getMessage() => 
            this.message;

        [MethodImpl(MethodImplOptions.NoInlining), Throws(new string[] { "java.io.IOException" }), LineNumberTable(new byte[] { 0x10, 0x6c, 110 })]
        public override void serializeBody(OutputStream stream)
        {
            StreamingUtils.writeInt(this.errorCode, stream);
            StreamingUtils.writeTLString(this.message, stream);
        }

        public override string toString() => 
            "rpc_error#2144ca19";
    }
}

